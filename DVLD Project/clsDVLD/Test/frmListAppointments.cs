using DVLD_Business;
using DVLD_Presentation.Forms.Add;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD_Business.clsTestType;

namespace DVLD_Presentation.Forms.Managers
{
    public partial class frmListAppointments : Form
    {

        enum enAppMode { AddNew,Retake,Passed,unLocked}

        enAppMode appMode = enAppMode.AddNew;
        private clsTestType.enclsTestTypes _TestTypeID = clsTestType.enclsTestTypes.VisionTest;
      
        public int TestAppointmentID { get { return CurrentTestAppointmentID(); } }

        int DLApplicationID { get; set; }
        
        public frmListAppointments(int DLApplicationID, enclsTestTypes TestTypeID)
        {
            InitializeComponent();
            this.DLApplicationID = DLApplicationID;
            this._TestTypeID = TestTypeID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckAppointments()
        {
            if(clsTestAppointment.IsExists(DLApplicationID,(int) _TestTypeID))
            {
                if(clsTestAppointment.IsUnLocked(DLApplicationID, (int)_TestTypeID))
                {
                    appMode = enAppMode.unLocked;


                }
                else
                {
                    
                    if (clsTestAppointment.IsPassedTest(DLApplicationID, (int)_TestTypeID))
                    {
                        appMode = enAppMode.Passed;
                    }
                    else
                    {
                        appMode = enAppMode.Retake;
                    }
                }

            }else
            {
                appMode = enAppMode.AddNew;
            }
        }

        private void RefresPersonAppointmentList()
        {
            dataGridView1.DataSource = clsTestAppointment.GetApplicantTestAppointments(DLApplicationID, (int)this._TestTypeID);
            RecordCount();
        }

        private void RecordCount()
        {
            lbRecordCount.Text = dataGridView1.RowCount.ToString();
        }

        private int CurrentTestAppointmentID()
        {
            return (int)dataGridView1.CurrentRow.Cells[0].Value; 
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

            bool IsNew=false;
            
            CheckAppointments();

            switch(appMode)
            {
                case enAppMode.Passed:
                    MessageBox.Show("Person is Passed the Test");
                    return;
                    case enAppMode.unLocked:
                    MessageBox.Show("Person is have already avalibale appointment");

                    return;

                    case enAppMode.AddNew:
                    IsNew=true;
                    break;
                case enAppMode.Retake:
                    IsNew=false;


                    break;
            }
            frmAddTesetAppoinment tesetAppoinment = new frmAddTesetAppoinment(this.DLApplicationID, this._TestTypeID, IsNew);
            tesetAppoinment.ShowDialog();
            RefresPersonAppointmentList();
        }

        private void frmManageVisionTests_Load(object sender, EventArgs e)
        {
            ctrShowLDLApplicationInfo1.GetDLApplicationInfo(this.DLApplicationID);
            RefresPersonAppointmentList();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!clsTestAppointment.FindTestAppointment(this.TestAppointmentID).IsLocked)
            {
                frmAddTestResult frmAddTest = new frmAddTestResult(this.TestAppointmentID, this._TestTypeID);
                frmAddTest.ShowDialog();
            }
            else
            {
                MessageBox.Show("The Appointment is Locked");
            }

            RefresPersonAppointmentList();

        }

        private void editeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsTestAppointment.FindTestAppointment(this.TestAppointmentID).IsLocked)
            {
                frmAddTesetAppoinment tesetAppoinment = new frmAddTesetAppoinment(this.DLApplicationID, this._TestTypeID, false, this.TestAppointmentID);
                tesetAppoinment.ShowDialog();
            }
            else
            {
                MessageBox.Show("The Appointment is Locked");
            }
            RefresPersonAppointmentList();
        }
    }
}
