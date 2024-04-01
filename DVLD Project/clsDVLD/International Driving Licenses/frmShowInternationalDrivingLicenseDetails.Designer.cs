namespace DVLD_Presentation.International_Driving_Licenses
{
    partial class frmShowInternationalDrivingLicenseDetails
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
            this.ctrImternationalLicenseDetails1 = new DVLD_Presentation.International_Driving_Licenses.Controls.ctrImternationalLicenseDetails();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrImternationalLicenseDetails1
            // 
            this.ctrImternationalLicenseDetails1.Location = new System.Drawing.Point(12, 79);
            this.ctrImternationalLicenseDetails1.Name = "ctrImternationalLicenseDetails1";
            this.ctrImternationalLicenseDetails1.Size = new System.Drawing.Size(872, 244);
            this.ctrImternationalLicenseDetails1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(275, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "International Driving License";
            // 
            // frmShowInternationalDrivingLicenseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 335);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrImternationalLicenseDetails1);
            this.Name = "frmShowInternationalDrivingLicenseDetails";
            this.Text = "frmShowInternationalDrivingLicenseDetails";
            this.Load += new System.EventHandler(this.frmShowInternationalDrivingLicenseDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrImternationalLicenseDetails ctrImternationalLicenseDetails1;
        private System.Windows.Forms.Label label1;
    }
}