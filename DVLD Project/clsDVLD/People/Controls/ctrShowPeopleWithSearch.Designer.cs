namespace DVLD_Presentation
{
    partial class ctrShowPeopleWithSearch
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
            this.pnlSearchPerson = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbFinds = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrShowPerson1 = new DVLD_Presentation.ctrShowPerson();
            this.pnlSearchPerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSearchPerson
            // 
            this.pnlSearchPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchPerson.Controls.Add(this.button2);
            this.pnlSearchPerson.Controls.Add(this.button1);
            this.pnlSearchPerson.Controls.Add(this.txtSearch);
            this.pnlSearchPerson.Controls.Add(this.cmbFinds);
            this.pnlSearchPerson.Controls.Add(this.label1);
            this.pnlSearchPerson.Location = new System.Drawing.Point(3, 7);
            this.pnlSearchPerson.Name = "pnlSearchPerson";
            this.pnlSearchPerson.Size = new System.Drawing.Size(1034, 119);
            this.pnlSearchPerson.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::DVLD_Presentation.Properties.Resources.person_manAddPerson;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(642, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 66);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::DVLD_Presentation.Properties.Resources.person_mansearch;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(563, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 66);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(301, 58);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(241, 24);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbFinds
            // 
            this.cmbFinds.FormattingEnabled = true;
            this.cmbFinds.Items.AddRange(new object[] {
            "PersonID",
            "National No"});
            this.cmbFinds.Location = new System.Drawing.Point(134, 58);
            this.cmbFinds.Name = "cmbFinds";
            this.cmbFinds.Size = new System.Drawing.Size(161, 24);
            this.cmbFinds.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label1.Location = new System.Drawing.Point(17, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filter By:";
            // 
            // ctrShowPerson1
            // 
            this.ctrShowPerson1.Location = new System.Drawing.Point(3, 132);
            this.ctrShowPerson1.Name = "ctrShowPerson1";
            this.ctrShowPerson1.Size = new System.Drawing.Size(1051, 445);
            this.ctrShowPerson1.TabIndex = 0;
            this.ctrShowPerson1.Load += new System.EventHandler(this.ctrShowPerson1_Load);
            // 
            // ctrShowPeopleWithSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSearchPerson);
            this.Controls.Add(this.ctrShowPerson1);
            this.Name = "ctrShowPeopleWithSearch";
            this.Size = new System.Drawing.Size(1051, 570);
            this.Load += new System.EventHandler(this.ctrShowPeopleWithSearch_Load);
            this.pnlSearchPerson.ResumeLayout(false);
            this.pnlSearchPerson.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrShowPerson ctrShowPerson1;
        private System.Windows.Forms.Panel pnlSearchPerson;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbFinds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
