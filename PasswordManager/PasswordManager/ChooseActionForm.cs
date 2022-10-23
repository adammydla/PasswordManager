using BusinessLayer.WorkingWithPasswds;
using BusinessLayer.WorkingWithUsers;

namespace PasswordManager
{
    public partial class ChooseActionForm : Form
    {
        private IUser UserObj { get; }
        private IPassword PasswdObj { get; }
        private Form NextForm { get; set; }

        public ChooseActionForm(IUser user, IPassword passwd)
        {
            UserObj = user;
            PasswdObj = passwd;
            NextForm = null;
            InitializeComponent();
            cbActions.DataSource = Constant.Actions;
        }

        private void butQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butChoose_Click(object sender, EventArgs e)
        {
            switch ((string) this.cbActions.SelectedItem)
            {
                case "Change Account Password":
                    NextForm = new ChangeAccPasswdForm(UserObj, PasswdObj);
                    break;
                case "Add Password":
                    NextForm = new LoadPasswdForm(UserObj, PasswdObj);
                    break;
                case "Get Password":
                    NextForm = new GetPasswdForm(UserObj, PasswdObj);
                    break;
                case "Delete Password":
                    NextForm = new DeletePasswdForm(UserObj, PasswdObj);
                    break;
            }

            this.Close();
        }

        private void ChooseActionForm_FormClosing(object sender, FormClosingEventArgs e)
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