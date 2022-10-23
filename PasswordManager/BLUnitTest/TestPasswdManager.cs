using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using NUnit.Framework;
using BusinessLayer.WorkingWithCrypto;
using BusinessLayer.WorkingWithPasswds;


namespace BLUnitTest
{
    public class TestPasswdManager
    {
        public class TestUserManager
        {
            private const string PasswdFile = "PasswdFile";
            private IPassword PasswdObj { get; set; }
            private byte[] VerificationLine { get; set; }
            private string VerificationHash { get; set; }
            private string Key { get; set; }
            private byte[] Iv { get; set; }
            private string User { get; set; }
            private string AccPass { get; set; }

            [SetUp]
            public void Setup()
            {
                User = "daco";
                AccPass = "123456789";
                Key = User + AccPass;

                VerificationLine = RandomNumberGenerator.GetBytes(512);
                VerificationHash =
                    CryptoFunc.StringToHashBase64(Encoding.UTF8.GetString(VerificationLine)).Result;

                Iv = Encoding.UTF8.GetBytes(VerificationHash).Take(16).ToArray();
            }

            [Test]
            public void TestFirstStart()
            {
                File.Delete(PasswdFile);
                var crypto = new CryptographyHandler();
                crypto.SetUpKey(Key, Iv);

                PasswdObj = new PasswdManager(crypto, PasswdFile, VerificationLine);
                PasswdObj.CloseHandler();

                Assert.True(File.Exists(PasswdFile));
                var file = File.Open(PasswdFile, FileMode.Open);
                Assert.AreEqual(512, file.Length);
                file.Close();
            }

            [Test]
            public void TestLoad()
            {
                TestFirstStart();

                var crypto = new CryptographyHandler();
                crypto.SetUpKey(Key, Iv);

                PasswdObj = new PasswdManager(crypto, PasswdFile, null);
                Assert.True(PasswdObj.CheckAndLoadFile(CryptoFunc.StringToHashBase64(Encoding
                    .UTF8.GetString(VerificationLine)).Result).Result);

                PasswdObj.CloseHandler();

                Assert.True(File.Exists(PasswdFile));
                var file = File.Open(PasswdFile, FileMode.Open);
                Assert.AreEqual(512, file.Length);
                file.Close();


                crypto = new CryptographyHandler();
                crypto.SetUpKey(Key + "abcd", Iv);

                PasswdObj = new PasswdManager(crypto, PasswdFile, null);
                Assert.True(!PasswdObj.CheckAndLoadFile(CryptoFunc.StringToHashBase64(Encoding
                    .UTF8.GetString(VerificationLine)).Result).Result);
                PasswdObj.CloseHandler();
            }

            [Test]
            public void TestLoadPasswd()
            {
                TestFirstStart();

                var crypto = new CryptographyHandler();
                crypto.SetUpKey(Key, Iv);

                PasswdObj = new PasswdManager(crypto, PasswdFile, null);
                Assert.True(PasswdObj.CheckAndLoadFile(CryptoFunc.StringToHashBase64(Encoding
                    .UTF8.GetString(VerificationLine)).Result).Result);

                Assert.True(PasswdObj.LoadPasswd("123", "abcd", "12345689").Result);

                Assert.True(!PasswdObj.LoadPasswd("123", "abcd", "12345689").Result);

                Assert.True(PasswdObj.LoadPasswd("1234", "a", "1").Result);

                Assert.True(PasswdObj.LoadPasswd("12345", "abcd", "12345689").Result);

                Assert.True(PasswdObj.LoadPasswd("1", "abcd", "12345689").Result);

                Assert.True(!PasswdObj.LoadPasswd("1234", "abcd", "12345689").Result);

                Assert.True(!PasswdObj.LoadPasswd("1", "abcd", "12345689").Result);

                Assert.True(PasswdObj.LoadPasswd("abcd", "123a", "12345689").Result);

                Assert.True(PasswdObj.LoadPasswd("efgh", "1abc", "12345689").Result);

                Assert.True(PasswdObj.LoadPasswd("abcdefh", "ab12", "12345689").Result);

                Assert.True(PasswdObj.LoadPasswd("daco", "12cd", "12345689").Result);

                PasswdObj.CloseHandler();
            }

