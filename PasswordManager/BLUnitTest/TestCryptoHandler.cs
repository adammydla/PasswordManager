using System;
using System.Security.Cryptography;
using System.Text;
using NUnit.Framework;
using BusinessLayer.WorkingWithCrypto;

namespace BLUnitTest
{
    public class TestCryptoHandler
    {
        private CryptographyHandler Handler { get; set; }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Errors()
        {
            Handler = new CryptographyHandler();

            var exception = Assert.ThrowsAsync<NullReferenceException>(
                () => Handler.Encrypt(new byte[1]));
            Assert.That(exception.Message, Is.EqualTo("AES key not created."));

            var exception1 = Assert.ThrowsAsync<NullReferenceException>(
                () => Handler.Decrypt(new byte[1]));
            Assert.That(exception1.Message, Is.EqualTo("AES key not created."));

            Assert.Throws<CryptographicException>(
                () => Handler.SetUpKey("123456789", RandomNumberGenerator.GetBytes(17)));
            Assert.Throws<CryptographicException>(
                () => Handler.SetUpKey("123456789", RandomNumberGenerator.GetBytes(15)));
        }

        [Test]
        public void Encrypt()
        {
            Handler = new CryptographyHandler();

            Handler.SetUpKey("123456789", RandomNumberGenerator.GetBytes(16));
            var content = RandomNumberGenerator.GetBytes(1024);

            var first = Handler.Encrypt(content).Result;
            var second = Handler.Encrypt(content).Result;
            Assert.AreEqual(first, second);

            var contentSecond = RandomNumberGenerator.GetBytes(1024);
            var third = Handler.Encrypt(contentSecond).Result;
            Assert.AreNotEqual(first, third);

            var contentThird = RandomNumberGenerator.GetBytes(1024);
            var fourth = Handler.Encrypt(contentThird).Result;
            Handler.SetUpKey("987654321", RandomNumberGenerator.GetBytes(16));
            var fifth = Handler.Encrypt(contentThird).Result;
            Assert.AreNotEqual(fourth, fifth);
        }

        [Test]
        public void Decrypt()
        {
            Handler = new CryptographyHandler();

            Handler.SetUpKey("123456789", RandomNumberGenerator.GetBytes(16));
            var content = RandomNumberGenerator.GetBytes(1024);

            var first = Handler.Decrypt(content).Result;
            var second = Handler.Decrypt(content).Result;
            Assert.AreEqual(first, second);

            var contentSecond = RandomNumberGenerator.GetBytes(1024);
            var third = Handler.Decrypt(contentSecond).Result;
            Assert.AreNotEqual(first, third);


            var contentThird = RandomNumberGenerator.GetBytes(1024);
            var fourth = Handler.Decrypt(contentThird).Result;
            Handler.SetUpKey("987654321", RandomNumberGenerator.GetBytes(16));
            var fifth = Handler.Decrypt(contentThird).Result;
            Assert.AreNotEqual(fourth, fifth);
        }

        [Test]
        public void RandomKeys()
        {
            Handler = new CryptographyHandler();

            Handler.SetUpKey("", RandomNumberGenerator.GetBytes(16));
            Handler.SetUpKey("1", RandomNumberGenerator.GetBytes(16));

            var bytes = RandomNumberGenerator.GetBytes(1024);
            Handler.SetUpKey(Encoding.UTF8.GetString(bytes), RandomNumberGenerator.GetBytes(16));

            bytes = RandomNumberGenerator.GetBytes(4096);
            Handler.SetUpKey(Encoding.UTF8.GetString(bytes), RandomNumberGenerator.GetBytes(16));
        }

        [Test]
        public void EncryptAndDecrypt()
        {
            Handler = new CryptographyHandler();

            Handler.SetUpKey("123456789", RandomNumberGenerator.GetBytes(16));
            var content = RandomNumberGenerator.GetBytes(1048576);

            var encrypted = Handler.Encrypt(content).Result;
            var decrypted = Handler.Decrypt(encrypted).Result;

            Assert.AreNotEqual(decrypted, encrypted);
            Assert.AreEqual(content, decrypted);

            encrypted[543] += 1;
            var decryptedSecond = Handler.Decrypt(encrypted).Result;
            Assert.AreNotEqual(content, decryptedSecond);
        }
    }
}