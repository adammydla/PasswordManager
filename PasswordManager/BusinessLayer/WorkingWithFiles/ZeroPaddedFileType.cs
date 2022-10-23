using BusinessLayer.WorkingWithPasswds;
using BusinessLayer.WorkingWithUsers;

namespace BusinessLayer.WorkingWithFiles
{
    /*
     *  Special format:
     *      First block -> special value
     *
     *  If deleting record -> everything is zeros
     */

    internal static class ZeroPaddedFileType
    {
        private static Task ParseLine(byte[][] blockParts, byte[] block, int offset,
            int blockSize) => Task.Run(() =>
        {
            List<byte> part = new List<byte>();
            bool reading = true;
            int partIndex = 0;
            for (int i = offset; i < offset + blockSize; i++)
            {
                if (block[i] != 0)
                {
                    part.Add(block[i]);
                    reading = true;
                    continue;
                }

                if (!reading)
                {
                    continue;
                }

                blockParts[partIndex] = part.ToArray();
                partIndex++;
                part.Clear();
                reading = false;
            }
        });

        public static async Task<List<byte[][]>> FromFormat(byte[] content, int
            blockSize, int blockPartCount)
        {
            List<byte[][]> parsedFile = new List<byte[][]>();

            int index = 0;
            List<Task> activeParsers = new List<Task>();
            while (index < content.Length)
            {
                byte[][] blockParts = new byte[blockPartCount][];
                parsedFile.Add(blockParts);
                activeParsers.Add(ParseLine(blockParts, content, index, blockSize));
                index += blockSize;
            }

            await Task.WhenAll(activeParsers);
            return parsedFile;
        }

        private static Task CreateLine(byte[] paddedFile, int offset, byte[][] blockParts,
            FormatTypes format, Mutex mutex) => Task.Run(() =>
        {
            List<byte> blockBytes = new List<byte>();
            int partIndex = 0;
            foreach (var part in blockParts)
            {
                switch (format)
                {
                    case FormatTypes.PasswdFormat:
                        blockBytes.AddRange(PasswdFormat.AddPadding(part, partIndex));
                        break;
                    case FormatTypes.LogFormat:
                        blockBytes.AddRange(LogFormat.AddPadding(part, partIndex));
                        break;
                }

                partIndex++;
            }

            mutex.WaitOne();
            blockBytes.ToArray().CopyTo(paddedFile, offset);
            mutex.ReleaseMutex();
            blockBytes.Clear();
        });

        public static async Task<byte[]> ToFormat(List<byte[][]> blockPartsList,
            int blockSize, FormatTypes format)
        {
            Mutex mutex = new Mutex();
            var paddedFile = new byte[blockPartsList.Count * blockSize];

            List<Task> activeParsers = new List<Task>();
            int offset = 0;
            foreach (var oneBlockParts in blockPartsList)
            {
                activeParsers.Add(CreateLine(paddedFile, offset, oneBlockParts,
                    format, mutex));
                offset += blockSize;
            }

            await Task.WhenAll(activeParsers);
            return paddedFile;
        }
    }
}