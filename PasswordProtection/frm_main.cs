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
            dgAccountList.Rows.Add("test", "test");
            dgAccountList.Rows.Add("test", "test");
            credentials.Add(new Credential());
            credentials.Add(new Credential());
            //refresh dataGrid
            
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
            editCredentialAtIndex(dgAccountList.CurrentCell.RowIndex);
            //refresh dataGrid
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editCredentialAtIndex(dgAccountList.CurrentCell.RowIndex);
            //refresh dataGrid
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            deleteCredentialAtIndex(dgAccountList.CurrentCell.RowIndex);
            //refresh dataGrid
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteCredentialAtIndex(dgAccountList.CurrentCell.RowIndex);
            //refresh dataGrid
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
            //refresh dataGrid
            clearFields();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileIo.Export(credentials);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileIo.saveCredentialToFile(credentials.Encode());
            Hide();
            credentials = null;
            frm_LogIn frm_LogIn = new frm_LogIn();
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

            //refresh dataGrid
            clearFields();
        }

        void editCredentialAtIndex(int i)
        {

            //refresh dataGrid
            clearFields();
        }

        void deleteCredentialAtIndex(int i)
        {

            //refresh dataGrid
            clearFields();
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
            switch (MessageBox.Show(this, "All changes will be saved.\nAre you sure you want to quit?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    FileIo.saveCredentialToFile(credentials.Encode());
                    break;
            }
        }
    }
}
