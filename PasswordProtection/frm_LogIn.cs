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

        private void frm_LogIn_Load(object sender, EventArgs e)
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                var Password = mtbPassword.Text;
                string dbPassword = string.Empty;
                var TbUsername = tbUsername.Text;

                if (DbAction.IsUsernameInDatabase(TbUsername))
                {
                    dbPassword = DbAction.GetPasswordByUser(TbUsername);
                }
                else
                {
                    var SrvrSidePass = ServerAction.GetServerSidePass(TbUsername, mtbPassword.Text);
                    if (SrvrSidePass != string.Empty)
                    {
                        try
                        {
                            if (DbAction.AddNewUser(TbUsername, SrvrSidePass))
                                throw new DatabaseConnectionFailure("Error inserting data into Database!");
                        }
                        catch (DatabaseConnectionFailure error)
                        {
                            MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Hide();
            frm_Register frm_Register = new frm_Register();
            frm_Register.ShowDialog();
            Show();
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            ServerAction.SendPasswordRequest(tbUsername.Text);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
