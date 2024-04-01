using DVLD_Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Access;

namespace DVLD_Business
{
    public class clsTest
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _mode = enMode.AddNew;

        int TestID { get; set; }
        int TestAppointmentID { get; set; }
         bool TestResult { get; set; }
        string Notes { get; set; }
        int CreatedByUserID { get; set; }


        public clsTest()
        {
            this.TestID = -1;
            this.TestAppointmentID = -1;
            this.TestResult = false;
            this.Notes = "";
            this.CreatedByUserID = -1;
            _mode = enMode.AddNew;
        }
        private clsTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
            _mode = enMode.Update;
        }
        public void SetCoulmnsValue( int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
           
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
        }


        private bool _AddNewTests()
        {
            int ID = -1;
            clsTests.InsertTest(ref ID, this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
            this.TestID = ID;
            return this.TestID != -1;
        }
        private bool _UpdateTests()
        {
            return clsTests.UpdateTest(this.TestID, this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
        }
        public bool SaveTests()
        {
          
            switch (_mode)
            {
                case enMode.AddNew:
                    if (_AddNewTests())
                    {

                        _mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateTests();
            }
            return false;
        }


        public static clsTest FindTest(int TestID)
        {
            int TestAppointmentID = -1;
            bool TestResult = false;
            string Notes = "";
            int CreatedByUserID = -1;

            if (clsTests.FindTest(TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
            {

                return new clsTest(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }



        public static int GetApplicantTestResult(int DLApplicationID)
        {
            int Result = -1;
            clsTests.GetTestResult(DLApplicationID, ref Result);
            return Result;
        }
         public  bool GetResult()
        {
            return this.TestResult;
        }




    }

}
