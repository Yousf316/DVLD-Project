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
    public partial class frmDetainLicense : Form
    {
        public frmDetainLicense()
        {
            InitializeComponent();
        }

        private int LicenseID = -1;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(txtFineFees.Text, out int value))
            {
                txtFineFees.Text = txtFineFees.Text.Remove(txtFineFees.Text.Length - 1);
            }
        }

        private void LoadDetainedInfo()
        {
            lbDetainDate.Text = clsFormat.DateToShort(DateTime.Now);

            lbLicenseID.Text = LicenseID.ToString();

            lbCreatedBy.Text = clsGlobal.CurrentUser.GetUserName();
        }

        private void ctrLicenseDetailsWithFilter1_OnSerachButton(int obj)
        {
            this.LicenseID = obj;

            if (clsDetainendLicense.IsLicenseDetained(this.LicenseID))
            {
                btnDetain.Enabled = false;
                MessageBox.Show("License is Already Detained","Detaiend",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }else
            {
                btnDetain.Enabled = true;
            }
           

            LoadDetainedInfo();

        }

        private void AddNewDetainLicense()
        {
            clsDetainendLicense objDetain = new clsDetainendLicense();

            float.TryParse(txtFineFees.Text, out float FineFees);
            objDetain.SetDetinedColumnValues(LicenseID, DateTime.Now, FineFees, clsGlobal.CurrentUser.GetUserID(), false);

            if(objDetain.SaveDetainedLicenses())
            {
                MessageBox.Show("License Detained ID =" + objDetain.DetainID, "Succeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbDetainID.Text= objDetain.DetainID.ToString();

                btnDetain.Enabled= false;
                ctrLicenseDetailsWithFilter1.LockOfFilter();
            }
            else
            {
                MessageBox.Show("Faild Detaind");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            AddNewDetainLicense();
        }
    }
}
