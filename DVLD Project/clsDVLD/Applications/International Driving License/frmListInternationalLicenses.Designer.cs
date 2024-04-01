namespace DVLD_Presentation.Applications.International_Driving_License
{
    partial class frmListInternationalLicenses
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbFinds = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicesneHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.comboBox1.Location = new System.Drawing.Point(278, 85);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 21);
            this.comboBox1.TabIndex = 41;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(278, 85);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(179, 20);
            this.txtSearch.TabIndex = 40;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbFinds
            // 
            this.cmbFinds.FormattingEnabled = true;
            this.cmbFinds.Items.AddRange(new object[] {
            "All",
            "International License ID",
            "NationalNo",
            "DriverID",
            "Full Name",
            "IsActive"});
            this.cmbFinds.Location = new System.Drawing.Point(135, 85);
            this.cmbFinds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFinds.Name = "cmbFinds";
            this.cmbFinds.Size = new System.Drawing.Size(139, 21);
            this.cmbFinds.TabIndex = 38;
            this.cmbFinds.SelectedIndexChanged += new System.EventHandler(this.cmbFinds_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label1.Location = new System.Drawing.Point(35, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 37;
            this.label1.Text = "Filter By:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(917, 449);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 41);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbRecordsCount
            // 
            this.lbRecordsCount.AutoSize = true;
            this.lbRecordsCount.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbRecordsCount.Location = new System.Drawing.Point(145, 458);
            this.lbRecordsCount.Name = "lbRecordsCount";
            this.lbRecordsCount.Size = new System.Drawing.Size(37, 19);
            this.lbRecordsCount.TabIndex = 35;
            this.lbRecordsCount.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(37, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "# Records : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(31, 122);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1046, 308);
            this.dataGridView1.TabIndex = 33;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetaiToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonLicesneHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(226, 92);
            // 
            // showPersonDetaiToolStripMenuItem
            // 
            this.showPersonDetaiToolStripMenuItem.Name = "showPersonDetaiToolStripMenuItem";
            this.showPersonDetaiToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.showPersonDetaiToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetaiToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetaiToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Presentation.Properties.Resources.International_32;
            this.pictureBox1.Location = new System.Drawing.Point(994, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // showPersonLicesneHistoryToolStripMenuItem
            // 
            this.showPersonLicesneHistoryToolStripMenuItem.Name = "showPersonLicesneHistoryToolStripMenuItem";
            this.showPersonLicesneHistoryToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.showPersonLicesneHistoryToolStripMenuItem.Text = "Show Person Licesne History";
            this.showPersonLicesneHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicesneHistoryToolStripMenuItem_Click);
            // 
            // frmListInternationalLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 530);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbFinds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmListInternationalLicenses";
            this.Text = "frmListInternationalLicenses";
            this.Load += new System.EventHandler(this.frmListInternationalLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbFinds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicesneHistoryToolStripMenuItem;
    }
}