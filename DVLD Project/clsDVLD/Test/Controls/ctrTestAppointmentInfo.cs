using DVLD_Business;
using DVLD_Presentation.Classes;
using DVLD_Presentation.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Test.Controls
{
    public partial class ctrTestAppointmentInfo : UserControl
    {

        private clsTestType.enclsTestTypes _TestTypeID =clsTestType.enclsTestTypes.VisionTest;

        public clsTestType.enclsTestTypes TestTypeID
        {
            get
            {
                return _TestTypeID;
            }
            set
            {
                _TestTypeID = value;

                switch(_TestTypeID)
                {
                    case clsTestType.enclsTestTypes.VisionTest:
                        groupBox1.Text = "Vision Test";
                        pictureBox1.Image = Resources.eye;
                        break;

                    case clsTestType.enclsTestTypes.WrittenTest:
                        groupBox1.Text = "Written Test";
                        pictureBox1.Image = Resources.clipboardwithpencil;
                        break;
                    case clsTestType.enclsTestTypes.StreetTest:
                        groupBox1.Text = "Street Test";
                        pictureBox1.Image = Resources.steering_wheel;
                        break;
                }
            }
        }
        private int _Test=-1 ;
        private clsTestAppointment _appointment ;
        private int _TestAppointmentID=-1;

        public int TestAppointmentID
        { 
            get 
            { 
                return _TestAppointmentID;
            }
        }
         public int Test 
        { 
            get 
            { 
                return _Test;
            }
        }

        public void _LoadAppointmentInfo(int TestAppointmentID)
        {
            _TestAppointmentID = TestAppointmentID;
            _appointment = clsTestAppointment.FindTestAppointment(TestAppointmentID);

            if (_appointment == null)
            {
                MessageBox.Show("Unvalid Appointment ID" + TestAppointmentID.ToString(), "Error", MessageBoxButtons.OK);
                _TestAppointmentID = -1;
                return;
            }

            lbDLAppID.Text = _appointment.LocalDrivingLicenseApplicationID.ToString();
            lbName.Text = _appointment.LocalDrivingLicenseApplication.GetFullNameApplicatn();
            lbDClass.Text = clsLicenseClass.FindLicenseClass(_appointment.LocalDrivingLicenseApplication.GetLicenseClassID()).GetClassName();
            lbFees.Text = _appointment.PaidFees.ToString();

            lbAppointmentdate.Text = clsFormat.DateToShort(_appointment.AppointmentDate);

            _Test = _appointment.TestID;

            lbTestID.Text = (_appointment.TestID == -1) ? "Not Teken yet" : _appointment.TestID.ToString();

            lbTrial.Text = "N/A";

        }
      
        public ctrTestAppointmentInfo()
        {
            InitializeComponent();
        }

       
    }
}
