namespace DVLD_Presentation.Detain_Licenses
{
    partial class frmDetainLicense
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFineFees = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbLicenseID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbDetainDate = new System.Windows.Forms.Label();
            this.lbDetainID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lnkLicneseHistory = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDetain = new System.Windows.Forms.Button();
            this.ctrLicenseDetailsWithFilter1 = new DVLD_Presentation.Licenses.Control.ctrLicenseDetailsWithFilter();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFineFees);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lbCreatedBy);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbLicenseID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbDetainDate);
            this.groupBox1.Controls.Add(this.lbDetainID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.groupBox1.Location = new System.Drawing.Point(24, 689);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(895, 222);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detain Information";
            // 
            // txtFineFees
            // 
            this.txtFineFees.Location = new System.Drawing.Point(205, 174);
            this.txtFineFees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFineFees.Name = "txtFineFees";
            this.txtFineFees.Size = new System.Drawing.Size(145, 34);
            this.txtFineFees.TabIndex = 9;
            this.txtFineFees.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(80, 177);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 27);
            this.label10.TabIndex = 8;
            this.label10.Text = "Fine Fees :";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Location = new System.Drawing.Point(570, 126);
            this.lbCreatedBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(48, 27);
            this.lbCreatedBy.TabIndex = 7;
            this.lbCreatedBy.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(438, 126);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 27);
            this.label8.TabIndex = 6;
            this.label8.Text = "Created By :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "Detain Date :";
            // 
            // lbLicenseID
            // 
            this.lbLicenseID.AutoSize = true;
            this.lbLicenseID.Location = new System.Drawing.Point(575, 66);
            this.lbLicenseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLicenseID.Name = "lbLicenseID";
            this.lbLicenseID.Size = new System.Drawing.Size(48, 27);
            this.lbLicenseID.TabIndex = 5;
            this.lbLicenseID.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 27);
            this.label6.TabIndex = 4;
            this.label6.Text = "License ID :";
            // 
            // lbDetainDate
            // 
            this.lbDetainDate.AutoSize = true;
            this.lbDetainDate.Location = new System.Drawing.Point(201, 126);
            this.lbDetainDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDetainDate.Name = "lbDetainDate";
            this.lbDetainDate.Size = new System.Drawing.Size(48, 27);
            this.lbDetainDate.TabIndex = 3;
            this.lbDetainDate.Text = "N/A";
            // 
            // lbDetainID
            // 
            this.lbDetainID.AutoSize = true;
            this.lbDetainID.Location = new System.Drawing.Point(201, 66);
            this.lbDetainID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDetainID.Name = "lbDetainID";
            this.lbDetainID.Size = new System.Drawing.Size(48, 27);
            this.lbDetainID.TabIndex = 1;
            this.lbDetainID.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detain ID :";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Enabled = false;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.linkLabel1.Location = new System.Drawing.Point(304, 934);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(251, 23);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Show License License Details";
            // 
            // lnkLicneseHistory
            // 
            this.lnkLicneseHistory.AutoSize = true;
            this.lnkLicneseHistory.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lnkLicneseHistory.Location = new System.Drawing.Point(49, 934);
            this.lnkLicneseHistory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkLicneseHistory.Name = "lnkLicneseHistory";
            this.lnkLicneseHistory.Size = new System.Drawing.Size(253, 23);
            this.lnkLicneseHistory.TabIndex = 12;
            this.lnkLicneseHistory.TabStop = true;
            this.lnkLicneseHistory.Text = "Show License License History";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, 926);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 42);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDetain
            // 
            this.btnDetain.Enabled = false;
            this.btnDetain.Location = new System.Drawing.Point(780, 926);
            this.btnDetain.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(139, 42);
            this.btnDetain.TabIndex = 10;
            this.btnDetain.Text = "Detain";
            this.btnDetain.UseVisualStyleBackColor = true;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // ctrLicenseDetailsWithFilter1
            // 
            this.ctrLicenseDetailsWithFilter1.Location = new System.Drawing.Point(14, 68);
            this.ctrLicenseDetailsWithFilter1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ctrLicenseDetailsWithFilter1.Name = "ctrLicenseDetailsWithFilter1";
            this.ctrLicenseDetailsWithFilter1.Size = new System.Drawing.Size(1052, 615);
            this.ctrLicenseDetailsWithFilter1.TabIndex = 0;
            this.ctrLicenseDetailsWithFilter1.OnSerachButton += new System.Action<int>(this.ctrLicenseDetailsWithFilter1_OnSerachButton);
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 990);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lnkLicneseHistory);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrLicenseDetailsWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmDetainLicense";
            this.Text = "Detain License";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Licenses.Control.ctrLicenseDetailsWithFilter ctrLicenseDetailsWithFilter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbLicenseID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbDetainDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbDetainID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel lnkLicneseHistory;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.TextBox txtFineFees;
        private System.Windows.Forms.Label label10;
    }
}