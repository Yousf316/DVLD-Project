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
    public class clsApplicationType
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _mode = enMode.AddNew;
        

        public enum enApplicationTypes { New_Local_Driving_License_Service = 1, Renew_Driving_License_Service ,
            Replacement_for_a_Lost_Driving_License, Replacement_for_a_Damaged_Driving_License,
            Release_Detained_Driving_Licsense, New_International_License, Retake_Test
        };

        int ApplicationTypeID { get; set; }
        string ApplicationTypeTitle { get; set; }
        float ApplicationFees { get; set; }
        public clsApplicationType()
        {
            
            _mode = enMode.AddNew;
        }
        private clsApplicationType(int ApplicationTypeID, string ApplicationTypeTitle, float ApplicationFees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;
            
            _mode = enMode.Update;
        }
       
        private bool _UpdateApplicationTypes()
        {
            return clsApplicationTypes.UpdateApplicationType(this.ApplicationTypeID, this.ApplicationTypeTitle, this.ApplicationFees);
        }

        public bool SetCoulmns( string ApplicationTypeTitle, float ApplicationFees)
        {
            if( ApplicationTypeTitle ==""|| ApplicationFees==-1)
            {
                return false;
            }
    
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;
            
            return true;
        }

        public static clsApplicationType FindApplicationType(int ApplicationTypeID)
        {
            string ApplicationTypeTitle = "";
            float ApplicationFees = -1;

            if (clsApplicationTypes.FindApplicationType(ApplicationTypeID, ref ApplicationTypeTitle, ref ApplicationFees))
            {

                return new clsApplicationType(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);

            }
            else
            {
                return null;
            }
        }

        public string GetApplicationTypeTitle()
        {
            return ApplicationTypeTitle;
        }
        public float GetApplicationFees()
        {
            return ApplicationFees;
        }

        public bool SaveApplicationTypes()
        {

            switch (_mode)
            {
               

                case enMode.Update:

                    return _UpdateApplicationTypes();
            }
            return false;
        }

        public static DataTable GetAllApplicationTypes()
        {
            return clsApplicationTypes.GetAllApplicationTypes();
        }


        public static int GetAppTypeID(string appTypeTitle)
        {
            int AppID = -1;
            clsApplicationTypes.GetApplicationTypeID(ref AppID, appTypeTitle);
            return AppID;
        }
     
        public static float GetApplicationTypeFees(enApplicationTypes type)
        {
            return clsApplicationType.FindApplicationType((int)type).GetApplicationFees();   
        }
    }

}
