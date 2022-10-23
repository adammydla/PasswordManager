namespace PasswordManager
{
    internal static class Constant
    {
        public const int MinPasswdLen = 10;
        
        public const int MaxUserNameLen = 128;
        public const int MaxPasswdLen = 256;
        public const int MaxAliasLen = 80;
        
        
        public static readonly string[] Actions =
        {
            "Change Account Password", "Add Password", "Get Password", "Delete Password"
        };

        public static readonly string[] SortTypes =
        {
            "Default order", "Ascending sort", "Descending sort"
        };
    }
}