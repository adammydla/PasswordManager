using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;


[assembly: InternalsVisibleTo("BLUnitTest")]

namespace BusinessLayer.WorkingWithCrypto
{
    internal class CryptographyHandler
    {
        private Aes AesKey { get; set; }

        public CryptographyHandler()
        {
            AesKey = null;
        }

        public void DisposeOfObjects()
        {
            AesKey?.Dispose();
        }

        public void SetUpKey(string toBeKey, byte[] iv)
        {
            byte[] bytesToKey = Encoding.UTF8.GetBytes(toBeKey);
            Aes aesKey = Aes.Create();
            using var shaManager = SHA256.Create();
            var hashedKey = shaManager.ComputeHash(bytesToKey);

            aesKey.Mode = CipherMode.CBC;
            aesKey.Padding = PaddingMode.Zeros;
            aesKey.Key = hashedKey;
            aesKey.IV = iv;
            AesKey = aesKey;
        }

        public Task<bool> CompareKeys(string textToKey) => Task.Run(() =>
        {
            byte[] bytesToKey = Encoding.UTF8.GetBytes(textToKey);
            using var shaManager = SHA256.Create();
            var hashedKey = shaManager.ComputeHash(bytesToKey);

            return hashedKey.SequenceEqual(AesKey.Key);
        });

        public Task<byte[]> Encrypt(byte[] content) => Task.Run(() =>
        {
            if (AesKey == null)
            {
                throw new NullReferenceException("AES key not created.");
            }

            using var encryptedStream = new MemoryStream();
            using (var cryptoStream = new CryptoStream(encryptedStream,
                       AesKey.CreateEncryptor(), CryptoStreamMode.Write))
            {
                cryptoStream.Write(content, 0, content.Length);
                cryptoStream.FlushFinalBlock();
            }

            return encryptedStream.ToArray();
        });

        public Task<byte[]> Decrypt(byte[] content) => Task.Run(() =>
        {
            if (AesKey == null)
            {
                throw new NullReferenceException("AES key not created.");
            }

            using var decryptedStream = new MemoryStream();
            using (var cryptoStream = new CryptoStream(decryptedStream,
                       AesKey.CreateDecryptor(), CryptoStreamMode.Write))
            {
                cryptoStream.Write(content, 0, content.Length);
                cryptoStream.FlushFinalBlock();
            }

            return decryptedStream.ToArray();
        });
    }
}