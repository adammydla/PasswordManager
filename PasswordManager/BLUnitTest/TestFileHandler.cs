using System.IO;
using System.Security.Cryptography;
using System.Text;
using NUnit.Framework;
using BusinessLayer.WorkingWithFiles;
using BusinessLayer.WorkingWithCrypto;

namespace BLUnitTest
{
    public class TestFileHandler
    {
        private IFile FileHandler { get; set; }
        private byte[] VerificationLine { get; set; }
        private string Key { get; set; }
        private byte[] Iv { get; set; }

        [SetUp]
        public void Setup()
        {
            Iv = RandomNumberGenerator.GetBytes(16);
            Key = "123456789";
            Directory.CreateDirectory("aTestFiles");
        }

        [Test]
        public void TestNewFilePasswd()
        {
            string filePath = "aTestFiles//test_file.txt";
            File.Delete(filePath);

            var crypto = new CryptographyHandler();
            crypto.SetUpKey(Key, Iv);

            VerificationLine = RandomNumberGenerator.GetBytes(512);
            FileHandler = new FileHandler(crypto, 512, 4, filePath,
                FormatTypes.PasswdFormat, VerificationLine);
            Assert.AreEqual(FileHandler.BlockPartsList.Count, 0);
            Assert.AreEqual(VerificationLine, FileHandler.VerificationLine);

            FileHandler.DisposeOfObjects();


            Assert.True(File.Exists(filePath));
            var fileOpened = File.Open(filePath, FileMode.Open);
            Assert.AreEqual(fileOpened.Length, 512);
            fileOpened.Dispose();


            crypto = new CryptographyHandler();
            crypto.SetUpKey(Key, Iv);
            var fileContent = File.ReadAllBytes(filePath);
            var blocksEncrypted = crypto.Encrypt(VerificationLine).Result;
            Assert.AreEqual(fileContent, blocksEncrypted);
        }

        [Test]
        public void TestLoadFilePasswd()
        {
            string filePath = "aTestFiles//test_file1.txt";
            File.Delete(filePath);

            var crypto = new CryptographyHandler();
            crypto.SetUpKey(Key, Iv);

            VerificationLine = RandomNumberGenerator.GetBytes(512);
            FileHandler = new FileHandler(crypto, 512, 4, filePath,
                FormatTypes.PasswdFormat, VerificationLine);
            FileHandler.DisposeOfObjects();

            crypto = new CryptographyHandler();
            crypto.SetUpKey(Key, Iv);
            FileHandler = new FileHandler(crypto, 512, 4, filePath,
                FormatTypes.PasswdFormat, null);
            Assert.AreEqual(VerificationLine, FileHandler.VerificationLine);
            Assert.AreEqual(0, FileHandler.BlockPartsList.Count);
            FileHandler.WriteFile().Wait();
            FileHandler.DisposeOfObjects();


            crypto = new CryptographyHandler();
            crypto.SetUpKey(Key, Iv);
            FileHandler = new FileHandler(crypto, 512, 4, filePath,
                FormatTypes.PasswdFormat, null);
            FileHandler.AcceptFile().Wait();
            Assert.AreEqual(VerificationLine, FileHandler.VerificationLine);
            Assert.AreEqual(0, FileHandler.BlockPartsList.Count);

            FileHandler.ReReadFile().Wait();
            Assert.AreEqual(VerificationLine, FileHandler.VerificationLine);
            Assert.AreEqual(0, FileHandler.BlockPartsList.Count);

            FileHandler.DisposeOfObjects();
        }

