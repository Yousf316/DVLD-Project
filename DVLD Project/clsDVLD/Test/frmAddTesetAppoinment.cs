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

namespace DVLD_Presentation.Forms.Add
{
    public partial class frmAddTesetAppoinment : Form
    {
        int DLApplicationID {  get; set; }
        private clsTestType.enclsTestTypes TestTypeID = clsTestType.enclsTestTypes.VisionTest;
       

        clsTestAppointment appointment;
        private int _PersonID;
        enum enMode { AddNew,Update}
        enMode mode = enMode.AddNew;

        int TestAppointmentID = -1;
        bool IsFirstAppointment {  get; set; }
        
        float RAppFees {  get; set; }
        float Fees {  get; set; }
        public frmAddTesetAppoinment(int DLApplicationID,clsTestType.enclsTestTypes TestTypeID,bool IsFirstAppointment,int TestAppointmentID=-1)
        {
            InitializeComponent();
            this.DLApplicationID = DLApplicationID;
           this.TestTypeID = TestTypeID;
            this.IsFirstAppointment = IsFirstAppointment;
            this.TestAppointmentID= TestAppointmentID;
        }

        private void _HandelScheduleTestType()
        {

            switch(this.TestTypeID)
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
        private bool _HandelRetakeApplication()
        {

           if (mode==enMode.AddNew&&!this.IsFirstAppointment)
            {
                clsApplication application = new clsApplication();

                application.SetCoulmns(_PersonID, DateTime.Now
                    , (int)clsApplication.enApplicationType.RetakeTest,
                    clsApplication.enApplicationStatus.Completed, DateTime.Now
                    , clsApplicationType.FindApplicationType((int)clsApplication.enApplicationType.RetakeTest).GetApplicationFees()
                    ,clsGlobal.CurrentUser.GetUserID());


                if(!application.SaveApplications())
                {
                    appointment.RetakeTestApplicationID = -1;
                    MessageBox.Show("Faild to Create application", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                appointment.RetakeTestApplicationID = application.GetApplicationID();

                appointment.SaveTestAppointments(); 
            }
           return true;

        }

        private void SetMinDateTime()
        {
            if(DateTime.Compare(DateTime.Now, appointment.AppointmentDate) < 0)
            {
                dpAppointment.MinDate= DateTime.Now;
                
            }else
            {
                dpAppointment.MinDate = appointment.AppointmentDate;
               
            }

            dpAppointment.Value = appointment.AppointmentDate;
        }

        private void _LoadAppointmentInfo()
        {

            appointment = clsTestAppointment.FindTestAppointment(TestAppointmentID);

            if (appointment == null)
            {
                MessageBox.Show("Unvalid Appointment ID" + TestAppointmentID.ToString(),"Error",MessageBoxButtons.OK);
                this.Close();
            }

            lbDLAppID.Text = appointment.LocalDrivingLicenseApplicationID.ToString();
            lbName.Text = appointment.LocalDrivingLicenseApplication.GetFullNameApplicatn();
            lbTotalFees.Text = appointment.PaidFees.ToString();
            lbDClass.Text=clsLicenseClass.FindLicenseClass(appointment.LocalDrivingLicenseApplication.GetLicenseClassID()).GetClassName();
            lbFees.Text = clsTestType.FindTestType(TestTypeID).GetTestTypeFees().ToString();



            SetMinDateTime();

            if(appointment.RetakeTestApplicationID !=-1)
            {
                gbRetakeTestinfo.Enabled= true;
                lbRTAppID.Text =appointment.RetakeTestApplicationID.ToString();
                lbRAppFees.Text=clsApplicationType.FindApplicationType((int)clsApplication.enApplicationType.RetakeTest).GetApplicationFees().ToString();
            }
            else
            {
                gbRetakeTestinfo.Enabled = true;
                lbRAppFees.Text = "0";
                lbRTAppID.Text = "N/A";
            }

            lbTrial.Text = appointment.GetTrailsPersonInTest().ToString();

        }

        private void LoadDefaultInfo()
        {
            clsLocalDrivingLicenseApplication ObjLocalDriving= clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(DLApplicationID);

            if (ObjLocalDriving == null)
                return;

            _PersonID = ObjLocalDriving.GetApplicantPersonID();

            if (TestAppointmentID != -1)
            {
                _LoadAppointmentInfo();
                return;
            }

            _HandelScheduleTestType();
            Fees = clsTestType.FindTestType(TestTypeID).GetTestTypeFees();
            lbDLAppID.Text=DLApplicationID.ToString();
            lbFees.Text = Fees.ToString();
            lbDClass.Text = clsLicenseClass.FindLicenseClass(ObjLocalDriving.GetLicenseClassID()).GetClassName();
            lbTrial.Text = clsTestAppointment.GetTrailsPersonInTest(DLApplicationID,(int)this.TestTypeID).ToString();
            
            lbName.Text = ObjLocalDriving.GetFullNameApplicatn();
            if(this.IsFirstAppointment)
                RAppFees = 0;
            else
            {
                RAppFees = clsApplicationType.FindApplicationType((int)clsApplication.enApplicationType.RetakeTest).GetApplicationFees();
                lbRAppFees.Text = RAppFees.ToString();
                gbRetakeTestinfo.Enabled = true;
            }

           

            lbTotalFees.Text =  (RAppFees+ Fees).ToString();

        }



        private void frmAddVisionTesetAppoinment_Load(object sender, EventArgs e)
        {
            LoadDefaultInfo();
        }

        private bool AddNewTestAppointment()
        {
             appointment = new clsTestAppointment();
            float.TryParse(lbTotalFees.Text, out float TotalFees);
            appointment.SetColumnsValue((int)this.TestTypeID, DLApplicationID, dpAppointment.Value, TotalFees,clsGlobal.CurrentUser.GetUserID());

          return appointment.SaveTestAppointments();

            
        }
        private bool EditeTestAppointment()
        {
            
            float.TryParse(lbTotalFees.Text, out float TotalFees);
            appointment.SetColumnsValue((int)this.TestTypeID, DLApplicationID, dpAppointment.Value, TotalFees,clsGlobal.CurrentUser.GetUserID());

          return appointment.SaveTestAppointments();

            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if(TestAppointmentID==-1)
            {
                if (AddNewTestAppointment())
                {

                    if (!this.IsFirstAppointment)
                        _HandelRetakeApplication();

                    MessageBox.Show("Succeeded");
                    
                }
                else
                {
                    MessageBox.Show("Failed");
                    
                }    

            }
            else
            {
               if( EditeTestAppointment())
                {
                    MessageBox.Show("Succeeded");
                  
                }
                else
                {
                    MessageBox.Show("Failed");
                    
                }
            }
            
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
