namespace DVLD_Presentation.Licenses.Control
{
    partial class ctrLicenseDetailsWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbFilterLicenses = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchLicense = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrLicenseDetails1 = new DVLD_Presentation.Licenses.Control.ctrLicenseDetails();
            this.gbFilterLicenses.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilterLicenses
            // 
            this.gbFilterLicenses.Controls.Add(this.btnSearch);
            this.gbFilterLicenses.Controls.Add(this.txtSearchLicense);
            this.gbFilterLicenses.Controls.Add(this.label1);
            this.gbFilterLicenses.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gbFilterLicenses.Location = new System.Drawing.Point(25, 6);
            this.gbFilterLicenses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFilterLicenses.Name = "gbFilterLicenses";
            this.gbFilterLicenses.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFilterLicenses.Size = new System.Drawing.Size(563, 102);
            this.gbFilterLicenses.TabIndex = 1;
            this.gbFilterLicenses.TabStop = false;
            this.gbFilterLicenses.Text = "Filter Licenses";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Enabled = false;
            this.btnSearch.Image = global::DVLD_Presentation.Properties.Resources.icons8_driving_license_50;
            this.btnSearch.Location = new System.Drawing.Point(431, 40);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 50);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearchLicense
            // 
            this.txtSearchLicense.Location = new System.Drawing.Point(217, 54);
            this.txtSearchLicense.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchLicense.Name = "txtSearchLicense";
            this.txtSearchLicense.Size = new System.Drawing.Size(177, 25);
            this.txtSearchLicense.TabIndex = 1;
            this.txtSearchLicense.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "License ID";
            // 
            // ctrLicenseDetails1
            // 
            this.ctrLicenseDetails1.Location = new System.Drawing.Point(0, 115);
            this.ctrLicenseDetails1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrLicenseDetails1.Name = "ctrLicenseDetails1";
            this.ctrLicenseDetails1.Size = new System.Drawing.Size(896, 392);
            this.ctrLicenseDetails1.TabIndex = 0;
            // 
            // ctrLicenseDetailsWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFilterLicenses);
            this.Controls.Add(this.ctrLicenseDetails1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ctrLicenseDetailsWithFilter";
            this.Size = new System.Drawing.Size(902, 500);
            this.gbFilterLicenses.ResumeLayout(false);
            this.gbFilterLicenses.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrLicenseDetails ctrLicenseDetails1;
        private System.Windows.Forms.GroupBox gbFilterLicenses;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchLicense;
        private System.Windows.Forms.Label label1;
    }
}
