namespace DVLD_Presentation.Forms
{
    partial class frmShowDLApplication
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
            this.ctrShowLDLApplicationInfo1 = new DVLD_Presentation.Controls.ctrShowLDLApplicationInfo();
            this.SuspendLayout();
            // 
            // ctrShowLDLApplicationInfo1
            // 
            this.ctrShowLDLApplicationInfo1.Location = new System.Drawing.Point(12, 12);
            this.ctrShowLDLApplicationInfo1.Name = "ctrShowLDLApplicationInfo1";
            this.ctrShowLDLApplicationInfo1.Size = new System.Drawing.Size(1034, 505);
            this.ctrShowLDLApplicationInfo1.TabIndex = 0;
            // 
            // frmShowDLApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 524);
            this.Controls.Add(this.ctrShowLDLApplicationInfo1);
            this.Name = "frmShowDLApplication";
            this.Text = "frmShowDLApplication";
            this.Load += new System.EventHandler(this.frmShowDLApplication_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrShowLDLApplicationInfo ctrShowLDLApplicationInfo1;
    }
}