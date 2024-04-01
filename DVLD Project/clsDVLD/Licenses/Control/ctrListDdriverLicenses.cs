using DVLD_Business;
using DVLD_Presentation.International_Driving_Licenses;
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
    public partial class ctrListDdriverLicenses : UserControl
    {

        private int DriverID=-1;
        public ctrListDdriverLicenses()
        {
            InitializeComponent();
        }
         
        private void _LoadListLocalLicense()
        {
            dgvLocalDrivingLicenses.DataSource = clsDriver.GetAllLocalLicensesByDriverID(DriverID);
        }
        private void _LoadListInternationallLicense()
        {
           dgvInternationalLicense.DataSource=clsDriver.GetAllInternationalicesnsesByDriverID(DriverID) ; 
        }

        public void LoadListLicenses(int DriverID)
        {
            this.DriverID = DriverID;

            _LoadListLocalLicense();
            _LoadListInternationallLicense();
        }
        private void ctrListPersonLicenses_Load(object sender, EventArgs e)
        {

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLicenseDetails licenseDetails = new frmShowLicenseDetails((int)dgvLocalDrivingLicenses.CurrentRow.Cells[0].Value);
            licenseDetails.ShowDialog();
        }

        private void showDetalisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowInternationalDrivingLicenseDetails drivingLicenseDetails = new frmShowInternationalDrivingLicenseDetails((int)dgvInternationalLicense.CurrentRow.Cells[0].Value);
                drivingLicenseDetails.ShowDialog();
        }
    }
}
