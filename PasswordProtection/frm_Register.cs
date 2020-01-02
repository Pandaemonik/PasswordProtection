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
        string[] WordList;
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

            var Pathh = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\WordList.csv";
            using (var reader = new StreamReader(@Pathh))
            {
                var line = reader.ReadLine();
                WordList = line.Split(';');
            }
        }

        private void btnSuggest_Click(object sender, EventArgs e)
        {
            //Generates a string made form 4 random words. The dictonaty used is the "Oxford 3000" list. The number of combinations possible is 4^3262
            var Suggestion = string.Empty;
            do
            {
                Random random = new Random();
                for (int i = 0; i < 4; i++)
                    Suggestion += WordList[random.Next(0, WordList.Length - 1)] + " ";
            } while (!Credential.IsPasswordVaild(Suggestion));
            tbPassword.Text = Suggestion.Trim();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Credential.IsEmailValid(tbEmail.Text) && !DbAction.IsUsernameInDatabase(tbEmail.Text) && !ServerAction.IsUsernameInServer(tbEmail.Text))
            {
                try
                {
                    var serverSidePass = cbBackUpPassword.Checked ? tbPassword.Text : string.Empty;
                    ServerAction.RegisterNewUser(tbEmail.Text, tbPassword.Text);
                    DbAction.AddNewUser(tbEmail.Text, PassHash.MakeHash(tbPassword.Text));
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
