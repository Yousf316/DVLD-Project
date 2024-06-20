namespace DVLD_Presentation.Licenses
{
    partial class frmShowLicenseDetails
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
            this.ctrLicenseDetails1 = new DVLD_Presentation.Licenses.Control.ctrLicenseDetails();
            this.SuspendLayout();
            // 
            // ctrLicenseDetails1
            // 
            this.ctrLicenseDetails1.Location = new System.Drawing.Point(-1, 12);
            this.ctrLicenseDetails1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ctrLicenseDetails1.Name = "ctrLicenseDetails1";
            this.ctrLicenseDetails1.Size = new System.Drawing.Size(1045, 483);
            this.ctrLicenseDetails1.TabIndex = 0;
            // 
            // frmShowLicenseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 491);
            this.Controls.Add(this.ctrLicenseDetails1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmShowLicenseDetails";
            this.Text = "Show License Details";
            this.Load += new System.EventHandler(this.frmSowLicenseDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Control.ctrLicenseDetails ctrLicenseDetails1;
    }
}