using System.Text;
using BusinessLayer.WorkingWithUsers;

namespace PasswordManager
{
    public partial class SignUpForm : Form
    {
        private IUser UserObj { get; }
        private Form NextForm { get; set; }

        public SignUpForm(IUser userObj)
        {
            NextForm = null;

            InitializeComponent();
            UserObj = userObj;
        }

        private void butQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void butSignUp_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text.Length == 0)
            {
                MessageBox.Show("Your username is too short. Please, try again");
                return;
            }

            if (tbPasswd.Text.Length < Constant.MinPasswdLen)
            {
                MessageBox.Show(
                    "Your password is too short. It must contain at least 10 characters. " +
                    "Please, try again.");
                return;
            }

            if (Encoding.UTF8.GetByteCount(tbUsername.Text) > Constant.MaxUserNameLen)
            {
                MessageBox.Show("Your username is too long. Please, try again.");
                return;
            }

            var passwdObj = await UserObj.SignUp(this.tbUsername.Text, this.tbPasswd.Text);

            if (passwdObj != null)
            {
                NextForm = new ChooseActionForm(UserObj, passwdObj);
                this.Close();
                return;
            }

            MessageBox.Show("Your username is already used. Please, use another");
        }

        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
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