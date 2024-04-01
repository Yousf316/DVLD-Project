using DVLD_Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business;
using DVLD_Business;
using DVLD_Presentation.Licenses;

namespace DVLD_Presentation.Controls
{
    public partial class ctrShowLDLApplicationInfo : UserControl
    {

        int PersonID {  get; set; } 
        int LicenseID {  get; set; } 
        public ctrShowLDLApplicationInfo()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        
        public bool GetDLApplicationInfo(int LDLApplicaionID)
        {
            clsLocalDrivingLicenseApplication objLocalDriving = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(LDLApplicaionID);

            if (objLocalDriving == null)
                return false;

            lbDLAppId.Text = objLocalDriving.GetLocalDrivingLicenseApplicationID().ToString();

            clsLicenseClass Licenseclass = clsLicenseClass.FindLicenseClass(objLocalDriving.GetLicenseClassID());


            lbLicenseClass.Text=Licenseclass.GetClassName();

            lbPassedTests.Text = clsTest.GetApplicantTestResult(LDLApplicaionID).ToString()+"/3";

            GetApplicationInfo(objLocalDriving.GetApplicationID());

             LicenseID = clsLicense.GetLicenseIDByApplicationID(objLocalDriving.GetApplicationID());

            if(LicenseID !=-1)
               {
                lnkShowLicenseInfo.Enabled = true;
            }
            else
            {
                lnkShowLicenseInfo.Enabled = false;
            }

            return true;
            
        }
        private bool GetApplicationInfo(int ApplicaionID)
        {
                clsApplication application=clsApplication.FindApplication(ApplicaionID);
            if (application == null)
                return false;

                lbApplicatonID.Text=application.GetApplicationID().ToString();
            lbFees.Text = application.GetPaidFees().ToString();
            lbType.Text = application.GetApplicationTypeTitle();

            if (application.GetApplicationStatus() == 1)
            {
                lbStatus.Text = "New";
            }else if(application.GetApplicationStatus() == 2)
            {
                lbStatus.Text = "Cancelled";
            }
            else
            {
                lbStatus.Text = "Completed";
            }

            lbApplicant.Text = application.GetFullNameApplicatn();

            lbCreatedBy.Text = application.GetUserNameofCratedBy(application.GetCreatedUserID());

            lbStatusDate.Text=application.GetLastStatusDate().ToString("d");

            lbDate.Text=application.GetApplicationDate().ToString("d");

            lnkViewPersonInfo.Enabled = true;

            PersonID = application.GetApplicantPersonID();
            return true;
            
        }

        private void ctrShowLDLApplicationInfo_Load(object sender, EventArgs e)
        {

        }

        private void lnkViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonDetails personDetails = new frmShowPersonDetails(PersonID);
            personDetails.ShowDialog();
        }

        private void lnkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseDetails frmShow = new frmShowLicenseDetails(LicenseID);
            frmShow.ShowDialog(); 
        }
    }
}
