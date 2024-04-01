using DVLD_Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Access;


namespace DVLD_Business
{
    public class clsTestAppointment
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _mode = enMode.AddNew;

        int TestAppointmentID { get; set; }
       public int TestTypeID { get; set; }
       public int LocalDrivingLicenseApplicationID { get; set; }
       public clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication { get; set; }
       public DateTime AppointmentDate { get; set; }
       public float PaidFees { get; set; }
       public int CreatedByUserID { get; set; }
        public int RetakeTestApplicationID { get; set; }
        public clsApplication RetakeTestApplication { get; set; }
       
       public bool IsLocked { get; set; }

        public int TestID 
        {
            get { return _GetTestID(); }
        }
        public clsTestAppointment()
        {
            this.TestAppointmentID = -1;
            this.TestTypeID = -1;
            this.LocalDrivingLicenseApplicationID = -1;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = -1;
            this.CreatedByUserID = -1;
            this.RetakeTestApplicationID = -1;
            this.IsLocked = false;
            _mode = enMode.AddNew;
        }
        private clsTestAppointment(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, float PaidFees, int CreatedByUserID, bool IsLocked, int retakeApplicationID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            _mode = enMode.Update;
            RetakeTestApplicationID = retakeApplicationID;
            this.LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID);
            this.RetakeTestApplication =clsApplication.FindApplication(RetakeTestApplicationID);
        }
        public void SetColumnsValue(int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, float PaidFees, int CreatedByUserID)
        {
           
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = false;
            
        }

        public static clsTestAppointment FindTestAppointment(int TestAppointmentID)
        {
            int TestTypeID = -1;
            int LocalDrivingLicenseApplicationID = -1;
            DateTime AppointmentDate = DateTime.Now;
            float PaidFees = -1;
            int CreatedByUserID = -1;
            int RetakeApplicationID = -1;
           
            bool IsLocked = false;

            if (clsTestAppointments.FindTestAppointment(TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked,ref RetakeApplicationID))
            {

                return new clsTestAppointment(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeApplicationID);
            }
            else
            {
                return null;
            }
        }



        private bool _AddNewTestAppointments()
        {
            int ID = -1;
            clsTestAppointments.InsertTestAppointment(ref ID, this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked);
            this.TestAppointmentID = ID;
            return this.TestAppointmentID != -1;
        }
        private bool _UpdateTestAppointments()
        {
            return clsTestAppointments.UpdateTestAppointment(this.TestAppointmentID, this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked,this.RetakeTestApplicationID);
        }
        public bool SaveTestAppointments()
        {

            switch (_mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestAppointments())
                    {

                        _mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateTestAppointments();
            }
            return false;
        }


        public static DataTable GetApplicantTestAppointments(int DLApplication,int TestTitle)
        {
            return clsTestAppointments.GetApplicantTestAppointments(DLApplication, TestTitle);
        }

        public static bool IsExists(int DLApplication,int TestTypeID)
        {
            return clsTestAppointments.IsExists(DLApplication, TestTypeID);
        }

        public static bool IsUnLocked(int DLApplication,int TestTypeID)
        {
            return clsTestAppointments.IsUnLocked(DLApplication, TestTypeID);
        }
         public static bool IsPassedTest(int DLApplication,int TestTypeID)
        {
            return clsTestAppointments.IsPassedTest(DLApplication, TestTypeID);
        }
       

        public int GetTestAppointmentID()
        {
            return this.TestAppointmentID;
        }
        public static int GetTrailsPersonInTest(int LocalDrivingLicenseApplicationID, int TestType)
        {
            return clsTestAppointments.GetTrailsPersonInTest(LocalDrivingLicenseApplicationID, TestType);
        }
        public  int GetTrailsPersonInTest()
        {
            return clsTestAppointments.GetTrailsPersonInTest(this.LocalDrivingLicenseApplicationID, this.TestTypeID);
        }

         private int _GetTestID ()
        {
            return clsTestAppointments.GetTestID(this.TestAppointmentID);
        }



    }


}
