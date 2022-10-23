namespace BusinessLayer.WorkingWithUsers
{
    internal record LogRecord
    {
        public int Index;
        public string Username;
        public string VerificationHash;
    }
}