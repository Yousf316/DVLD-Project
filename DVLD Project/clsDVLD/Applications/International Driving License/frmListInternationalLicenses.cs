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
    public partial class frmListInternationalLicenses : Form
    {
        public frmListInternationalLicenses()
        {
            InitializeComponent();
        }

        enum enMode { None, OnlyNumber }

        private enMode _mode = enMode.None;

        private string ColumnName;


        private void _SearchOperator()
        {

            if (_mode == enMode.OnlyNumber)
            {

                if (!int.TryParse(txtSearch.Text, out int ID))
                {
                    txtSearch.Text = "";
                    return;
                }

                dataGridView1.DataSource = clsInternationalLicense.GetInternationalLicenseInfo(ColumnName, txtSearch.Text);

            }
            else
            {
                dataGridView1.DataSource = clsInternationalLicense.GetInternationalLicenseInfo(ColumnName, txtSearch.Text);
            }
            _RecordCount();


        }
        private void _ColumnNameSelected()
        {
            txtSearch.Visible = false;
            comboBox1.Visible = false;

            ColumnName = cmbFinds.SelectedItem.ToString().Replace(" ", "");

            if (cmbFinds.SelectedIndex == 0)
            {
                _RefreshTable();
            }
            else if (cmbFinds.SelectedIndex < 4)
            {
                txtSearch.Visible = true;
                _mode = enMode.OnlyNumber;
            }
            else if (cmbFinds.SelectedIndex == 4)

            {
                txtSearch.Visible = true;
                _mode = enMode.None;
            }
            else
            {
                txtSearch.Visible = false;
                comboBox1.Visible = true;
                comboBox1.SelectedIndex = 0;

            }


        }



        private void _RefreshTable()
        {
            dataGridView1.DataSource = clsInternationalLicense.GetAllInternationalLicenses();
            _RecordCount();
        }
        private void _RecordCount()
        {
            lbRecordsCount.Text = dataGridView1.RowCount.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                _RefreshTable();

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                dataGridView1.DataSource = clsInternationalLicense.GetInternationalLicenseInfo(ColumnName, "1");

            }
            else
            {
                dataGridView1.DataSource = clsInternationalLicense.GetInternationalLicenseInfo(ColumnName, "0");

            }

            _RecordCount();

        }


        private void frmListInternationalLicenses_Load(object sender, EventArgs e)
        {
            _RefreshTable();
            cmbFinds.SelectedIndex = 0;
        }

        private void cmbFinds_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ColumnNameSelected();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _SearchOperator();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            frmAddNewInternationalLicesne newInternationalLicesne = new frmAddNewInternationalLicesne();
            newInternationalLicesne.ShowDialog();
            _RefreshTable();

        }

        private int CurrentPersonID()
        {
            return clsDriver.FindDriver((int)dataGridView1.CurrentRow.Cells["DriverID"].Value).PersonID;
        }
         private int CurrentInternataionalLicenseID()
        {
            return ((int)dataGridView1.CurrentRow.Cells["InternationalLicenseID"].Value);
        }

        private void showPersonDetaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonDetails personDetails = new frmShowPersonDetails(CurrentPersonID());
            personDetails.ShowDialog();

        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowInternationalDrivingLicenseDetails frmShowInternational = new frmShowInternationalDrivingLicenseDetails(CurrentInternataionalLicenseID());
            frmShowInternational.ShowDialog();
        }

        private void showPersonLicesneHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListLicenseHistory licenseHistory = new frmListLicenseHistory(CurrentPersonID());
            licenseHistory.ShowDialog();
        }
    }
}
