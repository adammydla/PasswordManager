using System.Text;
using BusinessLayer.WorkingWithUsers;

namespace PasswordManager
{
    public partial class WelcomePageForm : Form
    {
        private IUser UserObj { get; set; }
        private Form NextForm { get; set; }

        public WelcomePageForm()
        {
            NextForm = null;

            InitializeComponent();
            Task.Run(() => { UserObj = new UserManager(); }).Wait();
        }

        private async void Login_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text.Length == 0)
            {
                MessageBox.Show("You forgot to type your username. Please, try again");
                return;
            }

            if (tbPassword.Text.Length == 0)
            {
                MessageBox.Show("You forgot to type your password. Please, try again");
                return;
            }

            if (Encoding.UTF8.GetByteCount(tbUsername.Text) > Constant.MaxUserNameLen)
            {
                MessageBox.Show("Your username is too long. Please, try again.");
                return;
            }

            var passwdObj = await UserObj.SignIn(this.tbUsername.Text, this.tbPassword.Text);

            if (passwdObj != null)
            {
                NextForm = new ChooseActionForm(UserObj, passwdObj);
                this.Close();
                return;
            }

            MessageBox.Show("Your login details are not correct. Please, try again.");
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            NextForm = new SignUpForm(UserObj);
            this.Close();
        }

        private void WelcomePageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NextForm == null)
            {
                UserObj.CloseHandlerNoDispose();
                Application.Exit();
                return;
            }

            NextForm.Location = this.Location;
            NextForm.Size = this.Size;
            NextForm.StartPosition = FormStartPosition.Manual;
            NextForm.Show();
        }
    }
}