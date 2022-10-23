namespace BusinessLayer.WorkingWithPasswds
{
    public interface IPassword
    {
        public Task<bool> CheckAndLoadFile(string verificationHash);

        public Task<RetVal> ChangeAccountPasswd(string username,
            string oldPasswd, string newPasswd);

        public Task<bool> LoadPasswd(string alias, string username, string passwd);

        public Dictionary<string, int> ShowPasswds();
        public Task<Dictionary<string, int>> FilterAndShowPasswds(string alias, string username);

        public Task<List<string>> SortAliases(Dictionary<string, int> aliasIndices, string
            sortType);

        public PasswdRecord GetPasswd(int index);

        public Task DeletePasswd(int index);

        public Task<string> GeneratePasswd();

        public void CloseHandler();

        public void CloseHandlerNoDispose();
    }
}