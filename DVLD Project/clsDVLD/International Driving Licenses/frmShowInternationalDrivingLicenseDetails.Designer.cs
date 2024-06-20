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
            this.ctrImternationalLicenseDetails1.Location = new System.Drawing.Point(14, 97);
            this.ctrImternationalLicenseDetails1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ctrImternationalLicenseDetails1.Name = "ctrImternationalLicenseDetails1";
            this.ctrImternationalLicenseDetails1.Size = new System.Drawing.Size(1017, 300);
            this.ctrImternationalLicenseDetails1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(321, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "International Driving License";
            // 
            // frmShowInternationalDrivingLicenseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrImternationalLicenseDetails1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmShowInternationalDrivingLicenseDetails";
            this.Text = "Show International License Details";
            this.Load += new System.EventHandler(this.frmShowInternationalDrivingLicenseDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrImternationalLicenseDetails ctrImternationalLicenseDetails1;
        private System.Windows.Forms.Label label1;
    }
}