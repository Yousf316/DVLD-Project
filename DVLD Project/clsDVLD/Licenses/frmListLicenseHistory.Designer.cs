namespace DVLD_Presentation.Licenses
{
    partial class frmListLicenseHistory
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
            this.ctrListDdriverLicenses1 = new DVLD_Presentation.Licenses.Control.ctrListDdriverLicenses();
            this.ctrShowPerson1 = new DVLD_Presentation.ctrShowPerson();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(387, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "License History";
            // 
            // ctrListDdriverLicenses1
            // 
            this.ctrListDdriverLicenses1.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.ctrListDdriverLicenses1.Location = new System.Drawing.Point(12, 453);
            this.ctrListDdriverLicenses1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrListDdriverLicenses1.Name = "ctrListDdriverLicenses1";
            this.ctrListDdriverLicenses1.Size = new System.Drawing.Size(859, 315);
            this.ctrListDdriverLicenses1.TabIndex = 1;
            // 
            // ctrShowPerson1
            // 
            this.ctrShowPerson1.Font = new System.Drawing.Font("Tahoma", 7F);
            this.ctrShowPerson1.Location = new System.Drawing.Point(12, 74);
            this.ctrShowPerson1.Name = "ctrShowPerson1";
            this.ctrShowPerson1.Size = new System.Drawing.Size(1054, 386);
            this.ctrShowPerson1.TabIndex = 0;
            // 
            // frmListLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 768);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrListDdriverLicenses1);
            this.Controls.Add(this.ctrShowPerson1);
            this.Name = "frmListLicenseHistory";
            this.Text = "frmShowLicenseHistory";
            this.Load += new System.EventHandler(this.frmShowLicenseHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrShowPerson ctrShowPerson1;
        private Control.ctrListDdriverLicenses ctrListDdriverLicenses1;
        private System.Windows.Forms.Label label1;
    }
}