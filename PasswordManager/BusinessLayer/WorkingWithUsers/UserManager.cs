using System.Runtime.CompilerServices;
using System.Text;
using System.Security.Cryptography;
using BusinessLayer.WorkingWithCrypto;
using BusinessLayer.WorkingWithFiles;
using BusinessLayer.WorkingWithPasswds;


[assembly: InternalsVisibleTo("BLUnitTest")]

namespace BusinessLayer.WorkingWithUsers
{
    public class UserManager : IUser
    {
        /*
         * User file name is obfuscated combination of username and index in log file
         * Obfuscation is made with SHA512 and BASE64 algorithms:
         *      UserFilePath = BASE64(SHA512(username + index_in_log))
         */

        private const int BlockSize = 256;
        private const int BlockPartsCount = 3;
        private const int PasswdBlockSize = 512;
        private const int PasswdBlockPartsCount = 4;
        private const string BasePath = "PasswdManagerDir\\";
        private const string LogFileName = "LogFile";

        private string PasswdVerificationHash { get; set; }
        public string Username { get; private set; }
        private IFile LogFile { get; }
        private string UserFilePath { get; set; }
        private List<LogRecord> LogRecords { get; set; }

        public UserManager()
        {
            Username = null;

            byte[] newFileVerificLine = null;
            if (!File.Exists(BasePath + LogFileName))
            {
                Directory.CreateDirectory(BasePath);
                File.Create(BasePath + LogFileName).Dispose();
                newFileVerificLine = LogFileVerification.VerificationLine;
            }

            var creationTime = File.GetCreationTime(BasePath + LogFileName);
            var cryptoHandler = new CryptographyHandler();
            cryptoHandler.SetUpKey(creationTime.Ticks.ToString(), LogFileVerification.LogFileIv);

            LogFile = new FileHandler(cryptoHandler, BlockSize, BlockPartsCount,
                BasePath + LogFileName, FormatTypes.LogFormat, newFileVerificLine);

            if (!LogFile.VerificationLine.SequenceEqual(LogFileVerification.VerificationLine))
            {
                throw new Exception();
            }

            LogFile.AcceptFile().Wait();
            FromListBytesToRecords();
        }

        private void FromListBytesToRecords()
        {
            LogRecords = new List<LogRecord>();

            foreach (var blockParts in LogFile.BlockPartsList)
            {
                LogRecords.Add(LogFormat.FromArrayBytesToRecord(blockParts));
            }
        }

        private CryptographyHandler CreateCryptoHandler(string passwd)
        {
            var iv = Encoding.UTF8.GetBytes(PasswdVerificationHash).Take(16).ToArray();
            var cryptoHandler = new CryptographyHandler();
            cryptoHandler.SetUpKey(Username + passwd, iv);

            return cryptoHandler;
        }

        private async Task CreateFilePath()
        {
            var fileName = (await CryptoFunc.StringToHashBase64(Username + PasswdVerificationHash))
                .Replace('/', '_');
            UserFilePath = BasePath + fileName;
        }

        public async Task<IPassword> SignUp(string username, string passwd)
        {
            var sameUser = LogRecords.FirstOrDefault(record => record.Username == username, null);
            if (sameUser != null)
            {
                return null;
            }

            Username = username;

            byte[] verificationLine = RandomNumberGenerator.GetBytes(PasswdBlockSize);
            PasswdVerificationHash = await CryptoFunc.StringToHashBase64(
                Encoding.UTF8.GetString(verificationLine));
            await CreateFilePath();

            var cryptoHandler = CreateCryptoHandler(passwd);
            var passwdHandler = await Task.Run(() => new PasswdManager(cryptoHandler,
                UserFilePath, verificationLine));

            var index = LogRecords.Count == 0 ? 1 : LogRecords.Last().Index + 1;
            var newRecord = new LogRecord
            {
                Index = index, Username = Username, VerificationHash = PasswdVerificationHash
            };
            LogRecords.Add(newRecord);

            LogFile.AppendBlock(LogFormat.FromRecordToArrayBytes(newRecord));
            await LogFile.WriteFile();
            return passwdHandler;
        }

        public async Task<IPassword> SignIn(string username, string passwd)
        {
            var sameUser = LogRecords.FirstOrDefault(record => record.Username == username, null);
            if (sameUser == null)
            {
                return null;
            }

            Username = sameUser.Username;
            PasswdVerificationHash = sameUser.VerificationHash;
            await CreateFilePath();

            var cryptoHandler = CreateCryptoHandler(passwd);

            var passwdHandler = await Task.Run(() => new PasswdManager(cryptoHandler,
                UserFilePath, null));
            if (!await passwdHandler.CheckAndLoadFile(PasswdVerificationHash))
            {
                Username = null;
                passwdHandler.CloseHandler();
                return null;
            }

            return passwdHandler;
        }

        public void CloseHandler()
        {
            LogFile.WriteFile().Wait();
            LogFile.DisposeOfObjects();
        }

        public void CloseHandlerNoDispose()
        {
            LogFile.WriteFile().Wait();
        }
    }
}