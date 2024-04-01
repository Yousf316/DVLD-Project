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

namespace DVLD_Presentation.Applications.Renew_Driving_License
{
    public partial class frmRenewDrivingLicense : Form
    {

       private clsLicense _objOldLicense;
       private int  _RenewLicenseID=-1;
       private clsLicense _objRenewLicense;
        public frmRenewDrivingLicense()
        {
            InitializeComponent();
        }

        private void LoadApplicationDefault()
        {
            lbApplicationDate.Text = clsFormat.DateToShort(DateTime.Now);
            lbIssueDate.Text = clsFormat.DateToShort(DateTime.Now);
            lbCreatedBy.Text = clsGlobal.CurrentUser.GetUserName();
            lbExpirationDate.Text = clsFormat.DateToShort(DateTime.Now.AddYears(_objOldLicense.objLicenseClass.DefaultValidityLength));
            
            lbApplicationFees.Text = clsApplicationType.FindApplicationType((int)clsApplicationType.enApplicationTypes.Renew_Driving_License_Service).GetApplicationFees().ToString();
            lbOldLicenseID.Text = _objOldLicense.LicenseID.ToString();
            lbLicenseFees.Text = _objOldLicense.objLicenseClass.GetClassFees().ToString();
            lbTotalFees.Text = (Convert.ToSingle(lbApplicationFees.Text) + Convert.ToSingle(lbLicenseFees.Text)).ToString();

        }




         private bool _AddnewLocalDrivingLicense(int ApplicationID)
        {
            _objRenewLicense = clsLicense.FindLicense(_objOldLicense.LicenseID);

            if (_objRenewLicense == null)
                return false;

            _objRenewLicense._mode = clsLicense.enMode.AddNew;

            _objRenewLicense.ApplicationID = ApplicationID;
            _objRenewLicense.IssueDate= DateTime.Now;
            _objRenewLicense.IssueReason=(int)clsLicense.enIssuesReasons.Renew;
            _objRenewLicense.ExpirationDate = DateTime.Now.AddYears(_objOldLicense.objLicenseClass.DefaultValidityLength);
            _objRenewLicense.Notes =rtxtNote.Text;
            _objRenewLicense.CreatedByUserID =clsGlobal.CurrentUser.GetUserID();

           if( _objRenewLicense.SaveLicenses())
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
                , clsApplication.enApplicationStatus.Completed, DateTime.Now
                , clsApplicationType.GetApplicationTypeFees(clsApplicationType.enApplicationTypes.Renew_Driving_License_Service)
                , clsGlobal.CurrentUser.GetUserID());


            if(application.SaveApplications())
            {
               return _AddnewLocalDrivingLicense(application.GetApplicationID());
            }else
            {
                MessageBox.Show("Faild Add New Application","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }


        }

        private void ctrLicenseDetailsWithFilter1_OnSerachButton(int obj)
        {
            int LicenseID = obj;

            _objOldLicense = clsLicense.FindLicense(LicenseID);



            if (DateTime.Compare(_objOldLicense.ExpirationDate, DateTime.Now) > 0)
            {
                MessageBox.Show("License its not Expirated Yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
              
            }
            else
            {
                if(_objOldLicense.IsActive)
                {
                    btnRenew.Enabled = true;
                  
                }else
                {
                    MessageBox.Show("License its Unactive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    btnRenew.Enabled = false;
                }
              



            }

            lnkLicneseHistory.Enabled = true;
            LoadApplicationDefault();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkLicneseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmListLicenseHistory licenseHistory = new frmListLicenseHistory(clsApplication.FindApplication(_objOldLicense.ApplicationID).GetApplicantPersonID());
            licenseHistory.ShowDialog();
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseDetails LocalLicense = new frmShowLicenseDetails(_objRenewLicense.LicenseID);
            LocalLicense.ShowDialog();

        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
           if( _AddnewApplicationRenew())
            {
                MessageBox.Show("Renew Succeded , The New Local License ID = " + _objRenewLicense.LicenseID, "Successfuly"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnRenew.Enabled=false;
                lbApplicationID.Text = _objRenewLicense.ApplicationID.ToString();
                lbRenewLicenseID.Text= _objRenewLicense.LicenseID.ToString();
                ctrLicenseDetailsWithFilter1.LockOfFilter();
            }
            else
            {
                MessageBox.Show("Renew FAild ", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
