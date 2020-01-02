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
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbBackUpPassword = new System.Windows.Forms.CheckBox();
            this.btnSuggest = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblInvalidEmail = new System.Windows.Forms.Label();
            this.lblInvalidPassword = new System.Windows.Forms.Label();
            this.lblInvalidRegistration = new System.Windows.Forms.Label();
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
            this.cbPasswordVisible.CheckedChanged += new System.EventHandler(this.cbPasswordVisible_CheckedChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(35, 46);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(190, 20);
            this.tbEmail.TabIndex = 1;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(35, 91);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(279, 20);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
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
            this.btnSuggest.Click += new System.EventHandler(this.btnSuggest_Click);
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(239, 171);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.lblInvalidEmail.Size = new System.Drawing.Size(66, 13);
            this.lblInvalidEmail.TabIndex = 9;
            this.lblInvalidEmail.Text = "Invalid Email";
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
            this.lblInvalidPassword.Visible = false;
            // 
            // lblInvalidRegistration
            // 
            this.lblInvalidRegistration.AutoSize = true;
            this.lblInvalidRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInvalidRegistration.Location = new System.Drawing.Point(153, 143);
            this.lblInvalidRegistration.Name = "lblInvalidRegistration";
            this.lblInvalidRegistration.Size = new System.Drawing.Size(97, 13);
            this.lblInvalidRegistration.TabIndex = 11;
            this.lblInvalidRegistration.Text = "Invalid Registration";
            this.lblInvalidRegistration.Visible = false;
            // 
            // frm_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 219);
            this.Controls.Add(this.lblInvalidRegistration);
            this.Controls.Add(this.lblInvalidPassword);
            this.Controls.Add(this.lblInvalidEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSuggest);
            this.Controls.Add(this.cbBackUpPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
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
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.CheckBox cbBackUpPassword;
        private System.Windows.Forms.Button btnSuggest;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblInvalidEmail;
        private System.Windows.Forms.Label lblInvalidPassword;
        private System.Windows.Forms.Label lblInvalidRegistration;
    }
}