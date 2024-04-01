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

namespace DVLD_Presentation.Detain_Licenses
{
    public partial class frmListDetainedLicenses : Form
    {
        public frmListDetainedLicenses()
        {
            InitializeComponent();
        }

        enum enMode { None,OnlyNumber}

       private enMode _mode= enMode.None;

       private string ColumnName;

        private void _RefreshTable()
        {
            dataGridView1.DataSource=clsDetainendLicense.GetAllDetaindLicenses();

            _RecordCount();
        }
         private void _RecordCount()
        {
           lbRecordsCount.Text= dataGridView1.RowCount.ToString();
        }

        private void frmManageDetainedLicenses_Load(object sender, EventArgs e)
        {
            _RefreshTable();
            cmbFinds.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmDetainLicense frmDetain = new frmDetainLicense();
            frmDetain.ShowDialog();
            _RefreshTable();

        }

        private void _SearchOperator()
        {

            if (_mode == enMode.OnlyNumber)
            {

                if (!int.TryParse(txtSearch.Text, out int ID))
                {
                    txtSearch.Text = "";
                    return;
                }

                dataGridView1.DataSource = clsDetainendLicense.GetDetainedLicense(ColumnName, txtSearch.Text);

            }
            else
            {
                dataGridView1.DataSource = clsDetainendLicense.GetDetainedLicense(ColumnName, txtSearch.Text);
            }


        }
        private void _ColumnNameSelected()
        {
            txtSearch.Visible = false;
            comboBox1.Visible = false;

            ColumnName = cmbFinds.SelectedItem.ToString().Replace(" ","");

            if(cmbFinds.SelectedIndex ==0)
            {
                _RefreshTable();
            }
            else if(cmbFinds.SelectedIndex  <3)
            {
                txtSearch.Visible = true;
                _mode = enMode.OnlyNumber;  
            }else if(cmbFinds.SelectedIndex ==3)
            
            {
                txtSearch.Visible = true;
                _mode = enMode.None;
            }else
            {
                txtSearch.Visible = false;
                comboBox1.Visible = true;
                comboBox1.SelectedIndex = 0;

            }


        }


        private void cmbFinds_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ColumnNameSelected();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(comboBox1.SelectedIndex == 0)
            {
                _RefreshTable();

            }else if(comboBox1.SelectedIndex ==1)
            {
                dataGridView1.DataSource = clsDetainendLicense.GetDetainedLicense(ColumnName,"1");

            }else
            {
                dataGridView1.DataSource = clsDetainendLicense.GetDetainedLicense(ColumnName, "0");

            }



        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _SearchOperator();
        }

        private int _LicenseIDRecord()
        {
            return (int)dataGridView1.CurrentRow.Cells[1].Value;
        }

        private int _PersonIDRecord()
        {
            clsLicense objLicense= clsLicense.FindLicense(_LicenseIDRecord());

           clsDriver objDriver = clsDriver.FindDriver(objLicense.DriverID);

            return objDriver.PersonID;
        }

        private int _DetainIDRecord()
        {
            return (int)dataGridView1.CurrentRow.Cells[0].Value;
        }

          private bool _IsReleasRecord()
        {
            return (bool)dataGridView1.CurrentRow.Cells["IsReleased"].Value;
        }

        private void _CheckIsReleased()
        {
            releaseToolStripMenuItem.Enabled = false;
            if (_IsReleasRecord())
            {
                releaseToolStripMenuItem.Enabled = false;
            }
            else
            {
                releaseToolStripMenuItem.Enabled = true;
            }
        }


        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonDetails frmShowPerson=new frmShowPersonDetails(_PersonIDRecord());
            frmShowPerson.ShowDialog();
            _RefreshTable();
        }

        private void cmsLisrDetain_Opening(object sender, CancelEventArgs e)
        {
            _CheckIsReleased();
        }

        private void releaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmDetainedReleease frmDetained = new frmDetainedReleease(_LicenseIDRecord());
            frmDetained.ShowDialog();
            _RefreshTable();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmDetainedReleease frmDetained = new frmDetainedReleease();
            frmDetained.ShowDialog();
            _RefreshTable();
        }
    }
}
