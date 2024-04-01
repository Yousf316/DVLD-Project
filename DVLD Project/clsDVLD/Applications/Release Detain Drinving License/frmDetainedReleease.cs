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

namespace DVLD_Presentation.Detain_Licenses
{
    public partial class frmDetainedReleease : Form
    {
        private int _LicenseID=-1;
        private int _DetainID=-1;
        private clsDetainendLicense _objDetainedLicense;
        public frmDetainedReleease(int LicenseID=-1)
        {
            InitializeComponent();
            this._LicenseID = LicenseID;
        }

        private float ApplicationFees()
        {
            return clsApplicationType.FindApplicationType((int)clsApplicationType.enApplicationTypes.Release_Detained_Driving_Licsense).GetApplicationFees();
        }
        private void _LoadDetainedLicense(int DetainID)
        {

            this._objDetainedLicense =  clsDetainendLicense.FindDetainendLicense(DetainID);

            if(this._objDetainedLicense == null )
            {
                MessageBox.Show("Detain ID ="+DetainID+" is not Found","Not Found",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            btnRelease.Enabled= (ctrLicenseDetailsWithFilter1.objLicense.IsDetain);

            lbDetainID.Text =this._objDetainedLicense.DetainID.ToString();
            lbLicenseID.Text=this._objDetainedLicense.LicenseID.ToString();
            lbDetainDate.Text = clsFormat.DateToShort(this._objDetainedLicense.DetainDate);
            lbReleaseAppID.Text = (this._objDetainedLicense.ReleaseApplicationID != -1) ? this._objDetainedLicense.ReleaseApplicationID.ToString() : "N/A";
            lbFineFees.Text= this._objDetainedLicense.FineFees.ToString();
            lbApplicationFees.Text= ApplicationFees().ToString();
            lbTotalFees.Text = (ApplicationFees()+ this._objDetainedLicense.FineFees).ToString();
            lbCreatedBy.Text = clsUser.FindUser(this._objDetainedLicense.CreatedByUserID).GetUserName();

        }
        
        private int _AddNewReleaseApplication()
        {
            clsApplication application=new clsApplication();
            application.SetCoulmns(ctrLicenseDetailsWithFilter1.objLicense.objDriver.PersonID, DateTime.Now,
               (int) clsApplication.enApplicationType.ReleaseDetainedDrivingLicsense,
                clsApplication.enApplicationStatus.Completed, DateTime.Now, ApplicationFees(), clsGlobal.CurrentUser.GetUserID());

            if(application.SaveApplications())
            {
                return application.GetApplicationID();
            }
            else
            {
                return -1;
            }

        }
         private bool _ReleaseDetainDrivingLicense(int ApplicationID)
        {
          _objDetainedLicense.SetReleaseColumnValues(DateTime.Now,clsGlobal.CurrentUser.GetUserID(), ApplicationID);

            _objDetainedLicense.IsReleased= true;
            return _objDetainedLicense.SaveDetainedLicenses();
            

            

        }

        private void _LoadLicenseByID(int LicenseID)
        {
            if(clsDetainendLicense.IsLicenseDetained(LicenseID))
            {
                ctrLicenseDetailsWithFilter1.LoadLicenseByLicenseID(LicenseID);
                _LoadDetainedLicense(clsDetainendLicense.GetDetainIDByDetainedLicense(LicenseID));
            }
            else
            {
                return;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDetainedReleease_Load(object sender, EventArgs e)
        {
            if(this._LicenseID!=-1)
            {
                _LoadLicenseByID(_LicenseID);
            }


        }

        private void ctrLicenseDetailsWithFilter1_OnSerachButton(int obj)
        {
            this._LicenseID = obj;

            this._DetainID = clsDetainendLicense.GetDetainIDByDetainedLicense(this._LicenseID); 

            if(this._DetainID !=-1 )
            {

                _LoadDetainedLicense(_DetainID);
                ctrLicenseDetailsWithFilter1.LockOfFilter();

            }

        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            int ApplicationID = _AddNewReleaseApplication();

            if (ApplicationID!=-1)
            {
                if(_ReleaseDetainDrivingLicense(ApplicationID))
                {
                    MessageBox.Show("Release Succeded", "Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbReleaseAppID.Text = ApplicationID.ToString();
                    btnRelease.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Release Faild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("Create new Application Faild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
