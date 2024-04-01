using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Business;
using DVLD_Access;


namespace DVLD_Business
{
    public class clsLocalDrivingLicenseApplication :clsApplication
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _mode = enMode.AddNew;

        int LocalDrivingLicenseApplicationID { get; set; }
        
        int LicenseClassID { get; set; }
        public clsLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseApplicationID = -1;
           
            this.LicenseClassID = -1;
            _mode = enMode.AddNew;
        }

        public void SetLLicenseClassID(int LicenseClassID)
        {
           
            this.LicenseClassID = LicenseClassID;
        }



        private clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID, int ApplicantPersonID, DateTime ApplicationDate,
            int ApplicationTypeID, enApplicationStatus ApplicationStatus,
            DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
            :base(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            
            this.LicenseClassID = LicenseClassID;
            _mode = enMode.Update;
        }
        private bool _AddNewLocalDrivingLicenseApplications()
        {
            int ID = -1;
            clsLocalDrivingLicenseApplications.InsertLocalDrivingLicenseApplication(ref ID, this.ApplicationID, this.LicenseClassID);
            this.LocalDrivingLicenseApplicationID = ID;
            return this.LocalDrivingLicenseApplicationID != -1;
        }
        private bool _UpdateLocalDrivingLicenseApplications()
        {
            return clsLocalDrivingLicenseApplications.UpdateLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID, this.ApplicationID, this.LicenseClassID);
        }
        public bool SaveLocalDrivingLicenseApplications()
        {

            this.SaveApplications();

            switch (_mode)
            {
                case enMode.AddNew:
                    
                    if (_AddNewLocalDrivingLicenseApplications())
                    {

                        _mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateLocalDrivingLicenseApplications();
            }
            return false;





        }


        public static clsLocalDrivingLicenseApplication FindLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = -1;
            int LicenseClassID = -1;
            int ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.Now;
            int ApplicationTypeID = -1;
            byte ApplicationStatus =1;
            DateTime LastStatusDate = DateTime.Now;
            float PaidFees = -1;
            int CreatedByUserID = -1;


            if (clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID))
            {
                if (clsApplications.FindApplication(ApplicationID, ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
                {

                    return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID, ApplicantPersonID, ApplicationDate,
            ApplicationTypeID, (enApplicationStatus)ApplicationStatus,
            LastStatusDate, PaidFees, CreatedByUserID);
                }
                else
                {
                    return null;
                }
            }

            else
            {
                return null;
            }



        }


        
        public int GetLicenseClassID()
        {
            return this.LicenseClassID;
        }

          public int GetLocalDrivingLicenseApplicationID()
        {
            return this.LocalDrivingLicenseApplicationID;
        }

        public static DataTable GetAllLDLApplications()
        {
            return clsLocalDrivingLicenseApplications.GetAllLocalDrivingLicenseApplications();
        }

        public static DataTable GetLDLApplicationsInfo(string ColumnName,string Value)
        {
            return clsLocalDrivingLicenseApplications.GetLocalDrivingLicenseApplicationInfo(ColumnName, Value);
        }

        static public bool DeleteLDLApplicationRecord(int LDLAppID)
        {
            clsLocalDrivingLicenseApplication clsLocal = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(LDLAppID);
            if(clsLocalDrivingLicenseApplications.DeleteLocalDrivingLicenseApplication(LDLAppID))
            {
               return clsApplication.DeleteApplicationRecord(clsLocal.GetApplicationID());
            }else { return false; }
        }
    }

}
