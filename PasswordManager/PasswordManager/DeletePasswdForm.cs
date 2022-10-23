using System.Text;
using BusinessLayer.WorkingWithPasswds;
using BusinessLayer.WorkingWithUsers;

namespace PasswordManager
{
    public partial class DeletePasswdForm : Form
    {
        private IUser UserObj { get; }
        private IPassword PasswdObj { get; }
        private Form NextForm { get; set; }
        private Dictionary<string, int> AliasIndices { get; set; }


        public DeletePasswdForm(IUser user, IPassword passwd)
        {
            UserObj = user;
            PasswdObj = passwd;
            NextForm = null;
            InitializeComponent();

            AliasIndices = PasswdObj.ShowPasswds();
            cbPasswords.DataSource = AliasIndices.Keys.ToList();
            cbPasswords.SelectedItem = null;
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

        private void SortAfterUpdate()
        {
            if (rbSortDef.Checked)
            {
                rbSortDef_CheckedChanged(null, null);
            }
            else if (rbSortAsc.Checked)
            {
                rbSortAsc_CheckedChanged(null, null);
            }
            else
            {
                rbSortDesc_CheckedChanged(null, null);
            }
        }

        private async Task Filter()
        {
            if (Encoding.UTF8.GetByteCount(tbAlias.Text) > Constant.MaxAliasLen)
            {
                MessageBox.Show("Account alias is too long. Please, try again.");
                return;
            }

            AliasIndices = await PasswdObj.FilterAndShowPasswds(tbAlias.Text, "");
            cbPasswords.DataSource = AliasIndices.Keys.ToList();
            cbPasswords.SelectedItem = null;
            SortAfterUpdate();
        }

        private async void butFilter_Click(object sender, EventArgs e)
        {
            await Filter();
        }

        private async void butDelete_Click(object sender, EventArgs e)
        {
            if (cbPasswords.SelectedItem == null)
            {
                MessageBox.Show("Any alias chosen, aborting.");
                return;
            }

            if (!AliasIndices.TryGetValue((string) cbPasswords.SelectedItem,
                    out var indexToPasswds))
            {
                MessageBox.Show("Error occured, please try again.");
                return;
            }

            await PasswdObj.DeletePasswd(indexToPasswds);
            await Filter();
            cbPasswords.SelectedItem = null;

            MessageBox.Show($"Password with alias {(string) cbPasswords.SelectedItem} was " +
                            "successfully deleted.");
        }

        private async void rbSortDef_CheckedChanged(object sender, EventArgs e)
        {
            cbPasswords.DataSource = await PasswdObj.SortAliases(AliasIndices, "Default order");
            cbPasswords.SelectedItem = null;
        }

        private async void rbSortAsc_CheckedChanged(object sender, EventArgs e)
        {
            cbPasswords.DataSource = await PasswdObj.SortAliases(AliasIndices, "Ascending sort");
            cbPasswords.SelectedItem = null;
        }

        private async void rbSortDesc_CheckedChanged(object sender, EventArgs e)
        {
            cbPasswords.DataSource = await PasswdObj.SortAliases(AliasIndices, "Descending sort");
            cbPasswords.SelectedItem = null;
        }

        private void DeletePasswdForm_FormClosing(object sender, FormClosingEventArgs e)
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