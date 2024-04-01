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

namespace DVLD_Presentation
{
    public partial class frmAddNewLDLicense : Form
    {

        int ApplicationID { get; set; }
        int ApplicantPersonID { get; set; }
        DateTime ApplicationDate { get; set; }
        int ApplicationTypeID { get; set; }
        clsLicenseClass objLicenseClass { get; set; }
        int? LocalDrivingLicenseApplicationID { get; set; }
      
        float PaidFees { get; set; }
        int CreatedByUserID { get; set; }

        clsLocalDrivingLicenseApplication LDL { get; set; }
        public frmAddNewLDLicense(int? LocalDrivingLicenseApplicationID =null)
        {
            InitializeComponent();
            CreatedByUserID = clsGlobal.CurrentUser.GetUserID();
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            ApplicationTypeID = 1;
        }

        private void ctrShowPeopleWithSearch1_OnButtonSetPerson(int PersonID)
        {
            btnNext.Enabled = true;
            ApplicantPersonID = PersonID;
        }

        private void SetCmbAppTypes()
        {
            DataTable dt = clsLicenseClass.GetAllLicenseClasses();

            foreach (DataRow dr in dt.Rows)
            {
                cmbAppTypes.Items.Add(dr[1]);
            }

            cmbAppTypes.SelectedIndex = 2;

        }

        private void GetDefaultInfo()
        {
             
            clsUser user = clsUser.FindUser(CreatedByUserID);
            clsApplicationType ApplicationType =clsApplicationType.FindApplicationType(ApplicationTypeID);
            
            if (user == null||ApplicationType ==null)
                return;



            lbCreatedUser.Text = user.GetUserName();


            lbAppFees.Text = ApplicationType.GetApplicationFees().ToString();
            PaidFees = ApplicationType.GetApplicationFees();


            lbAppDate.Text = DateTime.Now.ToString("dd/M/yyyy");

            ApplicationDate = DateTime.Now;


        }

          private void GetApplicationInfo()
        {
            LDL = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID ??-1);

            if (LDL == null)
                return;

            clsLicenseClass licenseClass = clsLicenseClass.FindLicenseClass(LDL.GetLicenseClassID());


            lbCreatedUser.Text = LDL.GetCreatedUserID().ToString();
            lbAppFees.Text = LDL.GetPaidFees().ToString();
            lbAppID.Text= LDL.GetLocalDrivingLicenseApplicationID().ToString();
            lbAppDate.Text = LDL.GetApplicationDate().ToString("d");
            cmbAppTypes.SelectedText = licenseClass.GetClassName();
            ctrShowPeopleWithSearch1.SetPersonInfoLock(LDL.GetApplicantPersonID());
        }

        private void SetApplicationInfo()
        {
            LDL = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID ?? -1);

            if (LDL == null)
            LDL =new clsLocalDrivingLicenseApplication();

            if (clsApplication.GetApplicantInfo(ApplicantPersonID, objLicenseClass.LicenseClassID) == 1 || clsApplication.GetApplicantInfo(ApplicantPersonID, objLicenseClass.LicenseClassID) == 3)
            {
                MessageBox.Show("Applicant Already have Local Driving License Application");
                return;
            }

            if (ctrShowPeopleWithSearch1.obPerson.Age < objLicenseClass.MinimumAllowedAge)
            {
                MessageBox.Show("Applicant Age is under minimim Allow Age");

                return;
            }
           

            LDL.SetCoulmns(ApplicantPersonID,
                ApplicationDate, ApplicationTypeID, clsApplication.enApplicationStatus.New, ApplicationDate, PaidFees, CreatedByUserID);
            LDL.SetLLicenseClassID(objLicenseClass.LicenseClassID);
            LDL.SaveLocalDrivingLicenseApplications();

            LocalDrivingLicenseApplicationID = LDL.GetLocalDrivingLicenseApplicationID();
        }

        private void CheckGetinfo()
        {
            if (!LocalDrivingLicenseApplicationID.HasValue)
            {
                GetDefaultInfo();
                lbSubjectTitle.Text = "Add New Application";
                tabUser.Enabled = false;
                btnNext.Enabled = false;

            }
            else
            {
                GetApplicationInfo();
                lbSubjectTitle.Text = "Update Application";
                tabUser.Enabled = true;
                btnNext.Enabled = true;
            }

        }
        private void frmAddNewLDLicense_Load(object sender, EventArgs e)
        {
            SetCmbAppTypes();
            CheckGetinfo();
        }

        private void cmbAppTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            objLicenseClass = clsLicenseClass.FindLicenseClass(cmbAppTypes.SelectedItem.ToString());

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabUser.Enabled = true;
            btnSave.Enabled = true;
            tabctr1.SelectTab(1);

           this.ApplicantPersonID= ctrShowPeopleWithSearch1.obPerson.GetPersonID();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SetApplicationInfo();
            CheckGetinfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
