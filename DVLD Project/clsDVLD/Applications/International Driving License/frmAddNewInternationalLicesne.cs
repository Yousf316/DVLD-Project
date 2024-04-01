using DVLD_Business;
using DVLD_Presentation.International_Driving_Licenses;
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

namespace DVLD_Presentation.Applications.International_Driving_License
{
    public partial class frmAddNewInternationalLicesne : Form
    {
        public frmAddNewInternationalLicesne()
        {
            InitializeComponent();
        }
        private int LocalLicenseID = -1;
        private clsLicense _objLocalLicenseID;
        private void ctrLicenseDetailsWithFilter1_OnSerachButton(int obj)
        {
            this.LocalLicenseID = obj;
            _objLocalLicenseID = clsLicense.FindLicense(this.LocalLicenseID);
                if (clsInternationalLicense.IsThereInernationalLicenseWithLocalLicense(this.LocalLicenseID))
            {
                btnIssue.Enabled = false;
                MessageBox.Show("There is Already International License with Local License ID = " + this.LocalLicenseID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                btnIssue.Enabled = true;

            }

            if(_objLocalLicenseID.LicenseClassID !=3)
            {
                btnIssue.Enabled = false;
                MessageBox.Show("License class should be 3 " + this.LocalLicenseID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            lnkLicneseHistory.Enabled = true;
            ctrInternationalApplicationInfo1.LoadApplicationDefualtInfo(this.LocalLicenseID);
        }

        private void frmAddNewInternationalLicesne_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.LocalLicenseID == -1)
            {
                return;
            }
            else
            {
                if(ctrInternationalApplicationInfo1.AddNewInternationalDrivingLicense(this.LocalLicenseID))
                {
                    lnkShowInternationalLicense.Enabled = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrInternationalApplicationInfo1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lnkShowInternationalLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowInternationalDrivingLicenseDetails drivingLicenseDetails = new frmShowInternationalDrivingLicenseDetails(ctrInternationalApplicationInfo1.objInternationalLicense.InternationalLicenseID);
            drivingLicenseDetails.ShowDialog();
        }

        private void lnkLicneseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmListLicenseHistory listLicenseHistory = new frmListLicenseHistory(ctrLicenseDetailsWithFilter1.objLicense.objDriver.PersonID);
            listLicenseHistory.ShowDialog();
        }
    }
}
