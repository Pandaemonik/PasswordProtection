using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordProtection.Internals;
using PasswordProtection.Externals;
using System.IO;

namespace PasswordProtection
{
    public partial class frm_Register : Form
    {
        public frm_Register()
        {
            InitializeComponent();
        }

        private void frm_Register_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(tbEmail, "This is used for password recovery and log in.");
            toolTip1.SetToolTip(cbBackUpPassword, "Backs up the password to a server.");
        }

        private void btnSuggest_Click(object sender, EventArgs e)
        {
            tbPassword.Text = FileIo.generateSuggestion();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Credential.IsEmailValid(tbEmail.Text) && !DbAction.IsUsernameInDatabase(tbEmail.Text) && !ServerAction.IsUsernameInServer(tbEmail.Text))
            {
                try
                {
                    var serverSidePass = cbBackUpPassword.Checked ? tbPassword.Text : string.Empty;
                    if (ServerAction.RegisterNewUser(tbEmail.Text, serverSidePass))
                    {

                        try
                        {
                            if (!DbAction.AddNewUser(tbEmail.Text, Crypto.MakeHash(tbPassword.Text)))
                                throw new DatabaseConnectionFailure("Error inserting data into Database!");
                            Close();
                        }
                        catch (DatabaseConnectionFailure error)
                        {
                            MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        lblInvalidRegistration.Text = "Could not Register user. Please try again";
                        lblInvalidRegistration.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    lblInvalidRegistration.Text = ex.Message;
                }

            }
            else
                lblInvalidRegistration.Visible = true;
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            lblInvalidEmail.Visible = !Credential.IsEmailValid(tbEmail.Text) ? true : false;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbEmail.Text == tbPassword.Text)
            {
                lblInvalidPassword.Text = "Password must be different from email";
                lblInvalidPassword.Visible = true;
            }
            else
            {
                lblInvalidPassword.Text = "Password must be longer than 12 characters";
                lblInvalidPassword.Visible = !Credential.IsPasswordVaild(tbPassword.Text) ? true : false;
            }
        }

        private void cbPasswordVisible_CheckedChanged(object sender, EventArgs e)
        {
            //Enables or disables the password mask 
            if (cbPasswordVisible.Checked)
                tbPassword.PasswordChar = '\0';
            else
                tbPassword.PasswordChar = '*';
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
