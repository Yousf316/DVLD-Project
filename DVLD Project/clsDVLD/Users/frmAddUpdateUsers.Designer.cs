﻿namespace DVLD_Presentation
{
    partial class frmAddUpdateUsers
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
            this.components = new System.ComponentModel.Container();
            this.tabctr1 = new System.Windows.Forms.TabControl();
            this.tabPerson = new System.Windows.Forms.TabPage();
            this.ctrShowPeopleWithSearch1 = new DVLD_Presentation.ctrShowPeopleWithSearch();
            this.button1 = new System.Windows.Forms.Button();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.lbUserID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabctr1.SuspendLayout();
            this.tabPerson.SuspendLayout();
            this.tabUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabctr1
            // 
            this.tabctr1.Controls.Add(this.tabPerson);
            this.tabctr1.Controls.Add(this.tabUser);
            this.tabctr1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tabctr1.Location = new System.Drawing.Point(12, 103);
            this.tabctr1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabctr1.Name = "tabctr1";
            this.tabctr1.SelectedIndex = 0;
            this.tabctr1.Size = new System.Drawing.Size(909, 628);
            this.tabctr1.TabIndex = 0;
            // 
            // tabPerson
            // 
            this.tabPerson.Controls.Add(this.ctrShowPeopleWithSearch1);
            this.tabPerson.Controls.Add(this.button1);
            this.tabPerson.Font = new System.Drawing.Font("Tahoma", 7F);
            this.tabPerson.Location = new System.Drawing.Point(4, 30);
            this.tabPerson.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabPerson.Name = "tabPerson";
            this.tabPerson.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabPerson.Size = new System.Drawing.Size(901, 594);
            this.tabPerson.TabIndex = 0;
            this.tabPerson.Text = "Person";
            this.tabPerson.UseVisualStyleBackColor = true;
            // 
            // ctrShowPeopleWithSearch1
            // 
            this.ctrShowPeopleWithSearch1.Location = new System.Drawing.Point(14, 31);
            this.ctrShowPeopleWithSearch1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ctrShowPeopleWithSearch1.Name = "ctrShowPeopleWithSearch1";
            this.ctrShowPeopleWithSearch1.Size = new System.Drawing.Size(878, 495);
            this.ctrShowPeopleWithSearch1.TabIndex = 2;
            this.ctrShowPeopleWithSearch1.OnButtonSetPerson += new System.Action<int>(this.ctrShowPeopleWithSearch1_OnButtonSet);
            this.ctrShowPeopleWithSearch1.Load += new System.EventHandler(this.ctrShowPeopleWithSearch1_Load);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 7F);
            this.button1.Location = new System.Drawing.Point(692, 530);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.linkLabel1);
            this.tabUser.Controls.Add(this.chkIsActive);
            this.tabUser.Controls.Add(this.lbUserID);
            this.tabUser.Controls.Add(this.label5);
            this.tabUser.Controls.Add(this.txtConfirmPassword);
            this.tabUser.Controls.Add(this.label3);
            this.tabUser.Controls.Add(this.txtPassword);
            this.tabUser.Controls.Add(this.txtUserName);
            this.tabUser.Controls.Add(this.label2);
            this.tabUser.Controls.Add(this.label1);
            this.tabUser.Location = new System.Drawing.Point(4, 30);
            this.tabUser.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabUser.Size = new System.Drawing.Size(901, 594);
            this.tabUser.TabIndex = 1;
            this.tabUser.Text = "User";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(427, 446);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(141, 21);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Change Password";
            this.linkLabel1.Visible = false;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Location = new System.Drawing.Point(324, 444);
            this.chkIsActive.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(102, 25);
            this.chkIsActive.TabIndex = 11;
            this.chkIsActive.Text = " Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbUserID.Location = new System.Drawing.Point(298, 153);
            this.lbUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(43, 24);
            this.lbUserID.TabIndex = 10;
            this.lbUserID.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(170, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "User ID:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(294, 363);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(186, 24);
            this.txtConfirmPassword.TabIndex = 5;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(119, 363);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirm Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtPassword.Location = new System.Drawing.Point(294, 302);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(186, 24);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtUserName.Location = new System.Drawing.Point(294, 229);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(186, 24);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(177, 302);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(177, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(708, 736);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(188, 54);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(502, 736);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(188, 54);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Urdu Typesetting", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(342, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 55);
            this.label6.TabIndex = 6;
            this.label6.Text = "Add New User";
            // 
            // frmAddUpdateUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 801);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabctr1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmAddUpdateUsers";
            this.Text = "Add Update Users";
            this.Load += new System.EventHandler(this.frmAddUpdateUsers_Load);
            this.tabctr1.ResumeLayout(false);
            this.tabPerson.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabctr1;
        private System.Windows.Forms.TabPage tabPerson;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private ctrShowPeopleWithSearch ctrShowPeopleWithSearch1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}