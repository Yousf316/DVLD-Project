namespace DVLD_Presentation.Forms.Add
{
    partial class frmAddTestResult
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
            this.label7 = new System.Windows.Forms.Label();
            this.rdPassed = new System.Windows.Forms.RadioButton();
            this.rdFailed = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrTestAppointmentInfo1 = new DVLD_Presentation.Test.Controls.ctrTestAppointmentInfo();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label7.Location = new System.Drawing.Point(41, 631);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 27);
            this.label7.TabIndex = 15;
            this.label7.Text = "Result :";
            // 
            // rdPassed
            // 
            this.rdPassed.AutoSize = true;
            this.rdPassed.Location = new System.Drawing.Point(158, 637);
            this.rdPassed.Name = "rdPassed";
            this.rdPassed.Size = new System.Drawing.Size(56, 21);
            this.rdPassed.TabIndex = 16;
            this.rdPassed.Text = "Pass";
            this.rdPassed.UseVisualStyleBackColor = true;
            // 
            // rdFailed
            // 
            this.rdFailed.AutoSize = true;
            this.rdFailed.Checked = true;
            this.rdFailed.Location = new System.Drawing.Point(240, 637);
            this.rdFailed.Name = "rdFailed";
            this.rdFailed.Size = new System.Drawing.Size(47, 21);
            this.rdFailed.TabIndex = 17;
            this.rdFailed.TabStop = true;
            this.rdFailed.Text = "Fail";
            this.rdFailed.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label8.Location = new System.Drawing.Point(55, 677);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 27);
            this.label8.TabIndex = 18;
            this.label8.Text = "Note :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(134, 677);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(439, 96);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(462, 791);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 39);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(330, 791);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 39);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrTestAppointmentInfo1
            // 
            this.ctrTestAppointmentInfo1.Location = new System.Drawing.Point(0, 12);
            this.ctrTestAppointmentInfo1.Name = "ctrTestAppointmentInfo1";
            this.ctrTestAppointmentInfo1.Size = new System.Drawing.Size(613, 587);
            this.ctrTestAppointmentInfo1.TabIndex = 20;
            // 
            // frmAddTestResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 852);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ctrTestAppointmentInfo1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rdFailed);
            this.Controls.Add(this.rdPassed);
            this.Controls.Add(this.label7);
            this.Name = "frmAddTestResult";
            this.Text = "frmAddVisionTestResult";
            this.Load += new System.EventHandler(this.frmAddTestResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdPassed;
        private System.Windows.Forms.RadioButton rdFailed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Test.Controls.ctrTestAppointmentInfo ctrTestAppointmentInfo1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}