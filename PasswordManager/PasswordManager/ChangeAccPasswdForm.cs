using System.Text;
using BusinessLayer.WorkingWithPasswds;
using BusinessLayer.WorkingWithUsers;

namespace PasswordManager
{
    public partial class ChangeAccPasswdForm : Form
    {
        private IUser UserObj { get; }
        private IPassword PasswdObj { get; }
        private Form NextForm { get; set; }

        public ChangeAccPasswdForm(IUser user, IPassword passwd)
        {
            UserObj = user;
            PasswdObj = passwd;
            NextForm = null;
            InitializeComponent();
        }

        private void butQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butChangeAction_Click(object sender, EventArgs e)
        {
            NextForm = new ChooseActionForm(UserObj, PasswdObj);
            this.Close();
        }

        private async void butChangePasswd_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text.Length == 0)
            {
                MessageBox.Show("You forgot to type your username. Please, try again");
                return;
            }

            if (tbOldPasswd.Text.Length == 0)
            {
                MessageBox.Show("You forgot to type your old password. Please, try again");
                return;
            }

            if (tbNewPasswd.Text.Length < Constant.MinPasswdLen)
            {
                MessageBox.Show(
                    "Your new password is too short. It must contain at least 10 characters. " +
                    "Please, try again.");
                return;
            }

            if (Encoding.UTF8.GetByteCount(tbUsername.Text) > Constant.MaxUserNameLen ||
                tbUsername.Text != UserObj.Username)
            {
                MessageBox.Show("Your username is not correct. Please, try again.");
                return;
            }

            var result = await PasswdObj.ChangeAccountPasswd(this.tbUsername.Text,
                this.tbOldPasswd.Text, this.tbNewPasswd.Text);

            switch (result)
            {
                case RetVal.NotSameUser:
                    MessageBox.Show("Your tried to change password of another user.");
                    break;
                case RetVal.WrongPasswd:
                    MessageBox.Show("You used wrong old password.");
                    break;
                default:
                    MessageBox.Show("You have successfully changed your password.");
                    NextForm = new ChooseActionForm(UserObj, PasswdObj);
                    this.Close();
                    break;
            }
        }

        private void ChangeAccPasswdForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NextForm == null)
            {
                UserObj.CloseHandlerNoDispose();
                PasswdObj.CloseHandlerNoDispose();
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