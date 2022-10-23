using System.Text;

namespace BusinessLayer.WorkingWithUsers
{
    internal static class LogFormat
    {
        //Index(8)-Delim(8)-Username(128)-Delim(8)-VerificationLineHash(88)-End
        private const int IndexIndex = 0;
        private const int UserIndex = 1;
        private const int HashIndex = 2;

        private const int BlockPartsCount = 3;

        public static byte[] AddPadding(byte[] blockPart, int index)
        {
            byte[] partPadded = { };
            switch (index)
            {
                case IndexIndex:
                    partPadded = new byte[8 + 8];
                    Array.Copy(blockPart, partPadded, blockPart.Length);
                    break;
                case UserIndex:
                    partPadded = new byte[128 + 8];
                    Array.Copy(blockPart, partPadded, blockPart.Length);
                    break;
                case HashIndex:
                    partPadded = new byte[88 + 16];
                    Array.Copy(blockPart, partPadded, blockPart.Length);
                    break;
            }

            return partPadded;
        }

        public static LogRecord FromArrayBytesToRecord(byte[][] arrayOfbytes)
        {
            var record = new LogRecord
            {
                Index = Int32.Parse(Encoding.UTF8.GetString(arrayOfbytes[IndexIndex])),
                Username = Encoding.UTF8.GetString(arrayOfbytes[UserIndex]),
                VerificationHash = Encoding.UTF8.GetString(arrayOfbytes[HashIndex])
            };
            return record;
        }

        public static byte[][] FromRecordToArrayBytes(LogRecord record)
        {
            byte[][] arrayBytes = new byte[BlockPartsCount][];
            arrayBytes[IndexIndex] = Encoding.UTF8.GetBytes(record.Index.ToString());
            arrayBytes[UserIndex] = Encoding.UTF8.GetBytes(record.Username);
            arrayBytes[HashIndex] = Encoding.UTF8.GetBytes(record.VerificationHash);
            return arrayBytes;
        }
    }
}