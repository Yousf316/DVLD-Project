using DVLD_Business;
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

namespace DVLD_Presentation.Licenses.Control
{
    public partial class ctrLicenseDetails : UserControl
    {
        public ctrLicenseDetails()
        {
            InitializeComponent();
        }

        public void LoadLicenseInfo(int LicenseID)
        {
            clsLicense license = clsLicense.FindLicense(LicenseID);
           
            if(license == null)
            {
                return;
            }
            clsApplication Application = clsApplication.FindApplication(license.ApplicationID);
            clsPerson Person = clsPerson.FindPerson(Application.GetApplicantPersonID());

            lbLicenseID.Text = license.LicenseID.ToString();
            lbName.Text=Person.GetFullName();
            lbGender.Text= Person.GetGenderName();
            lbActive.Text = (license.IsActive == false) ? "No" : "Yes";
            lbClassName. Text = clsLicenseClass.FindLicenseClass( license.LicenseClassID).GetClassName();
            lbDetained.Text = (clsDetainendLicense.IsLicenseDetained(LicenseID))?"Yes":"No";
            lbIssueDate.Text=clsFormat.DateToShort( license.IssueDate).ToString();
            lbExpirationDate.Text=clsFormat.DateToShort( license.ExpirationDate).ToString();
            lbDateOfBirth.Text= clsFormat.DateToShort(Person.GetBirthDate()).ToString();
            lbDriverID.Text = license.DriverID.ToString();
            lbNationalNo.Text=Person.GetPersonID().ToString();

            lbNote.Text = (license.Notes != "") ? license.Notes : "No Notes";

            picPersonImage.ImageLocation = (Person.GetImagePath()=="")? (Person.GetGenderName()=="Male")? "C:\\Users\\USERZ\\Desktop\\DVLD Project\\Icons\\person_man.png" : "C:\\Users\\USERZ\\Desktop\\DVLD Project\\Icons\\person_girl.png" : Person.GetImagePath();

            lbIssueReason.Text=license.ReasonTypes.ToString();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