            [Test]
            public void TestGetPasswd()
            {
                TestLoadPasswd();

                var crypto = new CryptographyHandler();
                crypto.SetUpKey(Key, Iv);

                PasswdObj = new PasswdManager(crypto, PasswdFile, null);
                var tmp = CryptoFunc.StringToHashBase64(Encoding.UTF8.GetString(VerificationLine))
                    .Result;
                Assert.True(PasswdObj.CheckAndLoadFile(tmp).Result);

                var passwds = PasswdObj.ShowPasswds();
                Assert.True(passwds.Count == 8);
                Assert.True(passwds.Keys.Contains("123"));
                Assert.True(passwds.Keys.Contains("1234"));
                Assert.True(passwds.Keys.Contains("12345"));
                Assert.True(passwds.Keys.Contains("1"));
                Assert.True(passwds.Keys.Contains("efgh"));
                Assert.True(passwds.Keys.Contains("abcd"));
                Assert.True(passwds.Keys.Contains("abcdefh"));
                Assert.True(passwds.Keys.Contains("daco"));

                var passwd = PasswdObj.GetPasswd(passwds["123"]);
                Assert.AreEqual("123", passwd.Alias);
                Assert.AreEqual("abcd", passwd.Username);
                Assert.AreEqual("12345689", passwd.Password);

                passwd = PasswdObj.GetPasswd(passwds["1"]);
                Assert.AreEqual("1", passwd.Alias);
                Assert.AreEqual("abcd", passwd.Username);
                Assert.AreEqual("12345689", passwd.Password);

                passwd = PasswdObj.GetPasswd(passwds["abcdefh"]);
                Assert.AreEqual("abcdefh", passwd.Alias);
                Assert.AreEqual("ab12", passwd.Username);
                Assert.AreEqual("12345689", passwd.Password);

                passwd = PasswdObj.GetPasswd(passwds["daco"]);
                Assert.AreEqual("daco", passwd.Alias);
                Assert.AreEqual("12cd", passwd.Username);
                Assert.AreEqual("12345689", passwd.Password);

                passwd = PasswdObj.GetPasswd(1000);
                Assert.AreEqual(null, passwd);
                PasswdObj.CloseHandler();
            }

            [Test]
            public void TestChangeAccPasswd()
            {
                TestLoadPasswd();

                var crypto = new CryptographyHandler();
                crypto.SetUpKey(Key, Iv);

                PasswdObj = new PasswdManager(crypto, PasswdFile, null);
                Assert.True(PasswdObj.CheckAndLoadFile(CryptoFunc.StringToHashBase64(Encoding
                    .UTF8.GetString(VerificationLine)).Result).Result);

                var newPasswd = "asjflasf5654";
                Assert.AreEqual(RetVal.WrongPasswd,
                    PasswdObj.ChangeAccountPasswd(User, AccPass + "1234", newPasswd)
                        .Result);

                Assert.AreEqual(RetVal.Success,
                    PasswdObj.ChangeAccountPasswd(User, AccPass, newPasswd)
                        .Result);
                PasswdObj.CloseHandler();


                crypto = new CryptographyHandler();
                crypto.SetUpKey(User + newPasswd, Iv);

                PasswdObj = new PasswdManager(crypto, PasswdFile, null);
                Assert.True(PasswdObj.CheckAndLoadFile(CryptoFunc.StringToHashBase64(Encoding
                    .UTF8.GetString(VerificationLine)).Result).Result);

                Assert.True(PasswdObj.ShowPasswds().Count == 8);
                PasswdObj.CloseHandler();
            }

            [Test]
            public void TestDeletePasswd()
            {
                TestLoadPasswd();

                var crypto = new CryptographyHandler();
                crypto.SetUpKey(Key, Iv);

                PasswdObj = new PasswdManager(crypto, PasswdFile, null);
                Assert.True(PasswdObj.CheckAndLoadFile(VerificationHash).Result);

                PasswdObj.DeletePasswd(7).Wait();
                Assert.True(PasswdObj.ShowPasswds().Count == 7);
                Assert.True(!PasswdObj.ShowPasswds().Keys.Contains("daco"));

                PasswdObj.DeletePasswd(0).Wait();
                Assert.True(PasswdObj.ShowPasswds().Count == 6);
                Assert.True(!PasswdObj.ShowPasswds().Keys.Contains("123"));

                PasswdObj.DeletePasswd(2).Wait();
                Assert.True(PasswdObj.ShowPasswds().Count == 5);
                Assert.True(!PasswdObj.ShowPasswds().Keys.Contains("1"));

                for (int i = 4; i >= 0; i--)
                {
                    PasswdObj.DeletePasswd(0).Wait();
                    Assert.True(PasswdObj.ShowPasswds().Count == i);
                }

                PasswdObj.CloseHandler();
            }

