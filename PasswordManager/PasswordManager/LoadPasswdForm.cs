using System.Text;
using BusinessLayer.WorkingWithPasswds;
using BusinessLayer.WorkingWithUsers;

namespace PasswordManager
{
    public partial class LoadPasswdForm : Form
    {
        private IUser UserObj { get; }
        private IPassword PasswdObj { get; }
        private Form NextForm { get; set; }

        public LoadPasswdForm(IUser user, IPassword passwd)
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

        private async void butGenerate_Click(object sender, EventArgs e)
        {
            string passwd = await PasswdObj.GeneratePasswd();
            MessageBox.Show($"Your generated password:\n{passwd}");
            tbPasswd.Text = passwd;
        }

        private async void butLoad_Click(object sender, EventArgs e)
        {
            if (tbAlias.Text.Length == 0)
            {
                MessageBox.Show("Account alias is too short. Please, try again.");
                return;
            }

            if (tbUsername.Text.Length == 0)
            {
                MessageBox.Show("Account username is too short. Please, try again.");
                return;
            }

            if (tbPasswd.Text.Length == 0)
            {
                MessageBox.Show("Account password is too short. Please, try again.");
                return;
            }

            if (Encoding.UTF8.GetByteCount(tbAlias.Text) > Constant.MaxAliasLen)
            {
                MessageBox.Show("Account alias is too long. Please, try again.");
                return;
            }

            if (Encoding.UTF8.GetByteCount(tbUsername.Text) > Constant.MaxUserNameLen)
            {
                MessageBox.Show("Account username is too long. Please, try again.");
                return;
            }

            if (Encoding.UTF8.GetByteCount(tbPasswd.Text) > Constant.MaxPasswdLen)
            {
                MessageBox.Show("Account password is too long. Please, try again.");
                return;
            }

            bool returnVal = await PasswdObj.LoadPasswd(this.tbAlias.Text, this.tbUsername.Text,
                this
                    .tbPasswd.Text);
            if (returnVal)
            {
                MessageBox.Show(
                    "You have successfully added new password to your password database");
                this.tbAlias.Text = "";
                this.tbUsername.Text = "";
                this.tbPasswd.Text = "";
                return;
            }

            MessageBox.Show("Alias is already used. Please, use another one.");
        }

        private void LoadPasswdForm_FormClosing(object sender, FormClosingEventArgs e)
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