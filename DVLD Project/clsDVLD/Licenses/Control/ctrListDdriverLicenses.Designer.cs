namespace DVLD_Presentation.Licenses.Control
{
    partial class ctrListDdriverLicenses
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvLocalDrivingLicenses = new System.Windows.Forms.DataGridView();
            this.cmsLocalDriver = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvInternationalLicense = new System.Windows.Forms.DataGridView();
            this.cmsInternational = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetalisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenses)).BeginInit();
            this.cmsLocalDriver.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicense)).BeginInit();
            this.cmsInternational.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(838, 311);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvLocalDrivingLicenses);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(830, 282);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Local";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvLocalDrivingLicenses
            // 
            this.dgvLocalDrivingLicenses.AllowUserToAddRows = false;
            this.dgvLocalDrivingLicenses.AllowUserToDeleteRows = false;
            this.dgvLocalDrivingLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalDrivingLicenses.ContextMenuStrip = this.cmsLocalDriver;
            this.dgvLocalDrivingLicenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLocalDrivingLicenses.Location = new System.Drawing.Point(3, 3);
            this.dgvLocalDrivingLicenses.Name = "dgvLocalDrivingLicenses";
            this.dgvLocalDrivingLicenses.ReadOnly = true;
            this.dgvLocalDrivingLicenses.RowHeadersWidth = 51;
            this.dgvLocalDrivingLicenses.RowTemplate.Height = 26;
            this.dgvLocalDrivingLicenses.Size = new System.Drawing.Size(824, 276);
            this.dgvLocalDrivingLicenses.TabIndex = 0;
            // 
            // cmsLocalDriver
            // 
            this.cmsLocalDriver.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsLocalDriver.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem});
            this.cmsLocalDriver.Name = "cmsLocalDriver";
            this.cmsLocalDriver.Size = new System.Drawing.Size(165, 28);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvInternationalLicense);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(830, 282);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "International";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvInternationalLicense
            // 
            this.dgvInternationalLicense.AllowUserToAddRows = false;
            this.dgvInternationalLicense.AllowUserToDeleteRows = false;
            this.dgvInternationalLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicense.ContextMenuStrip = this.cmsInternational;
            this.dgvInternationalLicense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInternationalLicense.Location = new System.Drawing.Point(3, 3);
            this.dgvInternationalLicense.Name = "dgvInternationalLicense";
            this.dgvInternationalLicense.ReadOnly = true;
            this.dgvInternationalLicense.RowHeadersWidth = 51;
            this.dgvInternationalLicense.RowTemplate.Height = 26;
            this.dgvInternationalLicense.Size = new System.Drawing.Size(824, 276);
            this.dgvInternationalLicense.TabIndex = 0;
            // 
            // cmsInternational
            // 
            this.cmsInternational.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsInternational.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetalisToolStripMenuItem});
            this.cmsInternational.Name = "cmsInternational";
            this.cmsInternational.Size = new System.Drawing.Size(211, 56);
            // 
            // showDetalisToolStripMenuItem
            // 
            this.showDetalisToolStripMenuItem.Name = "showDetalisToolStripMenuItem";
            this.showDetalisToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.showDetalisToolStripMenuItem.Text = "Show Detalis";
            this.showDetalisToolStripMenuItem.Click += new System.EventHandler(this.showDetalisToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 343);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Licenses";
            // 
            // ctrListDdriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrListDdriverLicenses";
            this.Size = new System.Drawing.Size(857, 359);
            this.Load += new System.EventHandler(this.ctrListPersonLicenses_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenses)).EndInit();
            this.cmsLocalDriver.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicense)).EndInit();
            this.cmsInternational.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvLocalDrivingLicenses;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvInternationalLicense;
        private System.Windows.Forms.ContextMenuStrip cmsLocalDriver;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsInternational;
        private System.Windows.Forms.ToolStripMenuItem showDetalisToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
