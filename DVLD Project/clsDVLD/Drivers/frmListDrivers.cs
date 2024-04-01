using DVLD_Business;
using DVLD_Business;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD_Presentation.Drivers
{
    public partial class frmListDrivers : Form
    {
        public frmListDrivers()
        {
            InitializeComponent();
        }
        enum enMode
        {
            OnlyNumber, None
        }

        string ColumnName { get; set; }

        enMode _mode = enMode.None;


        private void cmbFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTable();
            _mode = enMode.None;
            txtSearch.Visible = false;
            switch (cmbFinds.SelectedItem.ToString())
            {
                case "None":
                    return;

                case "PersonID":
                    _mode = enMode.OnlyNumber;
                    txtSearch.Visible = true;
                    ColumnName = "LocalDrivingLicenseApplicationID";
                    break;

                case "NationalNo":
                    ColumnName = "NationalNo";
                    txtSearch.Visible = true;

                    break;

               

                case "FullName":
                    ColumnName = "FullName";
                    txtSearch.Visible = true;

                    break;


            }

        }


        private void SearchOperator()
        {

            if (_mode == enMode.OnlyNumber)
            {

                if (!int.TryParse(txtSearch.Text, out int PersonID))
                {
                    txtSearch.Text = "";
                    return;
                }

                dgvListDrivers.DataSource = clsDriver.GetDriversInfo(ColumnName, txtSearch.Text);

            }
            else
            {
                dgvListDrivers.DataSource = clsDriver.GetDriversInfo(ColumnName, txtSearch.Text);
            }

            RefreshRecordCount();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchOperator();
        }

        private void RefreshTable()
        {
            dgvListDrivers.DataSource = clsDriver.GetAllDrivers();
            RefreshRecordCount();
        }
        private void RefreshRecordCount()
        {
            lbRecordsCount.Text = dgvListDrivers.RowCount.ToString(); 
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListDrivers_Load(object sender, EventArgs e)
        {
           cmbFinds.SelectedIndex = 0;
        }

        private void showPerosnLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListLicenseHistory licenseDetails = new frmListLicenseHistory((int)dgvListDrivers.CurrentRow.Cells[1].Value);
            licenseDetails.ShowDialog();
        }
    }
}
