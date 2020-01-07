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

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void dgAccountList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            credentials = FileIo.Import(credentials, FileIo.openFile());
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileIo.Export(credentials);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
