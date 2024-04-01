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
    public class clsLicenseClass
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _mode = enMode.AddNew;

      public  int LicenseClassID { get; set; }
      public  string ClassName { get; set; }
      public  string ClassDescription { get; set; }
      public  int MinimumAllowedAge { get; set; }
      public   int DefaultValidityLength { get; set; }
      public  float ClassFees { get; set; }
        public clsLicenseClass()
        {
            this.LicenseClassID = -1;
            this.ClassName = "";
            this.ClassDescription = "";
            this.MinimumAllowedAge = -1;
            this.DefaultValidityLength = -1;
            this.ClassFees = -1;
            _mode = enMode.AddNew;
        }
        private clsLicenseClass(int LicenseClassID, string ClassName, string ClassDescription, int MinimumAllowedAge, int DefaultValidityLength, float ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
            _mode = enMode.Update;
        }

         public void SetColumns(string ClassName, string ClassDescription, int MinimumAllowedAge, int DefaultValidityLength, float ClassFees)
        {
          
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
           
        }

        public static clsLicenseClass FindLicenseClass(string LicenseClassName)
        {
            int LicenseClassID = -1;
            if(clsLicenseClasses.GetLicenseClassID(ref LicenseClassID, LicenseClassName))
            {
               return FindLicenseClass(LicenseClassID);
            }

            return null;
        }

        public static clsLicenseClass FindLicenseClass(int LicenseClassID)
        {
            string ClassName = "";
            string ClassDescription = "";
            int MinimumAllowedAge = -1;
            int DefaultValidityLength = -1;
            float ClassFees = -1;

            if (clsLicenseClasses.FindLicenseClass(LicenseClassID, ref ClassName, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
            {

                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }
            else
            {
                return null;
            }
        }


        private bool _UpdateLicenseClasses()
        {
            return clsLicenseClasses.UpdateLicenseClass(this.LicenseClassID, this.ClassName, this.ClassDescription, this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees);
        }
        public bool SaveLicenseClasses()
        {

            switch (_mode)
            {
                

                case enMode.Update:

                    return _UpdateLicenseClasses();
            }
            return false;
        }


        public static DataTable GetAllLicenseClasses()
        {
            return clsLicenseClasses.GetAllLicenseClasses();
        }

        public static int GetLicenseClassID(string ClassName)
        {
            int LClassID = -1;
             clsLicenseClasses.GetLicenseClassID(ref LClassID,ClassName);

            return LClassID;
        }

        public string GetClassName() 
        {
        return this.ClassName;
        }
         public float GetClassFees() 
        {
        return this.ClassFees;
        }

    }


}
