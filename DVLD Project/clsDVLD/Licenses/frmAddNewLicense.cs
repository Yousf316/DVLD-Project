using DVLD_Business;
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

namespace DVLD_Presentation.Licenses
{
    public partial class frmAddNewLicense : Form
    {
        private int LocalDriverLicenseApplication = -1;
        public frmAddNewLicense(int LocalDriverLicenseApplication=-1)
        {
            InitializeComponent();
            this.LocalDriverLicenseApplication = LocalDriverLicenseApplication;
        }

        private void frmAddNewLicense_Load(object sender, EventArgs e)
        {
            ctrShowLDLApplicationInfo1.GetDLApplicationInfo(LocalDriverLicenseApplication);
        }


        private int AddNewDriver(int PersonID)
        {

            clsDriver driver = new clsDriver();



            driver.SetColumnsValue(PersonID, clsGlobal.CurrentUser.GetUserID(), DateTime.Now);

            driver.SaveDrivers();

            return driver.DriverID;


        }

        private int CheckDriverID()
        {

            int PersonID = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(LocalDriverLicenseApplication).GetApplicantPersonID();

            int DriverID = clsDriver.GetDriverIDByPersonID(PersonID);

            if (DriverID == -1)
            {
                DriverID = AddNewDriver(PersonID);
            }

            return DriverID;

        }

      


        private int AddNewLicese()
        {

            clsLicense license = new clsLicense();

            int DriverID = CheckDriverID();

            clsLocalDrivingLicenseApplication clsLocal = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(LocalDriverLicenseApplication);

            if (!clsLicense.ThereIsLicenseActive(DriverID, clsLocal.GetLicenseClassID()))
            {
                clsLicenseClass licenseClass = clsLicenseClass.FindLicenseClass(clsLocal.GetLicenseClassID());
                license.SetColumnsValue(clsLocal.GetApplicationID(), DriverID, clsLocal.GetLicenseClassID(), DateTime.Now
                    , DateTime.Now.AddYears(licenseClass.DefaultValidityLength), richTextBox1.Text, licenseClass.GetClassFees()
                    , true, (int)clsLicense.enIssuesReasons.FirstTime, clsGlobal.CurrentUser.GetUserID());

              if(  license.SaveLicenses())
                {
                    clsLocal.ChangeStatus(clsApplication.enApplicationStatus.Completed);
                    clsLocal.UpdateApplicationStatus();
                }
            }
            

           return license.LicenseID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int LicenseID= AddNewLicese();

            if(LicenseID != -1)
            {
                MessageBox.Show("Add Successfuly License ID = " + LicenseID);
            }
            else
            {
                MessageBox.Show("Faild");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
