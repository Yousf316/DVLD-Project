using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Business;
using DVLD_Access;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Business
{
    public class clsApplication
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _mode = enMode.AddNew;

        public enum enApplicationType
        {
            NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
            ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 7
        };

        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 };

        public enApplicationStatus ApplicationStatus { set; get; }

        protected int ApplicationID { get; set; }
        int ApplicantPersonID { get; set; }
        DateTime ApplicationDate { get; set; }
        int ApplicationTypeID { get; set; }
        
        clsPerson PersonInfo {get; set;}



        DateTime LastStatusDate { get; set; }
        float PaidFees { get; set; }
        int CreatedByUserID { get; set; }

        public clsUser CreatedByUserInfo;

        public clsApplicationType ApplicationTypeInfo;

        public clsApplication()
        {
            this.ApplicationID = -1;
            this.ApplicantPersonID = -1;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = enApplicationStatus.New;
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = -1;
            this.CreatedByUserID = -1;
            _mode = enMode.AddNew;
        }
        protected clsApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, enApplicationStatus ApplicationStatus, DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.PersonInfo = clsPerson.FindPerson(ApplicantPersonID);
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeInfo = clsApplicationType.FindApplicationType(ApplicationTypeID);
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = clsUser.FindUser(CreatedByUserID);
            _mode = enMode.Update;
        }


        public void  SetCoulmns( int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, enApplicationStatus ApplicationStatus, DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
        {

            
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            
        }

        public static clsApplication FindApplication(int ApplicationID)
        {
            int ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.Now;
            int ApplicationTypeID = -1;
            byte ApplicationStatus = 1;
            DateTime LastStatusDate = DateTime.Now;
            float PaidFees = -1;
            int CreatedByUserID = -1;

            if (clsApplications.FindApplication(ApplicationID, ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {

                return new clsApplication(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, (enApplicationStatus)ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewApplications()
        {
            int ID = -1;
            clsApplications.InsertApplication(ref ID, this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, (byte)this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
            this.ApplicationID = ID;
            return this.ApplicationID != -1;
        }
        private bool _UpdateApplications()
        {
            return clsApplications.UpdateApplication(this.ApplicationID, this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, (byte)this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
        }
         private bool _UpdateApplicationsStatus()
        {
            return clsApplications.UpdateStatus(this.ApplicationID, (byte)this.ApplicationStatus);
        }


        public bool SaveApplications()
        {

            switch (_mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplications())
                    {

                        _mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateApplications();
            }
            return false;
        }

        public int GetApplicationID()
        { 
            return this.ApplicationID; 
        } 
        public int GetCreatedUserID()
        { 
            return this.CreatedByUserID; 
        }
        public DateTime GetApplicationDate()
        { 
            return this.ApplicationDate; 
        } 
         public float GetPaidFees()
        { 
            return this.PaidFees; 
        } 
          public int GetApplicantPersonID()
        { 
            return this.ApplicantPersonID; 
        } 
           public string GetApplicationTypeTitle()
        {
            return clsApplicationType.FindApplicationType(ApplicationTypeID).GetApplicationTypeTitle(); 
        } 
            public byte GetApplicationStatus()
        {
            return (byte)this.ApplicationStatus; 
        } 
              public string GetFullNameApplicatn()
        {

            return clsPerson.FindPerson(this.ApplicantPersonID).GetFullName();
                
        } 
               public string GetUserNameofCratedBy(int UserID)
        {

            return clsUser.FindUser(UserID).GetUserName();
                
        } 
                 public DateTime GetLastStatusDate()
        {

            return this.LastStatusDate;
                
        } 
                  public void ChangeStatus(enApplicationStatus AppStatus)
        {

           this.ApplicationStatus = AppStatus;
          
                
        } 
         
        static public bool DeleteApplicationRecord(int AppRecordID)
        {
            return clsApplications.DeleteApplication(AppRecordID); 
        }
         static public int GetApplicantInfo(int ApplicatnPersonID,int LicenseClassID)
        {
            int ApplicationStatus = -1;
            clsApplications.IsExists(ApplicatnPersonID, LicenseClassID, ref ApplicationStatus);
            return ApplicationStatus;
        }
           static public bool UpdateApplicationStatus(int ApplicationID,enApplicationStatus applicationStatus)
        {
            return clsApplications.UpdateStatus(ApplicationID, (byte)applicationStatus);
        }
             public bool UpdateApplicationStatus()
        {
            return _UpdateApplicationsStatus();
        }


    }

}
