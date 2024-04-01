using DVLD_Business;
using DVLD_Presentation.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Applications.International_Driving_License.Control
{
    public partial class ctrInternationalApplicationInfo : UserControl
    {
        public ctrInternationalApplicationInfo()
        {
            InitializeComponent();
        }

        public clsInternationalLicense objInternationalLicense;

        private float Fees = -1;

        public  void LoadApplicationDefualtInfo(int LocalLicenseID)
        {
            lbApplicationDate.Text = clsFormat.DateToShort( DateTime.Now);
            lbIssueDate.Text =clsFormat.DateToShort( DateTime.Now);
            lbExpirationDate.Text = clsFormat.DateToShort(DateTime.Now.AddYears(1));

            Fees = clsApplicationType.FindApplicationType((int)clsApplicationType.enApplicationTypes.New_International_License).GetApplicationFees();
            
            lbFees.Text = Fees.ToString();  
            lbCreatedBy.Text = clsGlobal.CurrentUser.GetUserName();
            lbLocalLicenseID.Text= LocalLicenseID.ToString();
            

        }
        

        private int  AddNewApplicationForInternational(int ApplicantID)
        {

            clsApplication application = new clsApplication();

            Fees = clsApplicationType.FindApplicationType((int)clsApplicationType.enApplicationTypes.New_International_License).GetApplicationFees();


            application.SetCoulmns(ApplicantID, DateTime.Now, (int)clsApplicationType.enApplicationTypes.New_International_License,
                clsApplication.enApplicationStatus.Completed, DateTime.Now, Fees, clsGlobal.CurrentUser.GetUserID());
            application.SaveApplications();

            return application.GetApplicationID();

        }

        public  bool AddNewInternationalDrivingLicense(int LocalLicenseID)
        {

            clsLicense objLocalLicense = clsLicense.FindLicense(LocalLicenseID);

            if(objLocalLicense == null) 
                return false;

            int ApplicantID = clsApplication.FindApplication(objLocalLicense.ApplicationID).GetApplicantPersonID();


            if (objLocalLicense.IsActive ==false)
            {
                MessageBox.Show("The Local Driving License is unactive","Unvalid",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

            



            int ApplicationID = AddNewApplicationForInternational(ApplicantID);

            objInternationalLicense =new clsInternationalLicense();


            objInternationalLicense.SetColumnsValue(ApplicationID, objLocalLicense.DriverID,objLocalLicense.LicenseID,DateTime.Now
                ,DateTime.Now.AddYears(1),true,clsGlobal.CurrentUser.GetUserID());

            if(objInternationalLicense.SaveInternationalLicenses())
            {
                MessageBox.Show("Create New License Succssfuly, ID Number is = " + objInternationalLicense.InternationalLicenseID, "Succeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadApplicationInfoByInternaLicenseID(objInternationalLicense.InternationalLicenseID);
                return true;
            }
            else
            {
                MessageBox.Show("Create New License Faild", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



        }

         public  void LoadApplicationInfoByInternaLicenseID(int InternaLicenseID)
        {
            objInternationalLicense = clsInternationalLicense.FindInternationalLicense(InternaLicenseID);

            if(objInternationalLicense == null)
            {
                MessageBox.Show("Theres No International License ID " + InternaLicenseID);
                return;
            }

            lbApplicationDate.Text = clsFormat.DateToShort( objInternationalLicense.objApplication.GetApplicationDate());
            lbIssueDate.Text = clsFormat.DateToShort(objInternationalLicense.IssueDate);
            lbExpirationDate.Text =clsFormat.DateToShort( objInternationalLicense.ExpirationDate);



            lbFees.Text = objInternationalLicense.objApplication.GetPaidFees().ToString();
            lbCreatedBy.Text =clsUser.FindUser( objInternationalLicense.CreatedByUserID).GetUserName();
            lbLocalLicenseID.Text = objInternationalLicense.IssuedUsingLocalLicenseID.ToString();

            lbInternationalLicenseID.Text = objInternationalLicense.InternationalLicenseID.ToString();

            lbApplicatonID.Text = objInternationalLicense.ApplicationID.ToString()  ;

        }



    }
}
