using DVLD_Presentation.Applications.International_Driving_License;
using DVLD_Presentation.Applications.Renew_Driving_License;
using DVLD_Presentation.Applications.Replacment_Driving_License;
using DVLD_Presentation.Classes;
using DVLD_Presentation.Detain_Licenses;
using DVLD_Presentation.Drivers;
using DVLD_Presentation.Forms;
using DVLD_Presentation.Forms.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation
{
    public partial class frmHome : Form
    {
      

        frmManageUsers frmManageUsers1 { get; set; }
        frmManagePeople frmManagePeople1{ get; set; }

        frmManageTestTypes frmManageTestTypes { get; set; }

        frmAddNewLDLicense frmAddNew { get; set; }

        frmManageLocalDrivingLicenseApplication frmManageLocal {get; set; }

        frmLogin login;

        frmListDrivers frmListDrivers;

        frmAddNewInternationalLicesne newInternationalLicesne;

        frmDetainLicense frmdetainLicense;

        frmListDetainedLicenses listDetainedLicenses;

        frmDetainedReleease detainedReleease;

        frmListInternationalLicenses listInternationalLicenses; 

        frmRenewDrivingLicense RenewDrivingLicense; 
        frmAddReplacementDrivingLicense ReplacementDrivingLicense; 


        public frmHome(frmLogin login)
        {
            InitializeComponent();

            this.login = login;
          
            Callnewfunctions();
        }

        private void Callnewfunctions()
        {
             frmManageUsers1 = new frmManageUsers();
           frmManagePeople1 = new frmManagePeople();
         frmManageTestTypes = new frmManageTestTypes();

            frmAddNew = new frmAddNewLDLicense( );

         frmManageLocal = new frmManageLocalDrivingLicenseApplication();

            frmListDrivers= new frmListDrivers();

            newInternationalLicesne = new frmAddNewInternationalLicesne();

             frmdetainLicense = new frmDetainLicense();

             listDetainedLicenses = new frmListDetainedLicenses();
            detainedReleease = new frmDetainedReleease();

            listInternationalLicenses = new frmListInternationalLicenses();

            RenewDrivingLicense =new frmRenewDrivingLicense();

            ReplacementDrivingLicense = new frmAddReplacementDrivingLicense();

        }


        private void applaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
            if(frmManagePeople1.IsDisposed)
                frmManagePeople1 = new frmManagePeople();

            frmManagePeople1.MdiParent = this;
            frmManagePeople1.Show();
            
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmManageUsers1.IsDisposed)
                frmManageUsers1 = new frmManageUsers();

            frmManageUsers1.MdiParent = this;
            frmManageUsers1.Show();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserInfo frmuserinfo=new frmShowUserInfo(clsGlobal.CurrentUser.GetUserID());
            frmuserinfo.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmchangePassword frmchange = new frmchangePassword(clsGlobal.CurrentUser.GetUserID());
            frmchange.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        frmManageApplicationTypes frmmanageApplicationTypes = new frmManageApplicationTypes();

        private void manageApToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmmanageApplicationTypes.IsDisposed)
                frmmanageApplicationTypes = new frmManageApplicationTypes();

            frmmanageApplicationTypes.MdiParent = this;
            frmmanageApplicationTypes.Show();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (frmManageTestTypes.IsDisposed)
                frmManageTestTypes = new frmManageTestTypes();

            frmManageTestTypes.MdiParent = this; 
            frmManageTestTypes.Show();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (ReplacementDrivingLicense.IsDisposed)
                ReplacementDrivingLicense = new frmAddReplacementDrivingLicense();

            ReplacementDrivingLicense.MdiParent = this;
            ReplacementDrivingLicense.Show();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmAddNew.IsDisposed)
                frmAddNew = new frmAddNewLDLicense( );

            frmAddNew.MdiParent = this;
            frmAddNew.Show();
        }

        private void localDrivingLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmManageLocal.IsDisposed)
                frmManageLocal = new frmManageLocalDrivingLicenseApplication();

            frmManageLocal.MdiParent = this;
            frmManageLocal.Show();
        }

        private void driverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmListDrivers.IsDisposed)
                frmListDrivers = new frmListDrivers();

            frmListDrivers.MdiParent = this;
            frmListDrivers.Show();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (newInternationalLicesne.IsDisposed)
                newInternationalLicesne = new frmAddNewInternationalLicesne();

            newInternationalLicesne.MdiParent = this;
            newInternationalLicesne.Show();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (frmdetainLicense.IsDisposed)
                 frmdetainLicense= new frmDetainLicense();

            frmdetainLicense.MdiParent = this;
            frmdetainLicense.Show();
        }

        private void internationalDrivingLiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("not implemented yet");

            if (listInternationalLicenses.IsDisposed)
                listInternationalLicenses = new frmListInternationalLicenses();

            listInternationalLicenses.MdiParent = this;
            listInternationalLicenses.Show();
        }

        private void manageDetainLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listDetainedLicenses.IsDisposed)
                listDetainedLicenses = new frmListDetainedLicenses();

            listDetainedLicenses.MdiParent = this;
            listDetainedLicenses.Show();
        }

      

        private void relaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (detainedReleease.IsDisposed)
                detainedReleease = new frmDetainedReleease();

            
            detainedReleease.ShowDialog();
        }

        private void renewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

                 if (RenewDrivingLicense.IsDisposed)
                RenewDrivingLicense = new frmRenewDrivingLicense();

            RenewDrivingLicense.MdiParent = this;
            RenewDrivingLicense.Show();
        }

        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmManageLocal.IsDisposed)
                frmManageLocal = new frmManageLocalDrivingLicenseApplication();

            frmManageLocal.MdiParent = this;
            frmManageLocal.Show();
        }
    }
}
