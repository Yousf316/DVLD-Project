using DVLD_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsDetainendLicense
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _mode = enMode.AddNew;

      public int DetainID { get; set; }
      public int LicenseID { get; set; }
      public DateTime DetainDate { get; set; }
      public float FineFees { get; set; }
      public int CreatedByUserID { get; set; }
      public bool IsReleased { get; set; }
      public DateTime? ReleaseDate { get; set; }
      public int ReleasedByUserID { get; set; }
      public int ReleaseApplicationID { get; set; }

        public clsDetainendLicense()
        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.Now;
            this.FineFees = -1;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate =null;
            this.ReleasedByUserID = -1;
            this.ReleaseApplicationID = -1;
            _mode = enMode.AddNew;
        }
        private clsDetainendLicense(int DetainID, int LicenseID, DateTime DetainDate, float FineFees, int CreatedByUserID, bool IsReleased, DateTime? ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;
            _mode = enMode.Update;
        }

         public void SetReleaseColumnValues( DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;
         
        }


          public void SetDetinedColumnValues( int LicenseID, DateTime DetainDate, float FineFees, int CreatedByUserID, bool IsReleased)
        {
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            
        }


        private bool _AddNewDetainedLicenses()
        {
            int ID = -1;
            clsDetainedLicenses.InsertDetainendLicense(ref ID, this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID);
            this.DetainID = ID;
            return this.DetainID != -1;
        }
        private bool _UpdateDetainedLicenses()
        {
            return clsDetainedLicenses.UpdateDetainendLicense(this.DetainID, this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);
        }
        public bool SaveDetainedLicenses()
        {

            switch (_mode)
            {
                case enMode.AddNew:
                    if (_AddNewDetainedLicenses())
                    {

                        _mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateDetainedLicenses();
            }
            return false;
        }

        public static clsDetainendLicense FindDetainendLicense(int DetainID)
        {
            int LicenseID = -1;
            DateTime DetainDate = DateTime.Now;
            float FineFees = -1;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime? ReleaseDate = null;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;

            if (clsDetainedLicenses.FindDetainendLicense(DetainID, ref LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {

                return new clsDetainendLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }
            else
            {
                return null;
            }
        }


        public static bool IsLicenseDetained(int LicenseID)
        {
            return clsDetainedLicenses.IsLicenseDetaiend(LicenseID);
        }


        public static DataTable GetAllDetaindLicenses ()
        {
            return clsDetainedLicenses.GetAllDetainedLicenses();
        }
          public static DataTable GetDetainedLicense (string ColumnName,string Value)
        {
            return clsDetainedLicenses.GetDetainedLicenseInfo(ColumnName,Value);
        }

          public static int GetDetainIDByDetainedLicense(int LicenseID)
        {
            return clsDetainedLicenses.GetDetainIDByDetainedLicense(LicenseID);
        }


    }

}
