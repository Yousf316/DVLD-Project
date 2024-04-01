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

namespace DVLD_Presentation.Licenses.Control
{
    public partial class ctrLicenseDetailsWithFilter : UserControl
    {
        public ctrLicenseDetailsWithFilter()
        {
            InitializeComponent();
        }

        public clsLicense objLicense;

        public event Action<int> OnSerachButton;
        // Create a protected method to raise the event with a parameter
        protected virtual void _OnSerachButton(int LicenseID)
        {
            Action<int> handler = OnSerachButton;
            if (handler != null)
            {
                handler(LicenseID); // Raise the event with the parameter
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchLicense.Text == "")
                return;


            if (!int.TryParse(txtSearchLicense.Text,out int Text))
            {
                txtSearchLicense.Text = txtSearchLicense.Text.Remove(txtSearchLicense.Text.Length - 1);
            }

            if(txtSearchLicense.Text.Length > 0)
                btnSearch.Enabled = true;
            else
                btnSearch.Enabled = false;
        }

      


        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(txtSearchLicense.Text, out int LicenseID);

            if (clsLicense.IsLicenseExsitsByID(LicenseID))
            {
                ctrLicenseDetails1.LoadLicenseInfo(LicenseID);
                objLicense = clsLicense.FindLicense(LicenseID);

                if (OnSerachButton != null)
                    _OnSerachButton(LicenseID);
            }
           else
                MessageBox.Show("License Is not Exsits","Unvalied",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        public void LockOfFilter(bool Locked=false)
        {
            if (!Locked)
            {
               gbFilterLicenses.Enabled = false;
            }
            else
            {
                gbFilterLicenses.Enabled = true;

            }

        }
        public void LoadLicenseByLicenseID(int LicenseID)
        {

            if (clsLicense.IsLicenseExsitsByID(LicenseID))
            {
                ctrLicenseDetails1.LoadLicenseInfo(LicenseID);
                txtSearchLicense.Text = LicenseID.ToString();
                objLicense =clsLicense.FindLicense(LicenseID);
                LockOfFilter();
            }
            else
                MessageBox.Show("License Is not Exsits", "Unvalied", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
