using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Licenses
{
    public partial class frmListLicenseHistory : Form
    {
        private int PersonID = -1;
        public frmListLicenseHistory(int PerosnID)
        {
            InitializeComponent();
            PersonID = PerosnID;
        }

        private void _LoadPersonInfo()
        {
            ctrShowPerson1.GetPersonInfo(PersonID);
        }
        private void _LoadListLiceneseofDriver()
        {
            
        ctrListDdriverLicenses1.LoadListLicenses(clsDriver.GetDriverIDByPersonID(PersonID));

                }

        private void frmShowLicenseHistory_Load(object sender, EventArgs e)
        {
            _LoadPersonInfo();
            _LoadListLiceneseofDriver();
        }
    }
}
