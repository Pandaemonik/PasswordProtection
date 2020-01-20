using System;
using System.Windows.Forms;
using PasswordProtection.Internals;
using PasswordProtection.Externals;

namespace PasswordProtection
{
    public partial class frm_main : Form
    {
        public Credentials credentials = new Credentials();

        public frm_main()
        {
            InitializeComponent();
        }
        public frm_main(string email, string password)
        {
            credentials.email = email;
            credentials.password = password;
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            credentials = FileIo.readCredentialFromEncryptedFile(credentials.email, credentials.password);
            credentials.fillInDataGrid(dgAccountList);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_About().ShowDialog();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //Enables or disables the password mask 
            if (cbShowPassword.Checked)
                tbPassword.PasswordChar = '\0';
            else
                tbPassword.PasswordChar = '*';
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            addCredential();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCredential();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgAccountList.CurrentCell != null)
                editCredentialAtIndex(dgAccountList.CurrentCell.RowIndex);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgAccountList.CurrentCell != null)
                editCredentialAtIndex(dgAccountList.CurrentCell.RowIndex);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgAccountList.CurrentCell != null)
                deleteCredentialAtIndex(dgAccountList.CurrentCell.RowIndex);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgAccountList.CurrentCell != null)
                deleteCredentialAtIndex(dgAccountList.CurrentCell.RowIndex);
        }

        private void dgAccountList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedCredential = credentials.getCredentialAtIndex(e.RowIndex);
            tbUsername.Text = selectedCredential.Username;
            tbPassword.Text = selectedCredential.Password;
            lblLink.Text = selectedCredential.DisplayName;
            lblLink.Links[0].LinkData = selectedCredential.Link;
            lblLink.Visible = true;
        }

        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string target = e.Link.LinkData as string;
            if (null != target)
            {
                System.Diagnostics.Process.Start(target);
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            credentials = FileIo.Import(credentials, FileIo.openFile());
            clearFields();
            dgAccountList.Rows.Clear();
            credentials.fillInDataGrid(dgAccountList);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileIo.Export(credentials);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show(this, "Would you like to save before you quit?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    {
                        FileIo.saveCredentialToEncryptedFile(credentials);
                        break;
                    }
                default:
                    break;
            }

            Hide();
            frm_LogIn frm_LogIn = new frm_LogIn();
            credentials = null;
            frm_LogIn.FormClosed += (s, args) => Close();
            frm_LogIn.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ChangePassword changePassword = new frm_ChangePassword(credentials);
            changePassword.ShowDialog();
            credentials = changePassword.credentials;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        void addCredential()
        {
            frm_EditCredential newCredentialForm = new frm_EditCredential();
            newCredentialForm.ShowDialog();
            if (newCredentialForm.DialogResult == DialogResult.Cancel)
            {
                credentials.Add(newCredentialForm.credential);
                dgAccountList.Rows.Clear();
                credentials.fillInDataGrid(dgAccountList);
                clearFields();
            }
        }

        void editCredentialAtIndex(int i)
        {
            frm_EditCredential editCredentialForm = new frm_EditCredential(credentials.getCredentialAtIndex(i)); // Assumes that dgAccountList and Credentials list are identical
            editCredentialForm.ShowDialog(); // get window and its thing
            if (editCredentialForm.DialogResult != DialogResult.Cancel)
            {
                credentials.editCredentialAtIndex(editCredentialForm.credential, i); // Set changes in the local DB
                                                                                     // Code above is probably redundant with addCredential(int i)
                dgAccountList.Rows.Clear();
                credentials.fillInDataGrid(dgAccountList);

                clearFields();
            }
        }

        void deleteCredentialAtIndex(int i)
        {
            switch (MessageBox.Show(this, "Are you sure you would like to delete this entry?", "DELETION", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    {
                        credentials.removeCredentialAtIndex(i);
                        dgAccountList.Rows.RemoveAt(i);
                        clearFields();
                        break;
                    }
                default:
                    break;
            }

        }

        void clearFields()
        {
            tbUsername.Text = string.Empty;
            tbPassword.Text = string.Empty;
            lblLink.Visible = false;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close

            switch (MessageBox.Show(this, "Would you like to save before you quit?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    FileIo.saveCredentialToEncryptedFile(credentials);
                    break;
                default:
                    break;
            }
        }
    }
}
