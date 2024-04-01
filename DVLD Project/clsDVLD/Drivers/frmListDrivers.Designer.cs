namespace DVLD_Presentation.Drivers
{
    partial class frmListDrivers
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
            this.components = new System.ComponentModel.Container();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListDrivers = new System.Windows.Forms.DataGridView();
            this.cmbFinds = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPerosnLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDrivers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(299, 80);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(208, 24);
            this.txtSearch.TabIndex = 40;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label1.Location = new System.Drawing.Point(15, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 27);
            this.label1.TabIndex = 37;
            this.label1.Text = "Filter By:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(883, 529);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(170, 51);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbRecordsCount
            // 
            this.lbRecordsCount.AutoSize = true;
            this.lbRecordsCount.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbRecordsCount.Location = new System.Drawing.Point(143, 539);
            this.lbRecordsCount.Name = "lbRecordsCount";
            this.lbRecordsCount.Size = new System.Drawing.Size(43, 24);
            this.lbRecordsCount.TabIndex = 35;
            this.lbRecordsCount.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(17, 539);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "# Records : ";
            // 
            // dgvListDrivers
            // 
            this.dgvListDrivers.AllowUserToAddRows = false;
            this.dgvListDrivers.AllowUserToDeleteRows = false;
            this.dgvListDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListDrivers.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvListDrivers.Location = new System.Drawing.Point(10, 125);
            this.dgvListDrivers.Name = "dgvListDrivers";
            this.dgvListDrivers.ReadOnly = true;
            this.dgvListDrivers.RowHeadersWidth = 51;
            this.dgvListDrivers.RowTemplate.Height = 26;
            this.dgvListDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvListDrivers.Size = new System.Drawing.Size(1043, 379);
            this.dgvListDrivers.TabIndex = 33;
            // 
            // cmbFinds
            // 
            this.cmbFinds.FormattingEnabled = true;
            this.cmbFinds.Items.AddRange(new object[] {
            "None",
            "NationalNo",
            "FullName"});
            this.cmbFinds.Location = new System.Drawing.Point(132, 80);
            this.cmbFinds.Name = "cmbFinds";
            this.cmbFinds.Size = new System.Drawing.Size(161, 24);
            this.cmbFinds.TabIndex = 41;
            this.cmbFinds.SelectedIndexChanged += new System.EventHandler(this.cmbFind_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPerosnLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(265, 28);
            // 
            // showPerosnLicenseHistoryToolStripMenuItem
            // 
            this.showPerosnLicenseHistoryToolStripMenuItem.Name = "showPerosnLicenseHistoryToolStripMenuItem";
            this.showPerosnLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.showPerosnLicenseHistoryToolStripMenuItem.Text = "Show Perosn License History";
            this.showPerosnLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPerosnLicenseHistoryToolStripMenuItem_Click);
            // 
            // frmListDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 596);
            this.Controls.Add(this.cmbFinds);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvListDrivers);
            this.Name = "frmListDrivers";
            this.Text = "frmListDrivers";
            this.Load += new System.EventHandler(this.frmListDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDrivers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvListDrivers;
        private System.Windows.Forms.ComboBox cmbFinds;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPerosnLicenseHistoryToolStripMenuItem;
    }
}