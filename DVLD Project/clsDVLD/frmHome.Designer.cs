namespace DVLD_Presentation
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.surviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.relaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalDrivingLiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.detainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(60, 60);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applaToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.driverToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.currentUserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1156, 68);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applaToolStripMenuItem
            // 
            this.applaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.surviceToolStripMenuItem,
            this.toolStripMenuItem1,
            this.manageApplicationsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.detainLicensesToolStripMenuItem,
            this.manageApToolStripMenuItem,
            this.manageTestTypesToolStripMenuItem});
            this.applaToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.icons8_test_pulsar_color_961;
            this.applaToolStripMenuItem.Name = "applaToolStripMenuItem";
            this.applaToolStripMenuItem.Size = new System.Drawing.Size(140, 64);
            this.applaToolStripMenuItem.Text = "Application";
            this.applaToolStripMenuItem.Click += new System.EventHandler(this.applaToolStripMenuItem_Click);
            // 
            // surviceToolStripMenuItem
            // 
            this.surviceToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.surviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.renewToolStripMenuItem,
            this.toolStripMenuItem3,
            this.replaceToolStripMenuItem,
            this.toolStripMenuItem4,
            this.relaseToolStripMenuItem,
            this.reToolStripMenuItem});
            this.surviceToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.IssueDrivingLicense_32;
            this.surviceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.surviceToolStripMenuItem.Name = "surviceToolStripMenuItem";
            this.surviceToolStripMenuItem.Size = new System.Drawing.Size(229, 38);
            this.surviceToolStripMenuItem.Text = "Driving Licenses Services";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicenseToolStripMenuItem,
            this.internationalLicenseToolStripMenuItem});
            this.newToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.icons8_taxi_license_32;
            this.newToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(305, 38);
            this.newToolStripMenuItem.Text = "New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            this.localLicenseToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.icons8_driving_license_30;
            this.localLicenseToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.localLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            this.localLicenseToolStripMenuItem.Size = new System.Drawing.Size(197, 36);
            this.localLicenseToolStripMenuItem.Text = "Local License";
            this.localLicenseToolStripMenuItem.Click += new System.EventHandler(this.localLicenseToolStripMenuItem_Click);
            // 
            // internationalLicenseToolStripMenuItem
            // 
            this.internationalLicenseToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.icons8_world_ios_16_filled_16;
            this.internationalLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(197, 36);
            this.internationalLicenseToolStripMenuItem.Text = "International License";
            this.internationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.internationalLicenseToolStripMenuItem_Click);
            // 
            // renewToolStripMenuItem
            // 
            this.renewToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.taxi_license_32;
            this.renewToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.renewToolStripMenuItem.Name = "renewToolStripMenuItem";
            this.renewToolStripMenuItem.Size = new System.Drawing.Size(305, 38);
            this.renewToolStripMenuItem.Text = "Renew Driving License";
            this.renewToolStripMenuItem.Click += new System.EventHandler(this.renewToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(302, 6);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.icons8_driving_license_30;
            this.replaceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(305, 38);
            this.replaceToolStripMenuItem.Text = "Replacement for Lost or Damage License";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(302, 6);
            // 
            // relaseToolStripMenuItem
            // 
            this.relaseToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.icons8_palm_up_hand_32;
            this.relaseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.relaseToolStripMenuItem.Name = "relaseToolStripMenuItem";
            this.relaseToolStripMenuItem.Size = new System.Drawing.Size(305, 38);
            this.relaseToolStripMenuItem.Text = "Release Detain Driving License";
            this.relaseToolStripMenuItem.Click += new System.EventHandler(this.relaseToolStripMenuItem_Click);
            // 
            // reToolStripMenuItem
            // 
            this.reToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.icons8_test_32;
            this.reToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reToolStripMenuItem.Name = "reToolStripMenuItem";
            this.reToolStripMenuItem.Size = new System.Drawing.Size(305, 38);
            this.reToolStripMenuItem.Text = "Retake Test";
            this.reToolStripMenuItem.Click += new System.EventHandler(this.reToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(226, 6);
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicensesToolStripMenuItem,
            this.internationalDrivingLiceToolStripMenuItem});
            this.manageApplicationsToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.icons8_test_pulsar_color_32;
            this.manageApplicationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(229, 38);
            this.manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // localDrivingLicensesToolStripMenuItem
            // 
            this.localDrivingLicensesToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.icons8_driving_license_30;
            this.localDrivingLicensesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.localDrivingLicensesToolStripMenuItem.Name = "localDrivingLicensesToolStripMenuItem";
            this.localDrivingLicensesToolStripMenuItem.Size = new System.Drawing.Size(243, 36);
            this.localDrivingLicensesToolStripMenuItem.Text = "Local Driving Licenses";
            this.localDrivingLicensesToolStripMenuItem.Click += new System.EventHandler(this.localDrivingLicensesToolStripMenuItem_Click);
            // 
            // internationalDrivingLiceToolStripMenuItem
            // 
            this.internationalDrivingLiceToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.icons8_world_ios_16_filled_16;
            this.internationalDrivingLiceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.internationalDrivingLiceToolStripMenuItem.Name = "internationalDrivingLiceToolStripMenuItem";
            this.internationalDrivingLiceToolStripMenuItem.Size = new System.Drawing.Size(243, 36);
            this.internationalDrivingLiceToolStripMenuItem.Text = "International Driving Licenses";
            this.internationalDrivingLiceToolStripMenuItem.Click += new System.EventHandler(this.internationalDrivingLiceToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(226, 6);
            // 
            // detainLicensesToolStripMenuItem
            // 
            this.detainLicensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainLicensesToolStripMenuItem,
            this.detainLicenseToolStripMenuItem});
            this.detainLicensesToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.icons8_hand_pulsar_color_32;
            this.detainLicensesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            this.detainLicensesToolStripMenuItem.Size = new System.Drawing.Size(229, 38);
            this.detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manageDetainLicensesToolStripMenuItem
            // 
            this.manageDetainLicensesToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.icons8_test_pulsar_color_16;
            this.manageDetainLicensesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageDetainLicensesToolStripMenuItem.Name = "manageDetainLicensesToolStripMenuItem";
            this.manageDetainLicensesToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.manageDetainLicensesToolStripMenuItem.Text = "Manage Detained Licenses";
            this.manageDetainLicensesToolStripMenuItem.Click += new System.EventHandler(this.manageDetainLicensesToolStripMenuItem_Click);
            // 
            // detainLicenseToolStripMenuItem
            // 
            this.detainLicenseToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.icons8_hand_pulsar_color_16;
            this.detainLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            this.detainLicenseToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.detainLicenseToolStripMenuItem.Text = "Detain License";
            this.detainLicenseToolStripMenuItem.Click += new System.EventHandler(this.detainLicenseToolStripMenuItem_Click);
            // 
            // manageApToolStripMenuItem
            // 
            this.manageApToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.ic4ons8_test_32;
            this.manageApToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageApToolStripMenuItem.Name = "manageApToolStripMenuItem";
            this.manageApToolStripMenuItem.Size = new System.Drawing.Size(229, 38);
            this.manageApToolStripMenuItem.Text = "Manage Application Types";
            this.manageApToolStripMenuItem.Click += new System.EventHandler(this.manageApToolStripMenuItem_Click);
            // 
            // manageTestTypesToolStripMenuItem
            // 
            this.manageTestTypesToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.icons8_test_passed_32;
            this.manageTestTypesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            this.manageTestTypesToolStripMenuItem.Size = new System.Drawing.Size(229, 38);
            this.manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            this.manageTestTypesToolStripMenuItem.Click += new System.EventHandler(this.manageTestTypesToolStripMenuItem_Click);
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.team;
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(115, 64);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // driverToolStripMenuItem
            // 
            this.driverToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.driver;
            this.driverToolStripMenuItem.Name = "driverToolStripMenuItem";
            this.driverToolStripMenuItem.Size = new System.Drawing.Size(115, 64);
            this.driverToolStripMenuItem.Text = "Drivers";
            this.driverToolStripMenuItem.Click += new System.EventHandler(this.driverToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.dedicated_hosting;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(107, 64);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // currentUserToolStripMenuItem
            // 
            this.currentUserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserInfoToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.currentUserToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.icons8_user_settings_96;
            this.currentUserToolStripMenuItem.Name = "currentUserToolStripMenuItem";
            this.currentUserToolStripMenuItem.Size = new System.Drawing.Size(169, 64);
            this.currentUserToolStripMenuItem.Text = "Account Settings";
            // 
            // currentUserInfoToolStripMenuItem
            // 
            this.currentUserInfoToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.icons8_account_pulsar_color_32;
            this.currentUserInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            this.currentUserInfoToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.currentUserInfoToolStripMenuItem.Text = "Current User Info";
            this.currentUserInfoToolStripMenuItem.Click += new System.EventHandler(this.currentUserInfoToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.changePasswordToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.icons8_password_gradient_32;
            this.changePasswordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.icons8_logout_32;
            this.logOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 510);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem surviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem relaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalDrivingLiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDetainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
    }
}