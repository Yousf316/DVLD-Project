namespace DVLD_Presentation
{
    partial class frmAddUpdatePerson
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
            this.ctrAddPerson1 = new DVLD_Presentation.ctrAddPerson();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrAddPerson1
            // 
            this.ctrAddPerson1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ctrAddPerson1.Location = new System.Drawing.Point(5, 7);
            this.ctrAddPerson1.Name = "ctrAddPerson1";
            this.ctrAddPerson1.Size = new System.Drawing.Size(1171, 678);
            this.ctrAddPerson1.TabIndex = 0;
            this.ctrAddPerson1.DataBack += new DVLD_Presentation.ctrAddPerson.DataBackEventHandler(this.ctrAddPerson1_DataBack);
            this.ctrAddPerson1.OnCloseButton += new System.Action<bool>(this.ctrAddPerson1_OnCloseButton_1);
            this.ctrAddPerson1.OnSaveButton += new System.Action<bool>(this.ctrAddPerson1_OnSaveButton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(434, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add New Person";
            // 
            // frmAddUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 697);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrAddPerson1);
            this.Name = "frmAddUpdatePerson";
            this.Text = "Add Person";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrAddPerson ctrAddPerson1;
        private System.Windows.Forms.Label label1;
    }
}

