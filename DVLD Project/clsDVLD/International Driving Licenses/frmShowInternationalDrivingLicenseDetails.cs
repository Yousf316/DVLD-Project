using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.International_Driving_Licenses
{
    public partial class frmShowInternationalDrivingLicenseDetails : Form
    {
        private int _InternationalLicenseID = -1;
        public frmShowInternationalDrivingLicenseDetails(int InternationalLicenseID)
        {
            InitializeComponent();

            _InternationalLicenseID = InternationalLicenseID;

        }

        private void frmShowInternationalDrivingLicenseDetails_Load(object sender, EventArgs e)
        {
            ctrImternationalLicenseDetails1.LoadLicenseInfo(_InternationalLicenseID);
        }
    }
}
