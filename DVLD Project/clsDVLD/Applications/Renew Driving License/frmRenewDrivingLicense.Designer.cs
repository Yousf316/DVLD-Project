namespace DVLD_Presentation.Applications.Renew_Driving_License
{
    partial class frmRenewDrivingLicense
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lnlbShowRenewlicense = new System.Windows.Forms.LinkLabel();
            this.lnkLicneseHistory = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxtNote = new System.Windows.Forms.RichTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbTotalFees = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbLicenseFees = new System.Windows.Forms.Label();
            this.lbOldLicenseID = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbExpirationDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbIssueDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbRenewLicenseID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.lbApplicationID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ctrLicenseDetailsWithFilter1 = new DVLD_Presentation.Licenses.Control.ctrLicenseDetailsWithFilter();
            this.btnRenew = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(190, -30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "International Driving License Application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(152, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Renew Driving License Application";
            // 
            // lnlbShowRenewlicense
            // 
            this.lnlbShowRenewlicense.AutoSize = true;
            this.lnlbShowRenewlicense.Enabled = false;
            this.lnlbShowRenewlicense.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lnlbShowRenewlicense.Location = new System.Drawing.Point(273, 779);
            this.lnlbShowRenewlicense.Name = "lnlbShowRenewlicense";
            this.lnlbShowRenewlicense.Size = new System.Drawing.Size(241, 18);
            this.lnlbShowRenewlicense.TabIndex = 19;
            this.lnlbShowRenewlicense.TabStop = true;
            this.lnlbShowRenewlicense.Text = "Show Renew License License Details";
            this.lnlbShowRenewlicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lnkLicneseHistory
            // 
            this.lnkLicneseHistory.AutoSize = true;
            this.lnkLicneseHistory.Enabled = false;
            this.lnkLicneseHistory.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lnkLicneseHistory.Location = new System.Drawing.Point(46, 779);
            this.lnkLicneseHistory.Name = "lnkLicneseHistory";
            this.lnkLicneseHistory.Size = new System.Drawing.Size(196, 18);
            this.lnkLicneseHistory.TabIndex = 18;
            this.lnkLicneseHistory.TabStop = true;
            this.lnkLicneseHistory.Text = "Show License License History";
            this.lnkLicneseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLicneseHistory_LinkClicked);
            // 
            // button2
            // 
            this.button2.Image = global::DVLD_Presentation.Properties.Resources.icons8_cancel_30;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(551, 772);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 34);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxtNote);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.lbTotalFees);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lbLicenseFees);
            this.groupBox1.Controls.Add(this.lbOldLicenseID);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lbExpirationDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbIssueDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbApplicationFees);
            this.groupBox1.Controls.Add(this.lbCreatedBy);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbRenewLicenseID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbApplicationDate);
            this.groupBox1.Controls.Add(this.lbApplicationID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.groupBox1.Location = new System.Drawing.Point(21, 487);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 280);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Renew License Information";
            // 
            // rtxtNote
            // 
            this.rtxtNote.Location = new System.Drawing.Point(136, 216);
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(341, 58);
            this.rtxtNote.TabIndex = 21;
            this.rtxtNote.Text = "";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(71, 216);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 22);
            this.label18.TabIndex = 20;
            this.label18.Text = "Note :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(453, 183);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 22);
            this.label16.TabIndex = 18;
            this.label16.Text = "Total Fees :";
            // 
            // lbTotalFees
            // 
            this.lbTotalFees.AutoSize = true;
            this.lbTotalFees.Location = new System.Drawing.Point(583, 183);
            this.lbTotalFees.Name = "lbTotalFees";
            this.lbTotalFees.Size = new System.Drawing.Size(40, 22);
            this.lbTotalFees.TabIndex = 19;
            this.lbTotalFees.Text = "N/A";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(68, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 22);
            this.label14.TabIndex = 16;
            this.label14.Text = "License Fees :";
            // 
            // lbLicenseFees
            // 
            this.lbLicenseFees.AutoSize = true;
            this.lbLicenseFees.Location = new System.Drawing.Point(194, 183);
            this.lbLicenseFees.Name = "lbLicenseFees";
            this.lbLicenseFees.Size = new System.Drawing.Size(40, 22);
            this.lbLicenseFees.TabIndex = 17;
            this.lbLicenseFees.Text = "N/A";
            // 
            // lbOldLicenseID
            // 
            this.lbOldLicenseID.AutoSize = true;
            this.lbOldLicenseID.Location = new System.Drawing.Point(580, 74);
            this.lbOldLicenseID.Name = "lbOldLicenseID";
            this.lbOldLicenseID.Size = new System.Drawing.Size(40, 22);
            this.lbOldLicenseID.TabIndex = 15;
            this.lbOldLicenseID.Text = "N/A";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(421, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 22);
            this.label13.TabIndex = 14;
            this.label13.Text = "Old License ID :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(414, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 22);
            this.label10.TabIndex = 12;
            this.label10.Text = "Expiration Date :";
            // 
            // lbExpirationDate
            // 
            this.lbExpirationDate.AutoSize = true;
            this.lbExpirationDate.Location = new System.Drawing.Point(580, 113);
            this.lbExpirationDate.Name = "lbExpirationDate";
            this.lbExpirationDate.Size = new System.Drawing.Size(40, 22);
            this.lbExpirationDate.TabIndex = 13;
            this.lbExpirationDate.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Issue Date :";
            // 
            // lbIssueDate
            // 
            this.lbIssueDate.AutoSize = true;
            this.lbIssueDate.Location = new System.Drawing.Point(193, 113);
            this.lbIssueDate.Name = "lbIssueDate";
            this.lbIssueDate.Size = new System.Drawing.Size(40, 22);
            this.lbIssueDate.TabIndex = 11;
            this.lbIssueDate.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Application Fees :";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.AutoSize = true;
            this.lbApplicationFees.Location = new System.Drawing.Point(194, 150);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(40, 22);
            this.lbApplicationFees.TabIndex = 9;
            this.lbApplicationFees.Text = "N/A";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Location = new System.Drawing.Point(581, 150);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(40, 22);
            this.lbCreatedBy.TabIndex = 7;
            this.lbCreatedBy.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(448, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 22);
            this.label8.TabIndex = 6;
            this.label8.Text = "Created By :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Application Date :";
            // 
            // lbRenewLicenseID
            // 
            this.lbRenewLicenseID.AutoSize = true;
            this.lbRenewLicenseID.Location = new System.Drawing.Point(579, 37);
            this.lbRenewLicenseID.Name = "lbRenewLicenseID";
            this.lbRenewLicenseID.Size = new System.Drawing.Size(40, 22);
            this.lbRenewLicenseID.TabIndex = 5;
            this.lbRenewLicenseID.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = " Renewed License ID :";
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.AutoSize = true;
            this.lbApplicationDate.Location = new System.Drawing.Point(194, 74);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(40, 22);
            this.lbApplicationDate.TabIndex = 3;
            this.lbApplicationDate.Text = "N/A";
            // 
            // lbApplicationID
            // 
            this.lbApplicationID.AutoSize = true;
            this.lbApplicationID.Location = new System.Drawing.Point(193, 37);
            this.lbApplicationID.Name = "lbApplicationID";
            this.lbApplicationID.Size = new System.Drawing.Size(40, 22);
            this.lbApplicationID.TabIndex = 1;
            this.lbApplicationID.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Application ID :";
            // 
            // ctrLicenseDetailsWithFilter1
            // 
            this.ctrLicenseDetailsWithFilter1.Font = new System.Drawing.Font("Tahoma", 7F);
            this.ctrLicenseDetailsWithFilter1.Location = new System.Drawing.Point(21, 65);
            this.ctrLicenseDetailsWithFilter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrLicenseDetailsWithFilter1.Name = "ctrLicenseDetailsWithFilter1";
            this.ctrLicenseDetailsWithFilter1.Size = new System.Drawing.Size(758, 427);
            this.ctrLicenseDetailsWithFilter1.TabIndex = 17;
            this.ctrLicenseDetailsWithFilter1.OnSerachButton += new System.Action<int>(this.ctrLicenseDetailsWithFilter1_OnSerachButton);
            // 
            // btnRenew
            // 
            this.btnRenew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRenew.Enabled = false;
            this.btnRenew.Image = global::DVLD_Presentation.Properties.Resources.IssueDrivingLicense_32;
            this.btnRenew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenew.Location = new System.Drawing.Point(685, 772);
            this.btnRenew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(119, 34);
            this.btnRenew.TabIndex = 15;
            this.btnRenew.Text = "Renew";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // frmRenewDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 818);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lnlbShowRenewlicense);
            this.Controls.Add(this.lnkLicneseHistory);
            this.Controls.Add(this.ctrLicenseDetailsWithFilter1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.label1);
            this.Name = "frmRenewDrivingLicense";
            this.Text = "frmRenewDrivingLicense";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnlbShowRenewlicense;
        private System.Windows.Forms.LinkLabel lnkLicneseHistory;
        private Licenses.Control.ctrLicenseDetailsWithFilter ctrLicenseDetailsWithFilter1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbRenewLicenseID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.Label lbApplicationID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbApplicationFees;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbLicenseFees;
        private System.Windows.Forms.Label lbOldLicenseID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbExpirationDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbIssueDate;
        private System.Windows.Forms.RichTextBox rtxtNote;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbTotalFees;
    }
}