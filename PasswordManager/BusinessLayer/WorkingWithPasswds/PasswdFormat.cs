using System.Text;

namespace BusinessLayer.WorkingWithPasswds
{
    internal static class PasswdFormat
    {
        //Size + delim
        private const int IndexSize = 8 + 8;
        private const int AliasSize = 80 + 8;
        private const int UserSize= 128 + 8;
        private const int PasswdSize = 256 + 16;

        private const int IndexIndex = 0;
        private const int AliasIndex = 1;
        private const int UserIndex = 2;
        private const int PasswdIndex = 3;

        private const int BlockPartsCount = 4;

        public static byte[] AddPadding(byte[] blockPart, int index)
        {
            byte[] partPadded = { };
            switch (index)
            {
                case IndexIndex:
                    partPadded = new byte[IndexSize];
                    Array.Copy(blockPart, partPadded, blockPart.Length);
                    break;
                case AliasIndex:
                    partPadded = new byte[AliasSize];
                    Array.Copy(blockPart, partPadded, blockPart.Length);
                    break;
                case UserIndex:
                    partPadded = new byte[UserSize];
                    Array.Copy(blockPart, partPadded, blockPart.Length);
                    break;
                case PasswdIndex:
                    partPadded = new byte[PasswdSize];
                    Array.Copy(blockPart, partPadded, blockPart.Length);
                    break;
            }

            return partPadded;
        }

        public static PasswdRecord FromArrayBytesToRecord(byte[][] arrayOfbytes)
        {
            var record = new PasswdRecord
            {
                Index = Int32.Parse(Encoding.UTF8.GetString(arrayOfbytes[IndexIndex])),
                Alias = Encoding.UTF8.GetString(arrayOfbytes[AliasIndex]),
                Username = Encoding.UTF8.GetString(arrayOfbytes[UserIndex]),
                Password = Encoding.UTF8.GetString(arrayOfbytes[PasswdIndex])
            };

            return record;
        }

        public static byte[][] FromRecordToArrayBytes(PasswdRecord record)
        {
            byte[][] arrayBytes = new byte[BlockPartsCount][];
            arrayBytes[IndexIndex] = Encoding.UTF8.GetBytes(record.Index.ToString());
            arrayBytes[AliasIndex] = Encoding.UTF8.GetBytes(record.Alias);
            arrayBytes[UserIndex] = Encoding.UTF8.GetBytes(record.Username);
            arrayBytes[PasswdIndex] = Encoding.UTF8.GetBytes(record.Password);
            return arrayBytes;
        }
    }
}