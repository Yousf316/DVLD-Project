namespace DVLD_Presentation.Applications.International_Driving_License
{
    partial class frmAddNewInternationalLicesne
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
            this.btnIssue = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkShowInternationalLicense = new System.Windows.Forms.LinkLabel();
            this.lnkLicneseHistory = new System.Windows.Forms.LinkLabel();
            this.ctrLicenseDetailsWithFilter1 = new DVLD_Presentation.Licenses.Control.ctrLicenseDetailsWithFilter();
            this.ctrInternationalApplicationInfo1 = new DVLD_Presentation.Applications.International_Driving_License.Control.ctrInternationalApplicationInfo();
            this.SuspendLayout();
            // 
            // btnIssue
            // 
            this.btnIssue.Enabled = false;
            this.btnIssue.Location = new System.Drawing.Point(734, 938);
            this.btnIssue.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(139, 42);
            this.btnIssue.TabIndex = 5;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(578, 938);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 42);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(219, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "International Driving License Application";
            // 
            // lnkShowInternationalLicense
            // 
            this.lnkShowInternationalLicense.AutoSize = true;
            this.lnkShowInternationalLicense.Enabled = false;
            this.lnkShowInternationalLicense.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lnkShowInternationalLicense.Location = new System.Drawing.Point(280, 949);
            this.lnkShowInternationalLicense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkShowInternationalLicense.Name = "lnkShowInternationalLicense";
            this.lnkShowInternationalLicense.Size = new System.Drawing.Size(297, 23);
            this.lnkShowInternationalLicense.TabIndex = 9;
            this.lnkShowInternationalLicense.TabStop = true;
            this.lnkShowInternationalLicense.Text = "Show International License Details";
            this.lnkShowInternationalLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkShowInternationalLicense_LinkClicked);
            // 
            // lnkLicneseHistory
            // 
            this.lnkLicneseHistory.AutoSize = true;
            this.lnkLicneseHistory.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lnkLicneseHistory.Location = new System.Drawing.Point(22, 949);
            this.lnkLicneseHistory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkLicneseHistory.Name = "lnkLicneseHistory";
            this.lnkLicneseHistory.Size = new System.Drawing.Size(253, 23);
            this.lnkLicneseHistory.TabIndex = 8;
            this.lnkLicneseHistory.TabStop = true;
            this.lnkLicneseHistory.Text = "Show License License History";
            this.lnkLicneseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLicneseHistory_LinkClicked);
            // 
            // ctrLicenseDetailsWithFilter1
            // 
            this.ctrLicenseDetailsWithFilter1.Font = new System.Drawing.Font("Tahoma", 7F);
            this.ctrLicenseDetailsWithFilter1.Location = new System.Drawing.Point(12, 119);
            this.ctrLicenseDetailsWithFilter1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ctrLicenseDetailsWithFilter1.Name = "ctrLicenseDetailsWithFilter1";
            this.ctrLicenseDetailsWithFilter1.Size = new System.Drawing.Size(884, 526);
            this.ctrLicenseDetailsWithFilter1.TabIndex = 7;
            this.ctrLicenseDetailsWithFilter1.OnSerachButton += new System.Action<int>(this.ctrLicenseDetailsWithFilter1_OnSerachButton);
            // 
            // ctrInternationalApplicationInfo1
            // 
            this.ctrInternationalApplicationInfo1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ctrInternationalApplicationInfo1.Location = new System.Drawing.Point(13, 634);
            this.ctrInternationalApplicationInfo1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrInternationalApplicationInfo1.Name = "ctrInternationalApplicationInfo1";
            this.ctrInternationalApplicationInfo1.Size = new System.Drawing.Size(1034, 313);
            this.ctrInternationalApplicationInfo1.TabIndex = 1;
            this.ctrInternationalApplicationInfo1.Load += new System.EventHandler(this.ctrInternationalApplicationInfo1_Load);
            // 
            // frmAddNewInternationalLicesne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1065, 1002);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnkShowInternationalLicense);
            this.Controls.Add(this.lnkLicneseHistory);
            this.Controls.Add(this.ctrLicenseDetailsWithFilter1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.ctrInternationalApplicationInfo1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddNewInternationalLicesne";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddNewInternationalLicesne";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.frmAddNewInternationalLicesne_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIssue;
        private Control.ctrInternationalApplicationInfo ctrInternationalApplicationInfo1;
        private System.Windows.Forms.Button button2;
        private Licenses.Control.ctrLicenseDetailsWithFilter ctrLicenseDetailsWithFilter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkShowInternationalLicense;
        private System.Windows.Forms.LinkLabel lnkLicneseHistory;
    }
}