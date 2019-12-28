using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PasswordProtection.Internals;
using PasswordProtection.Externals;

namespace PasswordProtection
{
    public partial class frm_LogIn : Form
    {
        public frm_LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                var Password = mtbPassword.Text;
                var dbPassword = DbAction.GetPasswordByUser(tbUsername.Text);
                label1.Text = dbPassword;
                if (PassHash.Equals(Password, dbPassword))
                {
                    Hide();
                    frm_main frm_Main = new frm_main();
                    frm_Main.FormClosed += (s, args) => Close();
                    frm_Main.Show();
                }
                else
                    throw new Internals.UnauthorizedAccessException("Wrong Username/Password");
            }
            catch (Internals.UnauthorizedAccessException error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (DbAction.AddNewUser(tbUsername.Text, "5PAMfi8fgQznO4Qe2cceGo80vNfDIEu/BdFjtWWm6ZTYtAqRoOIHO4NnTlINXtpCNAA="))
                    throw new DatabaseConnectionFailure("Error inserting data into Database!");
                else
                    label1.Text = "A OK!";
            }
            catch (DatabaseConnectionFailure error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
