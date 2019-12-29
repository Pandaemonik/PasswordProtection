namespace PasswordProtection
{
    partial class frm_Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Register));
            this.cbPasswordVisible = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cbBackUpPassword = new System.Windows.Forms.CheckBox();
            this.btnSuggest = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblInvalidEmail = new System.Windows.Forms.Label();
            this.lblInvalidPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbPasswordVisible
            // 
            this.cbPasswordVisible.AutoSize = true;
            this.cbPasswordVisible.Checked = true;
            this.cbPasswordVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPasswordVisible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPasswordVisible.Location = new System.Drawing.Point(38, 117);
            this.cbPasswordVisible.Name = "cbPasswordVisible";
            this.cbPasswordVisible.Size = new System.Drawing.Size(99, 17);
            this.cbPasswordVisible.TabIndex = 0;
            this.cbPasswordVisible.Text = "Show Password";
            this.cbPasswordVisible.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(35, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(279, 20);
            this.textBox2.TabIndex = 2;
            // 
            // cbBackUpPassword
            // 
            this.cbBackUpPassword.AutoSize = true;
            this.cbBackUpPassword.Checked = true;
            this.cbBackUpPassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBackUpPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBackUpPassword.Location = new System.Drawing.Point(234, 46);
            this.cbBackUpPassword.Name = "cbBackUpPassword";
            this.cbBackUpPassword.Size = new System.Drawing.Size(143, 17);
            this.cbBackUpPassword.TabIndex = 3;
            this.cbBackUpPassword.Text = "Send Password to Server";
            this.cbBackUpPassword.UseVisualStyleBackColor = true;
            // 
            // btnSuggest
            // 
            this.btnSuggest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuggest.Location = new System.Drawing.Point(320, 89);
            this.btnSuggest.Name = "btnSuggest";
            this.btnSuggest.Size = new System.Drawing.Size(75, 23);
            this.btnSuggest.TabIndex = 4;
            this.btnSuggest.Text = "Suggest";
            this.btnSuggest.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(116, 171);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Register";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(239, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(35, 30);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(35, 75);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password:";
            // 
            // lblInvalidEmail
            // 
            this.lblInvalidEmail.AutoSize = true;
            this.lblInvalidEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInvalidEmail.Location = new System.Drawing.Point(113, 30);
            this.lblInvalidEmail.Name = "lblInvalidEmail";
            this.lblInvalidEmail.Size = new System.Drawing.Size(95, 13);
            this.lblInvalidEmail.TabIndex = 9;
            this.lblInvalidEmail.Text = "Invalid Email Label";
            this.lblInvalidEmail.Visible = false;
            // 
            // lblInvalidPassword
            // 
            this.lblInvalidPassword.AutoSize = true;
            this.lblInvalidPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInvalidPassword.Location = new System.Drawing.Point(113, 75);
            this.lblInvalidPassword.Name = "lblInvalidPassword";
            this.lblInvalidPassword.Size = new System.Drawing.Size(116, 13);
            this.lblInvalidPassword.TabIndex = 10;
            this.lblInvalidPassword.Text = "Invalid Password Label";
            // 
            // frm_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 219);
            this.Controls.Add(this.lblInvalidPassword);
            this.Controls.Add(this.lblInvalidEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSuggest);
            this.Controls.Add(this.cbBackUpPassword);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbPasswordVisible);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Register";
            this.Text = "Register User";
            this.Load += new System.EventHandler(this.frm_Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbPasswordVisible;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox cbBackUpPassword;
        private System.Windows.Forms.Button btnSuggest;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblInvalidEmail;
        private System.Windows.Forms.Label lblInvalidPassword;
    }
}