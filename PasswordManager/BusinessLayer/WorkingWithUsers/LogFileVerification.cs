using System.Text;

namespace BusinessLayer.WorkingWithUsers
{
    internal static class LogFileVerification
    {
        public static readonly byte[] VerificationLine = Encoding.UTF8.GetBytes(
            "ZwfaPCkuViQ8uujkQsXW6WudBjwSPtFvmkz16JLGPEgUWWbmOWYAUkSTmoG7TRNZfbNrVEGoCDZiIcgPVVG4" +
            "yHqGSScacjqPecZPcTjuLkpy1wJnam0Ph8XzJms6OHeSzGNMMZfGOzGWRMPsgskQMtwZt5F66XnPwb5XByW5" +
            "EUF5H2q6NpkSkneNcU3HzlRviWK1c0QLqGwb8vOGpRQkZF87jxW8PR8ITNaYyCNXlcJgGNcMDp17g8lP6xWB" +
            "cRzx");

        public static readonly byte[] LogFileIv = new byte[16];
    }
}