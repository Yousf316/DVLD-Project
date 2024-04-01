namespace DVLD_Presentation.Forms
{
    partial class frmUpdateTestTypes
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(176, 404);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 38);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(351, 404);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 38);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(244, 196);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(193, 24);
            this.txtFees.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(244, 131);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 24);
            this.txtName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.Location = new System.Drawing.Point(156, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fees:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.Location = new System.Drawing.Point(156, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.Location = new System.Drawing.Point(73, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Descriprtion:";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(244, 260);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(225, 99);
            this.rtxtDescription.TabIndex = 13;
            this.rtxtDescription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label4.Location = new System.Drawing.Point(156, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 30);
            this.label4.TabIndex = 14;
            this.label4.Text = "ID:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lbID.Location = new System.Drawing.Point(278, 55);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(55, 30);
            this.lbID.TabIndex = 15;
            this.lbID.Text = "N/A";
            // 
            // frmUpdateTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 472);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateTestTypes";
            this.Text = "frmUpdateTestTypes";
            this.Load += new System.EventHandler(this.frmUpdateTestTypes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbID;
    }
}