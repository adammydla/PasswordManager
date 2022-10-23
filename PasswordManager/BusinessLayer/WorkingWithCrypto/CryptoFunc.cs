using System.Security.Cryptography;
using System.Text;


namespace BusinessLayer.WorkingWithCrypto
{
    internal static class CryptoFunc
    {
        public static Task<byte[]> BytesToSha512Hash(byte[] toBeHashed) => Task.Run(() =>
        {
            using var shaManager = SHA512.Create();
            return shaManager.ComputeHash(toBeHashed);
        });


        public static Task<string> StringToHashBase64(string toBeHashed) => Task.Run(() =>
        {
            var hashedBytes = BytesToSha512Hash(Encoding.UTF8.GetBytes(toBeHashed)).Result;
            return Convert.ToBase64String(hashedBytes);
        });
    }
}