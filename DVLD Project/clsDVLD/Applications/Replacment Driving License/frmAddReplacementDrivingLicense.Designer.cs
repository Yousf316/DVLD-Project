namespace DVLD_Presentation.Applications.Replacment_Driving_License
{
    partial class frmAddReplacementDrivingLicense
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
            this.lbtitle = new System.Windows.Forms.Label();
            this.lnlbShowRenewlicense = new System.Windows.Forms.LinkLabel();
            this.lnkLicneseHistory = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnReplased = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdLostLicense = new System.Windows.Forms.RadioButton();
            this.rdDamagedLicense = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbOldLicenseID = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbReplacedLicenseID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.lbApplicationID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ctrLicenseDetailsWithFilter1 = new DVLD_Presentation.Licenses.Control.ctrLicenseDetailsWithFilter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lbtitle.ForeColor = System.Drawing.Color.Red;
            this.lbtitle.Location = new System.Drawing.Point(143, 21);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(425, 29);
            this.lbtitle.TabIndex = 27;
            this.lbtitle.Text = "Replacment Driving License Application";
            // 
            // lnlbShowRenewlicense
            // 
            this.lnlbShowRenewlicense.AutoSize = true;
            this.lnlbShowRenewlicense.Enabled = false;
            this.lnlbShowRenewlicense.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lnlbShowRenewlicense.Location = new System.Drawing.Point(243, 683);
            this.lnlbShowRenewlicense.Name = "lnlbShowRenewlicense";
            this.lnlbShowRenewlicense.Size = new System.Drawing.Size(241, 18);
            this.lnlbShowRenewlicense.TabIndex = 26;
            this.lnlbShowRenewlicense.TabStop = true;
            this.lnlbShowRenewlicense.Text = "Show Renew License License Details";
            // 
            // lnkLicneseHistory
            // 
            this.lnkLicneseHistory.AutoSize = true;
            this.lnkLicneseHistory.Enabled = false;
            this.lnkLicneseHistory.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lnkLicneseHistory.Location = new System.Drawing.Point(16, 683);
            this.lnkLicneseHistory.Name = "lnkLicneseHistory";
            this.lnkLicneseHistory.Size = new System.Drawing.Size(196, 18);
            this.lnkLicneseHistory.TabIndex = 25;
            this.lnkLicneseHistory.TabStop = true;
            this.lnkLicneseHistory.Text = "Show License License History";
            // 
            // button2
            // 
            this.button2.Image = global::DVLD_Presentation.Properties.Resources.icons8_cancel_30;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(521, 676);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 34);
            this.button2.TabIndex = 23;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnReplased
            // 
            this.btnReplased.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReplased.Enabled = false;
            this.btnReplased.Image = global::DVLD_Presentation.Properties.Resources.IssueDrivingLicense_32;
            this.btnReplased.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReplased.Location = new System.Drawing.Point(655, 676);
            this.btnReplased.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReplased.Name = "btnReplased";
            this.btnReplased.Size = new System.Drawing.Size(119, 34);
            this.btnReplased.TabIndex = 22;
            this.btnReplased.Text = "Replease";
            this.btnReplased.UseVisualStyleBackColor = true;
            this.btnReplased.Click += new System.EventHandler(this.btnReplased_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdLostLicense);
            this.groupBox1.Controls.Add(this.rdDamagedLicense);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.groupBox1.Location = new System.Drawing.Point(511, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 76);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Repalecment for";
            // 
            // rdLostLicense
            // 
            this.rdLostLicense.AutoSize = true;
            this.rdLostLicense.Location = new System.Drawing.Point(6, 53);
            this.rdLostLicense.Name = "rdLostLicense";
            this.rdLostLicense.Size = new System.Drawing.Size(92, 18);
            this.rdLostLicense.TabIndex = 1;
            this.rdLostLicense.TabStop = true;
            this.rdLostLicense.Text = "Lost License";
            this.rdLostLicense.UseVisualStyleBackColor = true;
            // 
            // rdDamagedLicense
            // 
            this.rdDamagedLicense.AutoSize = true;
            this.rdDamagedLicense.Location = new System.Drawing.Point(6, 30);
            this.rdDamagedLicense.Name = "rdDamagedLicense";
            this.rdDamagedLicense.Size = new System.Drawing.Size(120, 18);
            this.rdDamagedLicense.TabIndex = 0;
            this.rdDamagedLicense.TabStop = true;
            this.rdDamagedLicense.Text = "Damaged License";
            this.rdDamagedLicense.UseVisualStyleBackColor = true;
            this.rdDamagedLicense.CheckedChanged += new System.EventHandler(this.rdDamagedLicense_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbOldLicenseID);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbApplicationFees);
            this.groupBox2.Controls.Add(this.lbCreatedBy);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbReplacedLicenseID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbApplicationDate);
            this.groupBox2.Controls.Add(this.lbApplicationID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.groupBox2.Location = new System.Drawing.Point(12, 478);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 167);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Application Replacment License Information";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Application Fees :";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.AutoSize = true;
            this.lbApplicationFees.Location = new System.Drawing.Point(193, 116);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(40, 22);
            this.lbApplicationFees.TabIndex = 9;
            this.lbApplicationFees.Text = "N/A";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Location = new System.Drawing.Point(581, 116);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(40, 22);
            this.lbCreatedBy.TabIndex = 7;
            this.lbCreatedBy.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(448, 116);
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
            // lbReplacedLicenseID
            // 
            this.lbReplacedLicenseID.AutoSize = true;
            this.lbReplacedLicenseID.Location = new System.Drawing.Point(579, 37);
            this.lbReplacedLicenseID.Name = "lbReplacedLicenseID";
            this.lbReplacedLicenseID.Size = new System.Drawing.Size(40, 22);
            this.lbReplacedLicenseID.TabIndex = 5;
            this.lbReplacedLicenseID.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = " Replaced License ID :";
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
            this.ctrLicenseDetailsWithFilter1.Location = new System.Drawing.Point(12, 52);
            this.ctrLicenseDetailsWithFilter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrLicenseDetailsWithFilter1.Name = "ctrLicenseDetailsWithFilter1";
            this.ctrLicenseDetailsWithFilter1.Size = new System.Drawing.Size(758, 427);
            this.ctrLicenseDetailsWithFilter1.TabIndex = 24;
            this.ctrLicenseDetailsWithFilter1.OnSerachButton += new System.Action<int>(this.ctrLicenseDetailsWithFilter1_OnSerachButton);
            // 
            // frmAddReplacementDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 719);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbtitle);
            this.Controls.Add(this.lnlbShowRenewlicense);
            this.Controls.Add(this.lnkLicneseHistory);
            this.Controls.Add(this.ctrLicenseDetailsWithFilter1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnReplased);
            this.Name = "frmAddReplacementDrivingLicense";
            this.Text = "Replacement Driving License";
            this.Load += new System.EventHandler(this.frmAddReplacementDrivingLicense_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbtitle;
        private System.Windows.Forms.LinkLabel lnlbShowRenewlicense;
        private System.Windows.Forms.LinkLabel lnkLicneseHistory;
        private Licenses.Control.ctrLicenseDetailsWithFilter ctrLicenseDetailsWithFilter1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnReplased;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdLostLicense;
        private System.Windows.Forms.RadioButton rdDamagedLicense;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbOldLicenseID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbApplicationFees;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbReplacedLicenseID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.Label lbApplicationID;
        private System.Windows.Forms.Label label3;
    }
}