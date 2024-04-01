using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Business;

using DVLD_Access;
using System.Data;

namespace DVLD_Business
{
    public class clsInternationalLicense
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _mode = enMode.AddNew;

      public  int InternationalLicenseID { get; set; }
      public  int ApplicationID { get; set; }
      public   clsApplication objApplication;
      public  int DriverID { get; set; }
      public  int IssuedUsingLocalLicenseID { get; set; }
      public  DateTime IssueDate { get; set; }
      public  DateTime ExpirationDate { get; set; }
      public  bool IsActive { get; set; }
      public  int CreatedByUserID { get; set; }
        public clsInternationalLicense()
        {
            this.InternationalLicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.IsActive = false;
            this.CreatedByUserID = -1;
            objApplication = new clsApplication();

          _mode = enMode.AddNew;
        }
        private clsInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
            objApplication = clsApplication.FindApplication(ApplicationID);
            _mode = enMode.Update;
        }
        public void SetColumnsValue( int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
            objApplication = clsApplication.FindApplication(ApplicationID);
            
        }


        private bool _AddNewInternationalLicenses()
        {
            int ID = -1;
            clsInternationalLicenses.InsertInternationalLicense(ref ID, this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);
            this.InternationalLicenseID = ID;
            return this.InternationalLicenseID != -1;
        }

        private bool _UpdateInternationalLicenses()
        {
            return clsInternationalLicenses.UpdateInternationalLicense(this.InternationalLicenseID, this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);
        }

        public bool SaveInternationalLicenses()
        {

            switch (_mode)
            {
                case enMode.AddNew:
                    if (_AddNewInternationalLicenses())
                    {

                        _mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateInternationalLicenses();
            }
            return false;
        }

        public static clsInternationalLicense FindInternationalLicense(int InternationalLicenseID)
        {
            int ApplicationID = -1;
            int DriverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            bool IsActive = false;
            int CreatedByUserID = -1;

            if (clsInternationalLicenses.FindInternationalLicense(InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {

                return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        public static bool IsThereInernationalLicenseWithLocalLicense(int IssuedUsingLocalLicenseID)
        {
            return clsInternationalLicenses.IsThereInernationalLicenseWithLocalLicense(IssuedUsingLocalLicenseID);
        }

        public static DataTable GetAllInternationalLicenses()
        {
            return clsInternationalLicenses.GetAllInternationalLicenses();
        }
        public static DataTable GetInternationalLicenseInfo(string CoulmnName,string Value)
        {
            return clsInternationalLicenses.GetInternationalLicenseInfo(CoulmnName,Value);
        }

    }

   
}
