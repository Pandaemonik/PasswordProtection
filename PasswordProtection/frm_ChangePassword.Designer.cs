namespace PasswordProtection
{
    partial class frm_ChangePassword
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.tbOldPassword = new System.Windows.Forms.TextBox();
            this.tbNewPassword2 = new System.Windows.Forms.TextBox();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.lblNewPassword2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSuggest = new System.Windows.Forms.Button();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.cbBackUpPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(234, 135);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.Checked = true;
            this.cbShowPassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShowPassword.Location = new System.Drawing.Point(340, 60);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(99, 17);
            this.cbShowPassword.TabIndex = 1;
            this.cbShowPassword.Text = "Show Password";
            this.cbShowPassword.UseVisualStyleBackColor = true;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // tbOldPassword
            // 
            this.tbOldPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.tbOldPassword.Location = new System.Drawing.Point(134, 34);
            this.tbOldPassword.Name = "tbOldPassword";
            this.tbOldPassword.Size = new System.Drawing.Size(200, 20);
            this.tbOldPassword.TabIndex = 2;
            // 
            // tbNewPassword2
            // 
            this.tbNewPassword2.Location = new System.Drawing.Point(134, 86);
            this.tbNewPassword2.Name = "tbNewPassword2";
            this.tbNewPassword2.Size = new System.Drawing.Size(200, 20);
            this.tbNewPassword2.TabIndex = 3;
            this.tbNewPassword2.TextChanged += new System.EventHandler(this.tbNewPassword2_TextChanged);
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Location = new System.Drawing.Point(12, 40);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(72, 13);
            this.lblOldPassword.TabIndex = 4;
            this.lblOldPassword.Text = "Old Password";
            // 
            // lblNewPassword2
            // 
            this.lblNewPassword2.AutoSize = true;
            this.lblNewPassword2.Location = new System.Drawing.Point(12, 89);
            this.lblNewPassword2.Name = "lblNewPassword2";
            this.lblNewPassword2.Size = new System.Drawing.Size(116, 13);
            this.lblNewPassword2.TabIndex = 5;
            this.lblNewPassword2.Text = "Repeat New Password";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(109, 135);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSuggest
            // 
            this.btnSuggest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuggest.Location = new System.Drawing.Point(349, 83);
            this.btnSuggest.Name = "btnSuggest";
            this.btnSuggest.Size = new System.Drawing.Size(75, 23);
            this.btnSuggest.TabIndex = 7;
            this.btnSuggest.Text = "Suggest";
            this.btnSuggest.UseVisualStyleBackColor = true;
            this.btnSuggest.Click += new System.EventHandler(this.btnSuggest_Click);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(12, 66);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(78, 13);
            this.lblNewPassword.TabIndex = 9;
            this.lblNewPassword.Text = "New Password";
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(134, 60);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(200, 20);
            this.tbNewPassword.TabIndex = 8;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblError.Location = new System.Drawing.Point(122, 9);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(87, 13);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "Invalid Password";
            this.lblError.Visible = false;
            // 
            // cbBackUpPassword
            // 
            this.cbBackUpPassword.AutoSize = true;
            this.cbBackUpPassword.Checked = true;
            this.cbBackUpPassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBackUpPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBackUpPassword.Location = new System.Drawing.Point(134, 112);
            this.cbBackUpPassword.Name = "cbBackUpPassword";
            this.cbBackUpPassword.Size = new System.Drawing.Size(143, 17);
            this.cbBackUpPassword.TabIndex = 12;
            this.cbBackUpPassword.Text = "Send Password to Server";
            this.cbBackUpPassword.UseVisualStyleBackColor = true;
            // 
            // frm_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(452, 174);
            this.ControlBox = false;
            this.Controls.Add(this.cbBackUpPassword);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.btnSuggest);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblNewPassword2);
            this.Controls.Add(this.lblOldPassword);
            this.Controls.Add(this.tbNewPassword2);
            this.Controls.Add(this.tbOldPassword);
            this.Controls.Add(this.cbShowPassword);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ChangePassword";
            this.ShowInTaskbar = false;
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbShowPassword;
        private System.Windows.Forms.TextBox tbOldPassword;
        private System.Windows.Forms.TextBox tbNewPassword2;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.Label lblNewPassword2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSuggest;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.CheckBox cbBackUpPassword;
    }
}