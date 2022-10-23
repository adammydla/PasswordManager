using System.Runtime.CompilerServices;
using BusinessLayer.WorkingWithCrypto;


[assembly: InternalsVisibleToAttribute("BLUnitTest")]

namespace BusinessLayer.WorkingWithFiles
{
    /*
     * Special block file format, that is padded and divided by binary zeros.
     *
     * First line -> special verification line mainly used for key verification.
     * Other lines -> block of specified bytes with specified count of parts in one block
     *              parts must be separated with at least one binary zero
     */
    internal class FileHandler : IFile
    {
        public byte[] VerificationLine { get; private set; }
        public List<byte[][]> BlockPartsList { get; private set; }

        private CryptographyHandler CryptoHandler { get; }
        private FileStream OpenedFile { get; }
        private string FilePath { get; }
        private int BlockSize { get; }
        private int BlockPartCount { get; }
        private FormatTypes Format { get; }

        public FileHandler(CryptographyHandler handler, int blockSize, int blockPartCount, string
            filePath, FormatTypes format, byte[] verificationLine)
        {
            BlockSize = blockSize;
            BlockPartCount = blockPartCount;
            FilePath = filePath;
            Format = format;
            BlockPartsList = new List<byte[][]>();

            CryptoHandler = handler;
            if (verificationLine == null)
            {
                OpenedFile = File.Open(FilePath, FileMode.Open, FileAccess.ReadWrite);
                LoadBlocks(1, 0, true).Wait();
            }
            else
            {
                OpenedFile = File.Open(FilePath, FileMode.Create, FileAccess.ReadWrite);
                VerificationLine = verificationLine.ToArray();
                WriteFile().Wait();
            }
        }

        public void DisposeOfObjects()
        {
            CryptoHandler.DisposeOfObjects();
            OpenedFile.Dispose();
        }

        /*
         * Block reading from file, that starts at "offset" and reads exactly "blockCount" blocks
         * Special call: "blockCount" == 0 -> read whole file rest of file
         * 
         * (block read not implemented for now, blockCount must be 0 on call)
         */
        private Task LoadBlocks(int blockCount, int offset, bool isVerificationLine)
            => Task.Run(() =>
            {
                if (isVerificationLine && (blockCount != 1 || offset != 0))
                {
                    throw new Exception();
                }

                byte[] blocksEncryptedArray;
                if (isVerificationLine)
                {
                    blocksEncryptedArray = new byte[BlockSize];
                    OpenedFile.Position = offset;
                    OpenedFile.Read(blocksEncryptedArray, 0, BlockSize);
                    var paddedBlocks = CryptoHandler.Decrypt(blocksEncryptedArray).Result;

                    VerificationLine = paddedBlocks.ToArray();
                }
                else
                {
                    using var blocksEncrypted = new MemoryStream();
                    OpenedFile.Position = offset;
                    OpenedFile.CopyTo(blocksEncrypted, 512);

                    blocksEncryptedArray = blocksEncrypted.ToArray();
                    var paddedBlocks = CryptoHandler.Decrypt(blocksEncryptedArray).Result;

                    BlockPartsList = ZeroPaddedFileType.FromFormat(paddedBlocks, BlockSize,
                        BlockPartCount).Result;
                }
            });

        /*
         * Block writing to file, that starts at "offset" and writes exactly "blockCount" blocks
         * Special call: "blockCount" == 0 -> write BlockPartsList
         * 
         * (block write not implemented for now, blockCount must be 0 on call)
         */
        private Task WriteBlocks(int blockCount, int offset, bool isVerificationLine)
            => Task.Run(() =>
            {
                if (isVerificationLine && (blockCount != 1 || offset != 0))
                {
                    throw new Exception();
                }

                byte[] blocksPadded;
                if (isVerificationLine)
                {
                    blocksPadded = VerificationLine.ToArray();
                }
                else
                {
                    blockCount = blockCount == 0 ? BlockPartsList.Count : blockCount;
                    blocksPadded = ZeroPaddedFileType.ToFormat(
                            BlockPartsList.Skip(offset / BlockSize - 1)
                                .Take(blockCount)
                                .ToList(), BlockSize, Format)
                        .Result;
                }


                var blocksEncrypted = CryptoHandler.Encrypt(blocksPadded).Result;

                OpenedFile.Position = offset;
                OpenedFile.Write(blocksEncrypted, 0, blocksEncrypted.Length);
            });

        public Task WriteFile() => Task.Run(() =>
        {
            OpenedFile.SetLength(0);
            WriteBlocks(1, 0, true).Wait();
            WriteBlocks(0, BlockSize, false).Wait();
            OpenedFile.Flush();
        });

        public async Task AcceptFile()
        {
            await LoadBlocks(0, BlockSize, false);
        }

        public async Task ReReadFile()
        {
            await LoadBlocks(1, 0, true);
            await LoadBlocks(0, BlockSize, false);
        }

        public bool UpdateBlock(int index, byte[][] blockParts)
        {
            if (index > BlockPartsList.Count)
            {
                return false;
            }

            BlockPartsList[index] = blockParts;
            return true;
        }

        public bool AppendBlock(byte[][] blockParts)
        {
            BlockPartsList.Add(blockParts);
            return true;
        }

        public bool DeleteBlock(int index)
        {
            if (index > BlockPartsList.Count)
            {
                return false;
            }

            BlockPartsList.RemoveAt(index);
            return true;
        }
    }
}