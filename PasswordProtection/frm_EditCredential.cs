using System;
using System.Windows.Forms;
using PasswordProtection.Internals;
using PasswordProtection.Externals;

namespace PasswordProtection
{
    public partial class frm_EditCredential : Form
    {
        public Credential credential;

        public frm_EditCredential()
        {
            InitializeComponent();
        }
        public frm_EditCredential(Credential credential)
        {
            InitializeComponent();
            this.credential = credential;
        }

        private void frm_EditCredential_Load(object sender, EventArgs e)
        {
            if (credential == null) credential = new Credential();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
                tbPassword.PasswordChar = '\0';
            else
                tbPassword.PasswordChar = '*';
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbWebsite.Text != string.Empty && tbAdress.Text != string.Empty)
            {
                credential.DisplayName = tbWebsite.Text;
                credential.Link = tbAdress.Text;
                credential.Username = tbUsername.Text;
                credential.Password = tbPassword.Text;
            }
            else
                lblError.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSuggest_Click(object sender, EventArgs e)
        {
            tbPassword.Text = FileIo.generateSuggestion();
        }
    }
}