        [Test]
        public void TestAddRecordsFilePasswd()
        {
            string filePath = "aTestFiles//test_file2.txt";
            File.Delete(filePath);

            var crypto = new CryptographyHandler();
            crypto.SetUpKey(Key, Iv);

            VerificationLine = RandomNumberGenerator.GetBytes(512);
            FileHandler = new FileHandler(crypto, 512, 4, filePath,
                FormatTypes.PasswdFormat, VerificationLine);
            FileHandler.AcceptFile().Wait();

            Assert.AreEqual(VerificationLine, FileHandler.VerificationLine);

            var x = new byte[4][];
            x[0] = Encoding.UTF8.GetBytes("123");
            x[1] = Encoding.UTF8.GetBytes("abcd");
            x[2] = Encoding.UTF8.GetBytes("efgh");
            x[3] = Encoding.UTF8.GetBytes("123456789asdfghjkl");
            FileHandler.AppendBlock(x);

            var y = new byte[4][];
            y[0] = Encoding.UTF8.GetBytes("12");
            y[1] = Encoding.UTF8.GetBytes("ab");
            y[2] = Encoding.UTF8.GetBytes("ef");
            y[3] = Encoding.UTF8.GetBytes("123456789asdfghjkl");
            FileHandler.AppendBlock(y);

            var z = new byte[4][];
            z[0] = Encoding.UTF8.GetBytes("1");
            z[1] = Encoding.UTF8.GetBytes("abcdefghijkl");
            z[2] = Encoding.UTF8.GetBytes("abcdefghijkl");
            z[3] = Encoding.UTF8.GetBytes("111222333444555666777888999");
            FileHandler.AppendBlock(z);

            FileHandler.WriteFile().Wait();
            FileHandler.ReReadFile().Wait();

            Assert.AreEqual(VerificationLine, FileHandler.VerificationLine);
            Assert.AreEqual(3, FileHandler.BlockPartsList.Count);

            Assert.AreEqual(FileHandler.BlockPartsList[0], x);
            Assert.AreEqual(FileHandler.BlockPartsList[1], y);
            Assert.AreEqual(FileHandler.BlockPartsList[2], z);

            FileHandler.DisposeOfObjects();

            crypto = new CryptographyHandler();
            crypto.SetUpKey(Key, Iv);
            FileHandler = new FileHandler(crypto, 512, 4, filePath,
                FormatTypes.PasswdFormat, null);
            FileHandler.AcceptFile().Wait();

            Assert.AreEqual(VerificationLine, FileHandler.VerificationLine);
            Assert.AreEqual(3, FileHandler.BlockPartsList.Count);

            Assert.AreEqual(FileHandler.BlockPartsList[0], x);
            Assert.AreEqual(FileHandler.BlockPartsList[1], y);
            Assert.AreEqual(FileHandler.BlockPartsList[2], z);
        }


        [Test]
        public void TestUpdateDeleteRecordsFilePasswd()
        {
            string filePath = "aTestFiles//test_file3.txt";
            File.Delete(filePath);

            var crypto = new CryptographyHandler();
            crypto.SetUpKey(Key, Iv);

            VerificationLine = RandomNumberGenerator.GetBytes(512);
            FileHandler = new FileHandler(crypto, 512, 4, filePath,
                FormatTypes.PasswdFormat, VerificationLine);
            FileHandler.AcceptFile().Wait();

            Assert.AreEqual(VerificationLine, FileHandler.VerificationLine);

            var x = new byte[4][];
            x[0] = Encoding.UTF8.GetBytes("123");
            x[1] = Encoding.UTF8.GetBytes("abcd");
            x[2] = Encoding.UTF8.GetBytes("efgh");
            x[3] = Encoding.UTF8.GetBytes("123456789asdfghjkl");
            FileHandler.AppendBlock(x);

            var y = new byte[4][];
            y[0] = Encoding.UTF8.GetBytes("12");
            y[1] = Encoding.UTF8.GetBytes("ab");
            y[2] = Encoding.UTF8.GetBytes("ef");
            y[3] = Encoding.UTF8.GetBytes("123456789asdfghjkl");
            FileHandler.AppendBlock(y);

            var z = new byte[4][];
            z[0] = Encoding.UTF8.GetBytes("1");
            z[1] = Encoding.UTF8.GetBytes("abcdefghijkl");
            z[2] = Encoding.UTF8.GetBytes("abcdefghijkl");
            z[3] = Encoding.UTF8.GetBytes("111222333444555666777888999");
            FileHandler.AppendBlock(z);

            FileHandler.WriteFile().Wait();
            FileHandler.ReReadFile().Wait();


            var z1 = new byte[4][];
            z1[0] = Encoding.UTF8.GetBytes("1234");
            z1[1] = Encoding.UTF8.GetBytes("asdc");
            z1[2] = Encoding.UTF8.GetBytes("asdc");
            z1[3] = Encoding.UTF8.GetBytes("qwertzuio");
            FileHandler.UpdateBlock(2, z1);

            var y1 = new byte[4][];
            y1[0] = Encoding.UTF8.GetBytes("1234");
            y1[1] = Encoding.UTF8.GetBytes("abcd");
            y1[2] = Encoding.UTF8.GetBytes("efgh");
            y1[3] = Encoding.UTF8.GetBytes("123456789asdfghjkl");
            FileHandler.UpdateBlock(1, y1);

            FileHandler.DeleteBlock(0);


            FileHandler.WriteFile().Wait();
            FileHandler.ReReadFile().Wait();

            Assert.AreEqual(VerificationLine, FileHandler.VerificationLine);
            Assert.AreEqual(2, FileHandler.BlockPartsList.Count);

            Assert.AreEqual(FileHandler.BlockPartsList[0], y1);
            Assert.AreEqual(FileHandler.BlockPartsList[1], z1);
        }
    }
}