using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business;
using DVLD_Presentation.Classes;
using DVLD_Presentation.Forms.Add;
using DVLD_Presentation.Licenses;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Presentation.Forms.Managers
{
    public partial class frmManageLocalDrivingLicenseApplication : Form
    {
        enum enMode
        {
            OnlyNumber, None
        }
        
        string ColumnName { get; set; }

        enMode _mode = enMode.None;


        
        public frmManageLocalDrivingLicenseApplication()
        {
            InitializeComponent();
             
        }

        private void RefreshTable()
        {
            dataGridView1.DataSource = clsLocalDrivingLicenseApplication.GetAllLDLApplications();
            RefreRecordCount();
        }

        private void RefreRecordCount()
        {
         lbRecordsCount.Text =  dataGridView1.RowCount.ToString();
        }

        private int CurrentApplicationID()
        {
            return  clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(CurrentRecordID()).GetApplicationID();

        }


        private void CheckLiceseIssue()
        {


            if(clsLicense.IsLicenseExsitsByApplicationID(CurrentApplicationID()))
            {
                issueToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = true;
            }
            else
            {
                issueToolStripMenuItem.Enabled = true;
                showLicenseToolStripMenuItem.Enabled = false;
            }

        }
        
       

        private int CurrentRecordID()
        {
           return (int)dataGridView1.CurrentRow.Cells[0].Value;
        }

        private void contextMenuStrip()
        {
            string Text = (string)dataGridView1.CurrentRow.Cells["Status"].Value;

            
           sTsmSechduleTests.Enabled= (Text != "Cancelled")? true:false;
            sechduleTStreet.Enabled = false;
            sechduleTWritten.Enabled = false;
            sechduleTVision.Enabled = false;

            if(Text =="Completed")
            {
                cancelApplicationToolStripMenuItem.Enabled = false;
                deleteApplicationToolStripMenuItem.Enabled = false;
                editeToolStripMenuItem.Enabled = false;
            }
            else
            {
                cancelApplicationToolStripMenuItem.Enabled = true;
                deleteApplicationToolStripMenuItem.Enabled = true;
                editeToolStripMenuItem.Enabled = true;

            }

            if(clsTestAppointment.IsExists(CurrentRecordID(),(int)clsTestType.enclsTestTypes.VisionTest))
            {
                editeToolStripMenuItem.Enabled = false;

            }
          

        }

        private void CheckPassedTest()
        {
            issueToolStripMenuItem.Enabled = false;
            showLicenseToolStripMenuItem.Enabled = false;

            int Result = (int)dataGridView1.CurrentRow.Cells["PassedTestCount"].Value;

            if (Result == 0)
            {
                sechduleTVision.Enabled = true;
            }
            else if (Result == 1)
                {
                    sechduleTWritten.Enabled = true;

                }
                else if (Result == 2)
                {
                    sechduleTStreet.Enabled = true;

                }
                else if (Result == 3)
                {

                sTsmSechduleTests.Enabled = false;
                CheckLiceseIssue();

            }
        }



        private void frmManageLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            cmbFinds.SelectedIndex= 0;
            Task.WaitAll();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmAddNewLDLicense frmAddNew = new frmAddNewLDLicense();
            frmAddNew.ShowDialog();
            RefreshTable();
        }

        private void editeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewLDLicense frmAddNew = new frmAddNewLDLicense( CurrentRecordID());
            frmAddNew.ShowDialog();
            RefreshTable();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

            contextMenuStrip();

            CheckPassedTest();


        }


        private void cmbFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            Task task = Task.Run(() =>
            {
                this.Invoke(new Action(() => RefreshTable()));
            });
            _mode = enMode.None;
            txtSearch.Visible = false;
            comboBox1.Visible = false;
            switch ( cmbFinds.SelectedItem.ToString())
            {
                case "None":
                   return;

                case "L.D.LApplicationID":
                    _mode = enMode.OnlyNumber;
                    txtSearch.Visible = true;
                    ColumnName = "LocalDrivingLicenseApplicationID";
                break;

                case "NationalNo":
                    ColumnName = "NationalNo";
                    txtSearch.Visible = true;

                    break;

                case "Status":
                    ColumnName = "Status";
                    comboBox1.Visible = true;
                    comboBox1.SelectedIndex = 0;
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

                dataGridView1.DataSource = clsLocalDrivingLicenseApplication.GetLDLApplicationsInfo(ColumnName, txtSearch.Text);

            }
            else
            {
                dataGridView1.DataSource = clsLocalDrivingLicenseApplication.GetLDLApplicationsInfo(ColumnName, txtSearch.Text);
            }

           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchOperator();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex != 0)
            dataGridView1.DataSource = clsLocalDrivingLicenseApplication.GetLDLApplicationsInfo(ColumnName, comboBox1.SelectedItem.ToString());
            else
                RefreshTable();
        }

        private void showApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowDLApplication frmShow = new frmShowDLApplication(CurrentRecordID());
            frmShow.ShowDialog();

            RefreshTable();


        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsApplication.UpdateApplicationStatus(CurrentApplicationID(),clsApplication.enApplicationStatus.Cancelled);
            RefreshTable();
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication.DeleteLDLApplicationRecord(CurrentRecordID());
            RefreshTable();

        }

        private void sechduleTVision_Click(object sender, EventArgs e)
        {
            frmListAppointments frmAddVision = new frmListAppointments(CurrentRecordID(),clsTestType.enclsTestTypes.VisionTest);
            frmAddVision.ShowDialog();
            RefreshTable();
        }

        private void sechduleTWritten_Click(object sender, EventArgs e)
        {
            frmListAppointments frmAddVision = new frmListAppointments(CurrentRecordID(), clsTestType.enclsTestTypes.WrittenTest);
            frmAddVision.ShowDialog();
            RefreshTable();
        }

        private void sechduleTStreet_Click(object sender, EventArgs e)
        {
            frmListAppointments frmAddVision = new frmListAppointments(CurrentRecordID(), clsTestType.enclsTestTypes.StreetTest);
            frmAddVision.ShowDialog();
            RefreshTable();
        }

        private void issueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewLicense newLicense = new frmAddNewLicense(CurrentRecordID());
            newLicense.ShowDialog();
            RefreshTable();
        }

        private void showPersonLicensesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID=clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(CurrentRecordID()).GetApplicantPersonID();
           frmListLicenseHistory frmList=new frmListLicenseHistory(PersonID);
            frmList.ShowDialog();
            RefreshTable();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDriverLicenseID= clsLicense.GetLicenseIDByApplicationID(CurrentApplicationID());
            frmShowLicenseDetails frmShow=new frmShowLicenseDetails(LocalDriverLicenseID);
            frmShow.ShowDialog();
            RefreshTable();
        }
    }
}
