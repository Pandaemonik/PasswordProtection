﻿namespace PasswordProtection
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gbDangerZone = new System.Windows.Forms.GroupBox();
            this.dgAccountList = new System.Windows.Forms.DataGridView();
            this.clmnWebsite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.gbDangerZone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(647, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator2,
            this.logOutToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(165, 6);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(425, 118);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(58, 13);
            this.lblLink.TabIndex = 4;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "Link to site";
            this.lblLink.Visible = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(6, 19);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Location = new System.Drawing.Point(445, 180);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Location = new System.Drawing.Point(428, 88);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(202, 27);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(428, 73);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(428, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(202, 27);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(428, 27);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email:";
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.Location = new System.Drawing.Point(477, 157);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(102, 17);
            this.cbShowPassword.TabIndex = 13;
            this.cbShowPassword.Text = "Show Password";
            this.cbShowPassword.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(542, 180);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // gbDangerZone
            // 
            this.gbDangerZone.Controls.Add(this.btn_Delete);
            this.gbDangerZone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDangerZone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbDangerZone.Location = new System.Drawing.Point(488, 209);
            this.gbDangerZone.Name = "gbDangerZone";
            this.gbDangerZone.Size = new System.Drawing.Size(91, 56);
            this.gbDangerZone.TabIndex = 15;
            this.gbDangerZone.TabStop = false;
            this.gbDangerZone.Text = "Danger Zone";
            // 
            // dgAccountList
            // 
            this.dgAccountList.AllowUserToAddRows = false;
            this.dgAccountList.AllowUserToDeleteRows = false;
            this.dgAccountList.AllowUserToResizeColumns = false;
            this.dgAccountList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgAccountList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgAccountList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccountList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnWebsite,
            this.clmnUsername});
            this.dgAccountList.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgAccountList.EnableHeadersVisualStyles = false;
            this.dgAccountList.GridColor = System.Drawing.SystemColors.Control;
            this.dgAccountList.Location = new System.Drawing.Point(12, 27);
            this.dgAccountList.MultiSelect = false;
            this.dgAccountList.Name = "dgAccountList";
            this.dgAccountList.ReadOnly = true;
            this.dgAccountList.RowHeadersVisible = false;
            this.dgAccountList.RowTemplate.ReadOnly = true;
            this.dgAccountList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAccountList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAccountList.Size = new System.Drawing.Size(410, 368);
            this.dgAccountList.TabIndex = 17;
            this.dgAccountList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAccountList_CellContentClick);
            // 
            // clmnWebsite
            // 
            this.clmnWebsite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnWebsite.HeaderText = "Website";
            this.clmnWebsite.Name = "clmnWebsite";
            this.clmnWebsite.ReadOnly = true;
            // 
            // clmnUsername
            // 
            this.clmnUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnUsername.HeaderText = "Username";
            this.clmnUsername.Name = "clmnUsername";
            this.clmnUsername.ReadOnly = true;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 407);
            this.Controls.Add(this.dgAccountList);
            this.Controls.Add(this.gbDangerZone);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbShowPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_main";
            this.Text = "Password Manager";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbDangerZone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lblLink;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.CheckBox cbShowPassword;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox gbDangerZone;
        private System.Windows.Forms.DataGridView dgAccountList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnWebsite;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnUsername;
    }
}

