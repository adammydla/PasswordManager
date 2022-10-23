using System.Text;
using System.Runtime.CompilerServices;
using BusinessLayer.WorkingWithCrypto;
using BusinessLayer.WorkingWithFiles;
using PasswordGenerator;


[assembly: InternalsVisibleTo("BLUnitTest")]

namespace BusinessLayer.WorkingWithPasswds
{
    public class PasswdManager : IPassword
    {
        private const int BlockSize = 512;
        private const int BlockPartsCount = 4;

        private CryptographyHandler CryptoHandler { get; }
        private string PasswdFilePath { get; }
        private string PasswdVerificationHash { get; }
        private IFile PasswdFile { get; }
        private List<PasswdRecord> Passwords { get; }

        internal PasswdManager(CryptographyHandler handler, string filePath,
            byte[] verificationLine)
        {
            PasswdFilePath = filePath;
            CryptoHandler = handler;

            PasswdFile = new FileHandler(CryptoHandler, BlockSize, BlockPartsCount,
                PasswdFilePath, FormatTypes.PasswdFormat, verificationLine);

            PasswdVerificationHash = CryptoFunc.StringToHashBase64
                (Encoding.UTF8.GetString(PasswdFile.VerificationLine)).Result;

            Passwords = new List<PasswdRecord>();
        }

        private void FromListBytesToRecords()
        {
            Passwords.Clear();

            foreach (var blockParts in PasswdFile.BlockPartsList)
            {
                Passwords.Add(PasswdFormat.FromArrayBytesToRecord(blockParts));
            }
        }

        public async Task<bool> CheckAndLoadFile(string verificationHash)
        {
            var sameHashes =
                await Task.FromResult(PasswdVerificationHash.SequenceEqual(verificationHash));

            if (!sameHashes)
            {
                return false;
            }

            await PasswdFile.AcceptFile();
            await Task.Run(FromListBytesToRecords);
            return true;
        }

        public async Task<RetVal> ChangeAccountPasswd(string username, string oldPasswd,
            string newPasswd)
        {
            if (!await CryptoHandler.CompareKeys(username + oldPasswd))
            {
                return RetVal.WrongPasswd;
            }

            var iv = Encoding.UTF8.GetBytes(PasswdVerificationHash).Take(16).ToArray();
            CryptoHandler.SetUpKey(username + newPasswd, iv);
            await PasswdFile.WriteFile();
            return RetVal.Success;
        }

        public Task<bool> LoadPasswd(string alias, string username, string passwd) => Task.Run(() =>
        {
            var sameAlias = Passwords.FirstOrDefault(record => record.Alias == alias, null);
            if (sameAlias != null)
            {
                return false;
            }

            var index = Passwords.Count == 0 ? 1 : Passwords.Last().Index + 1;
            var newRecord = new PasswdRecord
            {
                Index = index, Alias = alias, Username = username, Password = passwd
            };

            Passwords.Add(newRecord);

            PasswdFile.AppendBlock(PasswdFormat.FromRecordToArrayBytes(newRecord));
            return true;
        });

        public Dictionary<string, int> ShowPasswds()
        {
            return Passwords
                .Zip
                    (Enumerable.Range(0, Passwords.Count))
                .ToDictionary(tuple => tuple.First.Alias, tuple => tuple.Second);
        }

        public Task<Dictionary<string, int>> FilterAndShowPasswds(string alias, string username)
            => Task.Run(() =>
            {
                return Passwords
                    .Where(record =>
                        record.Username.Contains(username) && record.Alias.Contains(alias))
                    .Zip
                        (Enumerable.Range(0, Passwords.Count))
                    .ToDictionary(tuple => tuple.First.Alias, tuple => tuple.Second);
            });

        public Task<List<string>> SortAliases(Dictionary<string, int> aliasIndices, string sortType)
            => Task.Run(() =>
            {
                var aliases = aliasIndices.Keys.ToList();
                switch (sortType)
                {
                    case "Ascending sort":
                        aliases.Sort();
                        break;
                    case "Descending sort":
                        aliases.Sort();
                        aliases.Reverse();
                        break;
                }

                return aliases;
            });

        public PasswdRecord GetPasswd(int index)
        {
            if (index >= Passwords.Count)
            {
                return null;
            }

            return Passwords[index];
        }

        public Task DeletePasswd(int index) => Task.Run(() =>
        {
            if (index >= Passwords.Count)
            {
                return;
            }

            Passwords.RemoveAt(index);
            PasswdFile.DeleteBlock(index);
        });

        public Task<string> GeneratePasswd() => Task.Run(() =>
        {
            var passwdGen = new Password(128);
            return passwdGen.Next();
        });

        public void CloseHandler()
        {
            PasswdFile.WriteFile().Wait();
            PasswdFile.DisposeOfObjects();
        }

        public void CloseHandlerNoDispose()
        {
            PasswdFile.WriteFile().Wait();
        }
    }
}