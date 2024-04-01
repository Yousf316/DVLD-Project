using DVLD_Business;
using DVLD_Presentation.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Forms.Add
{
    public partial class frmAddTestResult : Form
    {
        enum emMode { TakeTest,TokedTest}
        emMode mode = emMode.TakeTest;
        private int _TestAppointmentID = -1;
        private clsTestType.enclsTestTypes _testTypeID=clsTestType.enclsTestTypes.VisionTest;
        private clsTest _test;
        private clsTestAppointment _appointment;
        public frmAddTestResult(int TestAppointmentID,clsTestType.enclsTestTypes testTypeID)
        {
            InitializeComponent();
            _TestAppointmentID=TestAppointmentID;
            _testTypeID=testTypeID;
        }


        private void LoadTestInfo()
        {
            _appointment = clsTestAppointment.FindTestAppointment(_TestAppointmentID);

            if( _appointment == null )
            {
                MessageBox.Show("The Appointment Id is not Found");
                return;
            }

            if (_appointment.TestID == -1)
            {
                mode = emMode.TakeTest;
            }
            else
            {
                mode = emMode.TokedTest;
                _test = clsTest.FindTest(_appointment.TestID);

            }


            switch (mode)
            {
                case emMode.TakeTest:
                    rdFailed.Enabled = true;
                    rdPassed.Enabled = true;
                    btnSave.Enabled = true;
                    richTextBox1.Enabled = true;
                    break;

                    case emMode.TokedTest:
                    if(!_test.GetResult())
                    {
                        rdFailed.Enabled = true;
                    }
                    else
                    {
                        rdPassed.Enabled = true;
                    }
                    rdFailed.Enabled = false;
                    rdPassed.Enabled = false;
                    richTextBox1.Enabled = false;

                    btnSave.Enabled =  false;
                    break;
            }

        }
        private void frmAddTestResult_Load(object sender, EventArgs e)
        {
            ctrTestAppointmentInfo1.TestTypeID = _testTypeID;
            ctrTestAppointmentInfo1._LoadAppointmentInfo(_TestAppointmentID);
            LoadTestInfo();


        }

        private bool AddResult()
        {
            _test = new clsTest();
            _test.SetCoulmnsValue(_TestAppointmentID, rdPassed.Checked, richTextBox1.Text, clsGlobal.CurrentUser.GetUserID());
          return  _test.SaveTests();
            

        }
        private bool LockedTestAppointment()
        {
            _appointment.IsLocked = true;
          return _appointment.SaveTestAppointments();
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure . the result cant be change later","Confirm",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
              if(AddResult())
                {
                    LockedTestAppointment();
                    MessageBox.Show("Succeeded");
                }
                else
                {
                    MessageBox.Show("Faild");
                }
            }

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
