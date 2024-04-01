using DVLD_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLD_Business.clsLicense;

namespace DVLD_Business
{
    public class clsLicense
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _mode = enMode.AddNew;
        public enum enIssuesReasons { FirstTime = 1, Renew, Replacement_for_Damaged, Rplacement_for_Lost };
        public enIssuesReasons ReasonTypes = enIssuesReasons.FirstTime;

        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClassID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public float PaidFees { get; set; }
        public bool IsActive { get; set; }
        public int IssueReason { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsDetain { get { return clsDetainedLicenses.IsLicenseDetaiend(LicenseID); } }

        public clsDriver objDriver;

        public clsLicenseClass objLicenseClass{ get{ return clsLicenseClass.FindLicenseClass(this.LicenseClassID); } }
        public clsLicense()
        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClassID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = -1;
            this.IsActive = false;
            this.IssueReason = -1;
            this.CreatedByUserID = -1;
            _mode = enMode.AddNew;
        }
        private clsLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, float PaidFees, bool IsActive, int IssueReason, int CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClassID = LicenseClass;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;
            ReasonTypes = (enIssuesReasons)IssueReason;
            objDriver = clsDriver.FindDriver(DriverID);
            _mode = enMode.Update;
        }
         public void SetColumnsValue( int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, float PaidFees, bool IsActive, int IssueReason, int CreatedByUserID)
        {
            
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClassID = LicenseClass;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;
            ReasonTypes = (enIssuesReasons)IssueReason;
            
        }


        private bool _AddNewLicenses()
        {
            int ID = -1;
            clsLicenses.InsertLicense(ref ID, this.ApplicationID, this.DriverID, this.LicenseClassID, this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);
            this.LicenseID = ID;
            return this.LicenseID != -1;
        }
        private bool _UpdateLicenses()
        {
            return clsLicenses.UpdateLicense(this.LicenseID, this.ApplicationID, this.DriverID, this.LicenseClassID, this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);
        }
        public bool SaveLicenses()
        {

            switch (_mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicenses())
                    {

                        _mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateLicenses();
            }
            return false;
        }

        public static clsLicense FindLicense(int LicenseID)
        {
            int ApplicationID = -1;
            int DriverID = -1;
            int LicenseClass = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            string Notes = "";
            float PaidFees = -1;
            bool IsActive = false;
            int IssueReason = -1;
            int CreatedByUserID = -1;

            if (clsLicenses.FindLicense(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {

                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        public static bool IsLicenseExsitsByApplicationID(int ApplicationID)
        {
            return clsLicenses.IsLicenseExsitsByApplicationID(ApplicationID);
        }
        public static bool IsLicenseExsitsByID(int LicenseID)
        {
            return clsLicenses.IsLicenseExsits(LicenseID);
        }


         public static bool ThereIsLicenseActive(int DriverID,int LicenseClass)
        {
            return clsLicenses.ThereIsLicenseActive(DriverID, LicenseClass);
        }

         public static int GetLicenseIDByApplicationID(int ApplicationID)
        {
            return clsLicenses.GetLicenseIDByApplicationID(ApplicationID);
        }

    }

}
