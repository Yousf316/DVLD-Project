using DVLD_Business;
using DVLD_Presentation.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.International_Driving_Licenses.Controls
{
    public partial class ctrImternationalLicenseDetails : UserControl
    {

       public clsInternationalLicense objLicense;

        public void LoadLicenseInfo(int LicenseID)
        {
            objLicense = clsInternationalLicense.FindInternationalLicense(LicenseID);

            if(objLicense ==null)
            {
                MessageBox.Show("License is not Exsits","Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbCreatedBy.Text=clsUser.FindUser( objLicense.CreatedByUserID).GetUserName();
            lbExpirationDate.Text=clsFormat.DateToShort(objLicense.ExpirationDate);
            lbIssueDate.Text = clsFormat.DateToShort(objLicense.IssueDate);
            lbLocalLicenseID.Text=objLicense.IssuedUsingLocalLicenseID.ToString();
            lbInternationalLicenseID.Text = objLicense.InternationalLicenseID.ToString();
            lbDriverID.Text = objLicense.DriverID.ToString();

            lbIsActive.Text = (objLicense.IsActive) ? "Yes" : "No";

            pictureBox1.ImageLocation = clsPerson.FindPerson(objLicense.objApplication.GetApplicantPersonID()).GetImagePath();

            if (pictureBox1.ImageLocation == "")
                pictureBox1.ImageLocation = clsPerson.FindPerson(objLicense.objApplication.GetApplicantPersonID()).GetDefaultImage();


        }





        public ctrImternationalLicenseDetails()
        {
            InitializeComponent();
        }


    }
}
