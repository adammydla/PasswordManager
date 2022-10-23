namespace BusinessLayer.WorkingWithFiles
{
    public interface IFile
    {
        public byte[] VerificationLine { get; }
        public List<byte[][]> BlockPartsList { get; }

        public Task AcceptFile();
        public Task ReReadFile();
        public Task WriteFile();
        public bool UpdateBlock(int index, byte[][] blockParts);
        public bool AppendBlock(byte[][] blockParts);
        public bool DeleteBlock(int index);

        public void DisposeOfObjects();
    }
}