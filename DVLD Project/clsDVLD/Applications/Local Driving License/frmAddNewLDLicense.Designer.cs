﻿namespace DVLD_Presentation
{
    partial class frmAddNewLDLicense
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
            this.lbSubjectTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabctr1 = new System.Windows.Forms.TabControl();
            this.tabPerson = new System.Windows.Forms.TabPage();
            this.ctrShowPeopleWithSearch1 = new DVLD_Presentation.ctrShowPeopleWithSearch();
            this.btnNext = new System.Windows.Forms.Button();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.lbCreatedUser = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbAppFees = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAppTypes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAppDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAppID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabctr1.SuspendLayout();
            this.tabPerson.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSubjectTitle
            // 
            this.lbSubjectTitle.AutoSize = true;
            this.lbSubjectTitle.Font = new System.Drawing.Font("Urdu Typesetting", 18F, System.Drawing.FontStyle.Bold);
            this.lbSubjectTitle.ForeColor = System.Drawing.Color.Red;
            this.lbSubjectTitle.Location = new System.Drawing.Point(267, 14);
            this.lbSubjectTitle.Name = "lbSubjectTitle";
            this.lbSubjectTitle.Size = new System.Drawing.Size(238, 44);
            this.lbSubjectTitle.TabIndex = 10;
            this.lbSubjectTitle.Text = "Add New Application";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(431, 557);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(161, 44);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(608, 557);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 44);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabctr1
            // 
            this.tabctr1.Controls.Add(this.tabPerson);
            this.tabctr1.Controls.Add(this.tabUser);
            this.tabctr1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tabctr1.Location = new System.Drawing.Point(11, 42);
            this.tabctr1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabctr1.Name = "tabctr1";
            this.tabctr1.SelectedIndex = 0;
            this.tabctr1.Size = new System.Drawing.Size(779, 510);
            this.tabctr1.TabIndex = 7;
            // 
            // tabPerson
            // 
            this.tabPerson.Controls.Add(this.ctrShowPeopleWithSearch1);
            this.tabPerson.Controls.Add(this.btnNext);
            this.tabPerson.Font = new System.Drawing.Font("Tahoma", 7F);
            this.tabPerson.Location = new System.Drawing.Point(4, 25);
            this.tabPerson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPerson.Name = "tabPerson";
            this.tabPerson.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPerson.Size = new System.Drawing.Size(771, 481);
            this.tabPerson.TabIndex = 0;
            this.tabPerson.Text = "Person";
            this.tabPerson.UseVisualStyleBackColor = true;
            // 
            // ctrShowPeopleWithSearch1
            // 
            this.ctrShowPeopleWithSearch1.Location = new System.Drawing.Point(12, 25);
            this.ctrShowPeopleWithSearch1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrShowPeopleWithSearch1.Name = "ctrShowPeopleWithSearch1";
            this.ctrShowPeopleWithSearch1.Size = new System.Drawing.Size(753, 402);
            this.ctrShowPeopleWithSearch1.TabIndex = 2;
            this.ctrShowPeopleWithSearch1.OnButtonSetPerson += new System.Action<int>(this.ctrShowPeopleWithSearch1_OnButtonSetPerson);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 7F);
            this.btnNext.Location = new System.Drawing.Point(593, 431);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(161, 44);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.lbCreatedUser);
            this.tabUser.Controls.Add(this.label9);
            this.tabUser.Controls.Add(this.lbAppFees);
            this.tabUser.Controls.Add(this.label7);
            this.tabUser.Controls.Add(this.cmbAppTypes);
            this.tabUser.Controls.Add(this.label4);
            this.tabUser.Controls.Add(this.lbAppDate);
            this.tabUser.Controls.Add(this.label2);
            this.tabUser.Controls.Add(this.lbAppID);
            this.tabUser.Controls.Add(this.label5);
            this.tabUser.Location = new System.Drawing.Point(4, 25);
            this.tabUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUser.Size = new System.Drawing.Size(771, 481);
            this.tabUser.TabIndex = 1;
            this.tabUser.Text = "Application Info";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // lbCreatedUser
            // 
            this.lbCreatedUser.AutoSize = true;
            this.lbCreatedUser.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbCreatedUser.Location = new System.Drawing.Point(289, 323);
            this.lbCreatedUser.Name = "lbCreatedUser";
            this.lbCreatedUser.Size = new System.Drawing.Size(37, 19);
            this.lbCreatedUser.TabIndex = 20;
            this.lbCreatedUser.Text = "N/A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label9.Location = new System.Drawing.Point(136, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Created By :";
            // 
            // lbAppFees
            // 
            this.lbAppFees.AutoSize = true;
            this.lbAppFees.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbAppFees.Location = new System.Drawing.Point(290, 268);
            this.lbAppFees.Name = "lbAppFees";
            this.lbAppFees.Size = new System.Drawing.Size(37, 19);
            this.lbAppFees.TabIndex = 18;
            this.lbAppFees.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(137, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Application Fees :";
            // 
            // cmbAppTypes
            // 
            this.cmbAppTypes.FormattingEnabled = true;
            this.cmbAppTypes.Location = new System.Drawing.Point(264, 216);
            this.cmbAppTypes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAppTypes.Name = "cmbAppTypes";
            this.cmbAppTypes.Size = new System.Drawing.Size(245, 24);
            this.cmbAppTypes.TabIndex = 16;
            this.cmbAppTypes.SelectedIndexChanged += new System.EventHandler(this.cmbAppTypes_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(137, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "License Class :";
            // 
            // lbAppDate
            // 
            this.lbAppDate.AutoSize = true;
            this.lbAppDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbAppDate.Location = new System.Drawing.Point(289, 166);
            this.lbAppDate.Name = "lbAppDate";
            this.lbAppDate.Size = new System.Drawing.Size(37, 19);
            this.lbAppDate.TabIndex = 13;
            this.lbAppDate.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(136, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Application Date :";
            // 
            // lbAppID
            // 
            this.lbAppID.AutoSize = true;
            this.lbAppID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbAppID.Location = new System.Drawing.Point(289, 106);
            this.lbAppID.Name = "lbAppID";
            this.lbAppID.Size = new System.Drawing.Size(37, 19);
            this.lbAppID.TabIndex = 10;
            this.lbAppID.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(125, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "D.L.Application ID :";
            // 
            // frmAddNewLDLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 617);
            this.Controls.Add(this.lbSubjectTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabctr1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddNewLDLicense";
            this.Text = "AddNewLDLicense";
            this.Load += new System.EventHandler(this.frmAddNewLDLicense_Load);
            this.tabctr1.ResumeLayout(false);
            this.tabPerson.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSubjectTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabctr1;
        private System.Windows.Forms.TabPage tabPerson;
        private ctrShowPeopleWithSearch ctrShowPeopleWithSearch1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.Label lbAppID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCreatedUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbAppFees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbAppTypes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbAppDate;
        private System.Windows.Forms.Label label2;
    }
}