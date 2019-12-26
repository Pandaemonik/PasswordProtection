using System;
using System.Windows.Forms;

namespace PasswordProtection
{
    public partial class frm_LogIn : Form
    {
        public frm_LogIn()
        {
            InitializeComponent();
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            Hide();
            frm_main frm_Main = new frm_main();
            frm_Main.FormClosed += (s, args) => Close();
            frm_Main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {

        }
    }
}