            [Test]
            public void TestFilter()
            {
                TestLoadPasswd();

                var crypto = new CryptographyHandler();
                crypto.SetUpKey(Key, Iv);

                PasswdObj = new PasswdManager(crypto, PasswdFile, null);
                Assert.True(PasswdObj.CheckAndLoadFile(VerificationHash).Result);

                var passwdDict = PasswdObj.FilterAndShowPasswds("", "").Result;
                Assert.AreEqual(PasswdObj.ShowPasswds(), passwdDict);

                passwdDict = PasswdObj.FilterAndShowPasswds("123", "").Result;
                Assert.True(passwdDict.Count == 3);

                passwdDict = PasswdObj.FilterAndShowPasswds("12", "").Result;
                Assert.True(passwdDict.Count == 3);

                passwdDict = PasswdObj.FilterAndShowPasswds("1", "").Result;
                Assert.True(passwdDict.Count == 4);

                passwdDict = PasswdObj.FilterAndShowPasswds("d", "").Result;
                Assert.True(passwdDict.Count == 3);

                passwdDict = PasswdObj.FilterAndShowPasswds("ef", "").Result;
                Assert.True(passwdDict.Count == 2);

                passwdDict = PasswdObj.FilterAndShowPasswds("abcdefh", "").Result;
                Assert.True(passwdDict.Count == 1);

                passwdDict = PasswdObj.FilterAndShowPasswds("abc64asfdefhasfasf", "").Result;
                Assert.True(passwdDict.Count == 0);


                passwdDict = PasswdObj.FilterAndShowPasswds("", "cd").Result;
                Assert.True(passwdDict.Count == 4);

                passwdDict = PasswdObj.FilterAndShowPasswds("", "c").Result;
                Assert.True(passwdDict.Count == 5);

                passwdDict = PasswdObj.FilterAndShowPasswds("", "1").Result;
                Assert.True(passwdDict.Count == 4);

                passwdDict = PasswdObj.FilterAndShowPasswds("", "a").Result;
                Assert.True(passwdDict.Count == 7);


                passwdDict = PasswdObj.FilterAndShowPasswds("1234", "abcd").Result;
                Assert.True(passwdDict.Count == 1);
                PasswdObj.CloseHandler();
            }

            [Test]
            public void TestSort()
            {
                TestLoadPasswd();

                var crypto = new CryptographyHandler();
                crypto.SetUpKey(Key, Iv);

                PasswdObj = new PasswdManager(crypto, PasswdFile, null);
                Assert.True(PasswdObj.CheckAndLoadFile(VerificationHash).Result);

                var passwdDict = PasswdObj.ShowPasswds();
                var keysList = passwdDict.Keys.ToList();

                var sorted = PasswdObj.SortAliases(passwdDict, "Default").Result;
                Assert.True(sorted.Count == 8);
                for (int i = 0; i < sorted.Count; i++)
                {
                    Assert.AreEqual(sorted[i], keysList[i]);
                }

                sorted = PasswdObj.SortAliases(passwdDict, "Ascending sort").Result;
                var keyListSorted = new List<string>
                    {"1", "123", "1234", "12345", "abcd", "abcdefh", "daco", "efgh"};
                Assert.True(sorted.Count == 8);
                for (int i = 0; i < sorted.Count; i++)
                {
                    Assert.AreEqual(sorted[i], keyListSorted[i]);
                }

                sorted = PasswdObj.SortAliases(passwdDict, "Descending sort").Result;
                keyListSorted = new List<string>
                    {"1", "123", "1234", "12345", "abcd", "abcdefh", "daco", "efgh"};
                keyListSorted.Reverse();
                Assert.True(sorted.Count == 8);
                for (int i = 0; i < sorted.Count; i++)
                {
                    Assert.AreEqual(sorted[i], keyListSorted[i]);
                }


                PasswdObj.CloseHandler();
            }
        }
    }
}