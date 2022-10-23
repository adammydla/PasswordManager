using System.IO;
using NUnit.Framework;
using BusinessLayer.WorkingWithUsers;

namespace BLUnitTest
{
    public class TestUserManager
    {
        private const string LogFile = "PasswdManagerDir\\LogFile";
        private IUser UserObj { get; set; }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestFirstStart()
        {
            if (Directory.Exists("PasswdManagerDir\\") && File.Exists(LogFile))
            {
                Directory.Delete("PasswdManagerDir\\", true);
            }

            UserObj = new UserManager();
            UserObj.CloseHandler();

            Assert.True(File.Exists(LogFile));
            var file = File.Open(LogFile, FileMode.Open);
            Assert.AreEqual(256, file.Length);
            file.Close();
        }

        [Test]
        public void TestLoad()
        {
            TestFirstStart();

            UserObj = new UserManager();
            UserObj.CloseHandler();

            Assert.True(File.Exists(LogFile));
            var file = File.Open(LogFile, FileMode.Open);
            Assert.AreEqual(256, file.Length);
            file.Close();
        }

        [Test]
        public void TestSignUp()
        {
            TestFirstStart();

            UserObj = new UserManager();
            var x1 = UserObj.SignUp("adam", "123456789abcd").Result;
            Assert.True(x1 != null);
            Assert.AreEqual(UserObj.Username, "adam");
            UserObj.CloseHandler();
            x1.CloseHandler();

            Assert.True(File.Exists(LogFile));
            var file = File.Open(LogFile, FileMode.Open);
            Assert.AreEqual(512, file.Length);
            file.Close();


            UserObj = new UserManager();
            var x2 = UserObj.SignUp("adam", "123456789abcd").Result;
            Assert.True(x2 == null);
            Assert.AreEqual(UserObj.Username, null);

            var x3 = UserObj.SignUp("adam", "12345").Result;
            Assert.True(x3 == null);
            Assert.AreEqual(UserObj.Username, null);
            UserObj.CloseHandler();

            Assert.True(File.Exists(LogFile));
            file = File.Open(LogFile, FileMode.Open);
            Assert.AreEqual(512, file.Length);
            file.Close();


            UserObj = new UserManager();
            var y1 = UserObj.SignUp("adam123", "123456789abcd").Result;
            Assert.True(y1 != null);
            Assert.AreEqual(UserObj.Username, "adam123");
            UserObj.CloseHandler();
            y1.CloseHandler();

            Assert.True(File.Exists(LogFile));
            file = File.Open(LogFile, FileMode.Open);
            Assert.AreEqual(512 + 256, file.Length);
            file.Close();


            UserObj = new UserManager();
            var y2 = UserObj.SignUp("adam12", "123456789abcd").Result;
            Assert.True(y2 != null);
            Assert.AreEqual(UserObj.Username, "adam12");
            UserObj.CloseHandler();
            y2.CloseHandler();

            Assert.True(File.Exists(LogFile));
            file = File.Open(LogFile, FileMode.Open);
            Assert.AreEqual(512 + 512, file.Length);
            file.Close();
        }

        [Test]
        public void TestSignIn()
        {
            TestSignUp();

            UserObj = new UserManager();
            var y = UserObj.SignIn("adam", "123456789abcd").Result;
            Assert.True(y != null);
            Assert.AreEqual(UserObj.Username, "adam");
            UserObj.CloseHandler();
            y.CloseHandler();

            UserObj = new UserManager();
            y = UserObj.SignIn("adam12", "123456789abcd").Result;
            Assert.True(y != null);
            Assert.AreEqual(UserObj.Username, "adam12");
            UserObj.CloseHandler();
            y.CloseHandler();

            UserObj = new UserManager();
            y = UserObj.SignIn("adam123", "123456789abcd").Result;
            Assert.True(y != null);
            Assert.AreEqual(UserObj.Username, "adam123");
            UserObj.CloseHandler();
            y.CloseHandler();


            UserObj = new UserManager();
            var x = UserObj.SignIn("adam9", "123456789abcd").Result;
            Assert.True(x == null);
            Assert.AreEqual(UserObj.Username, null);
            UserObj.CloseHandler();

            UserObj = new UserManager();
            x = UserObj.SignIn("Adam", "123456789abcd").Result;
            Assert.True(x == null);
            Assert.AreEqual(UserObj.Username, null);
            UserObj.CloseHandler();

            UserObj = new UserManager();
            x = UserObj.SignIn("xyz123", "123456789abcd").Result;
            Assert.True(x == null);
            Assert.AreEqual(UserObj.Username, null);
            UserObj.CloseHandler();
        }
    }
}