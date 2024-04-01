using DVLD_Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DVLD_Access;



namespace DVLD_Business
{
    public class clsTestType
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _mode = enMode.AddNew;

       public enum enclsTestTypes { VisionTest = 1, WrittenTest = 2, StreetTest = 3 }

        public enclsTestTypes TestTypeID { get; set; }
      
        string TestTypeTitle { get; set; }
        string TestTypeDescription { get; set; }
        float TestTypeFees { get; set; }

        public clsTestType()
        {
            
            _mode = enMode.AddNew;
        }

        private clsTestType(clsTestType.enclsTestTypes TestTypeID, string TestTypeTitle, string TestTypeDescription, float TestTypeFees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;
            _mode = enMode.Update;
        }
        
        private bool _UpdateTestTypes()
        {
            return clsTestTypes.UpdateTestType((int)this.TestTypeID, this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees);
        }
        public bool UpdateColumns(string TestTypeTitle, string TestTypeDescription, float TestTypeFees)
        {
            if (TestTypeTitle == "" || TestTypeDescription == "" || TestTypeFees == -1)
                return false;

            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;

            return true;
        }
        public bool SaveTestTypes()
        {

            switch (_mode)
            {
                

                case enMode.Update:

                    return _UpdateTestTypes();
            }
            return false;
        }

        public static clsTestType FindTestType(clsTestType.enclsTestTypes TestTypeID)
        {
            string TestTypeTitle = "";
            string TestTypeDescription = "";
            float TestTypeFees = -1;

            if (clsTestTypes.FindTestType((int)TestTypeID, ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees))
            {

                return new clsTestType(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
            }
            else
            {
                return null;
            }
        }


        public static DataTable GetAllTestTypes()
        {
            return clsTestTypes.GetAllTestTypes();
        }

        public string GetTestTypeTitle()
        {
            return this.TestTypeTitle;
        }
         public string GetTestTypeDescription()
        {
            return this.TestTypeDescription;
        }
          public float GetTestTypeFees()
        {
            return this.TestTypeFees;
        }
           public int GetTestTypeID()
        {
            return (int)this.TestTypeID;
        }

    }

}
