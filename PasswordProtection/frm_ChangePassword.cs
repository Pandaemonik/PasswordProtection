using System;
using System.Windows.Forms;
using PasswordProtection.Internals;
using PasswordProtection.Externals;


namespace PasswordProtection
{
    public partial class frm_ChangePassword : Form
    {
        public Credentials credentials { get; }

        public frm_ChangePassword()
        {
            InitializeComponent();
        }

        public frm_ChangePassword(Credentials credentials)
        {
            InitializeComponent();
            this.credentials = new Credentials(credentials);
        }

        private void btnSuggest_Click(object sender, EventArgs e)
        {
            tbNewPassword.Text = FileIo.generateSuggestion();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbNewPassword.Text == tbNewPassword2.Text)
            {
                try
                {
                    if (Crypto.CompareHash(tbOldPassword.Text, DbAction.GetPasswordByUser(credentials.email)))
                    {
                        var serverSidePass = cbBackUpPassword.Checked ? tbNewPassword2.Text : string.Empty;
                        var hushPuppy = Crypto.MakeHash(tbNewPassword2.Text);

                        ServerAction.ChangePassword(credentials.email, tbOldPassword.Text, serverSidePass);
                        DbAction.ChangePassword(credentials.email, hushPuppy);
                        credentials.password = hushPuppy;
                        Close();
                    }
                    else
                        throw new Internals.UnauthorizedAccessException("Wrong Username/Password");
                }
                catch (Exception ex)
                {
                    lblError.Text = ex.Message;
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Passwords don't match";
                lblError.Visible = true;
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //Enables or disables the password mask 
            if (cbShowPassword.Checked)
            {
                tbOldPassword.PasswordChar = '\0';
                tbNewPassword.PasswordChar = '\0';
                tbNewPassword2.PasswordChar = '\0';
            }
            else
            {
                tbOldPassword.PasswordChar = '*';
                tbNewPassword.PasswordChar = '*';
                tbNewPassword2.PasswordChar = '*';

            }
        }

        private void tbNewPassword2_TextChanged(object sender, EventArgs e)
        {
            if (credentials.email == tbNewPassword2.Text)
            {
                lblError.Text = "Password must be different from email";
                lblError.Visible = true;
            }
            else if (!Credential.IsPasswordVaild(tbNewPassword2.Text))
            {
                lblError.Text = "Password must be longer than 12 characters";
                lblError.Visible = true;
            }
            else
            {
                lblError.Text = "Passwords don't match";
                lblError.Visible = tbNewPassword.Text != tbNewPassword2.Text ? true : false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
