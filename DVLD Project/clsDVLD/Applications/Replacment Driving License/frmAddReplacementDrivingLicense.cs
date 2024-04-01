using DVLD_Business;
using DVLD_Presentation.Classes;
using DVLD_Presentation.Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Applications.Replacment_Driving_License
{
    public partial class frmAddReplacementDrivingLicense : Form
    {
        public frmAddReplacementDrivingLicense()
        {
            InitializeComponent();
        }

        

        clsApplicationType.enApplicationTypes _enApplicationType = clsApplicationType.enApplicationTypes.Replacement_for_a_Damaged_Driving_License;
       private clsLicense _objOldLicense;
       private clsLicense _objNewLicense;

       

        private void frmAddReplacementDrivingLicense_Load(object sender, EventArgs e)
        {
         rdDamagedLicense.Checked = true;
                }

        private void rdDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            if(rdDamagedLicense.Checked)
            {
                lbtitle.Text = "Replacement Damaged Driving License";
                _enApplicationType = clsApplicationType.enApplicationTypes.Replacement_for_a_Damaged_Driving_License;
            }
            else
            {
                lbtitle.Text = "Replacement Losted Driving License";
                _enApplicationType = clsApplicationType.enApplicationTypes.Replacement_for_a_Lost_Driving_License;

            }
            LoadApplicationFees();

        }

        private void ctrLicenseDetailsWithFilter1_OnSerachButton(int obj)
        {
            int LicenseID = obj;

            _objOldLicense = clsLicense.FindLicense(LicenseID);

            if( _objOldLicense.IsActive )
            {
                btnReplased.Enabled = true;

            }
            else
            {
                btnReplased.Enabled = false;
            }
            lnkLicneseHistory.Enabled = true;

            LoadDefaultApplicationInfo();
        }

        private void LoadApplicationFees()
        {
            lbApplicationFees.Text = clsApplicationType.GetApplicationTypeFees(_enApplicationType).ToString();

        }

        private void LoadDefaultApplicationInfo()
        {
            lbApplicationDate.Text = clsFormat.DateToShort(DateTime.Now);
            lbApplicationFees.Text = clsApplicationType.GetApplicationTypeFees(_enApplicationType).ToString();
            lbOldLicenseID.Text= _objOldLicense.LicenseID.ToString();
            lbCreatedBy.Text=clsGlobal.CurrentUser.GetUserID().ToString();
            

        }

        private bool _AddnewLocalDrivingLicense(int ApplicationID)
        {
            _objNewLicense = clsLicense.FindLicense(_objOldLicense.LicenseID);

            if (_objNewLicense == null)
                return false;

            _objNewLicense._mode = clsLicense.enMode.AddNew;

            _objNewLicense.ApplicationID = ApplicationID;
            
            _objNewLicense.CreatedByUserID = clsGlobal.CurrentUser.GetUserID();

            if (_enApplicationType == clsApplicationType.enApplicationTypes.Replacement_for_a_Lost_Driving_License)
                _objNewLicense.IssueReason = (int)clsLicense.enIssuesReasons.Rplacement_for_Lost;
            else
                _objNewLicense.IssueReason = (int)clsLicense.enIssuesReasons.Replacement_for_Damaged;



            if (_objNewLicense.SaveLicenses())
            {
                _objOldLicense.IsActive = false;
                _objOldLicense.SaveLicenses();
                return true;
            }

            return false;
        }
        private bool _AddnewApplicationRenew()
        {
            clsApplication application = new clsApplication();

            

            application.SetCoulmns(_objOldLicense.objDriver.PersonID, DateTime.Now, (int)clsApplication.enApplicationType.RenewDrivingLicense
                , clsApplication.enApplicationStatus.New, DateTime.Now
                , clsApplicationType.GetApplicationTypeFees(_enApplicationType)
                , clsGlobal.CurrentUser.GetUserID());


            if (application.SaveApplications())
            {
                return _AddnewLocalDrivingLicense(application.GetApplicationID());
            }
            else
            {
                MessageBox.Show("Faild Add New Application", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


        }

        private void btnReplased_Click(object sender, EventArgs e)
        {
            if(_AddnewApplicationRenew())
            {
                MessageBox.Show("Replacment License ID = " + _objNewLicense.LicenseID.ToString(), "Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbApplicationID.Text = _objNewLicense.ApplicationID.ToString();
                lbReplacedLicenseID.Text=_objNewLicense.LicenseID.ToString();
                btnReplased.Enabled = false;
                ctrLicenseDetailsWithFilter1.LockOfFilter();
                lnlbShowRenewlicense.Enabled = true;
            }
            else
            {
                MessageBox.Show("Faild to Replacment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }




        private void lnkLicneseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmListLicenseHistory licenseHistory = new frmListLicenseHistory(clsApplication.FindApplication(_objOldLicense.ApplicationID).GetApplicantPersonID());
            licenseHistory.ShowDialog();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseDetails LocalLicense = new frmShowLicenseDetails(_objNewLicense.LicenseID);
            LocalLicense.ShowDialog();

        }


    }
}
