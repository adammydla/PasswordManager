using BusinessLayer.WorkingWithPasswds;

namespace BusinessLayer.WorkingWithUsers
{
    public interface IUser
    {
        public string Username { get; }
        public Task<IPassword> SignUp(string username, string passwd);

        public Task<IPassword> SignIn(string username, string passwd);

        public void CloseHandler();

        public void CloseHandlerNoDispose();
    }
}