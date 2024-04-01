using DVLD_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsDriver
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _mode = enMode.AddNew;

       public int DriverID { get; set; }
       public int PersonID { get; set; }
       public int CreatedByUserID { get; set; }
       public DateTime CreatedDate { get; set; }
        public clsDriver()
        {
            this.DriverID = -1;
            this.PersonID = -1;
            this.CreatedByUserID = -1;
            this.CreatedDate = DateTime.Now;
            _mode = enMode.AddNew;
        }
        private clsDriver(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;
            _mode = enMode.Update;
        }
         public void SetColumnsValue( int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
           
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;
           
        }


        private bool _AddNewDrivers()
        {
            int ID = -1;
            clsDrivers.InsertDriver(ref ID, this.PersonID, this.CreatedByUserID, this.CreatedDate);
            this.DriverID = ID;
            return this.DriverID != -1;
        }
        private bool _UpdateDrivers()
        {
            return clsDrivers.UpdateDriver(this.DriverID, this.PersonID, this.CreatedByUserID, this.CreatedDate);
        }
        public bool SaveDrivers()
        {

            switch (_mode)
            {
                case enMode.AddNew:
                    if (_AddNewDrivers())
                    {

                        _mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateDrivers();
            }
            return false;
        }
        public static clsDriver FindDriver(int DriverID)
        {
            int PersonID = -1;
            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            if (clsDrivers.FindDriver(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
            {

                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllDrivers()
        {
            return clsDrivers.GetAllDrivers();
        }
         public static DataTable GetAllLocalLicensesByDriverID(int DriverID)
        {
            return clsDrivers.GetAllLocalLicensesByDriverID(DriverID);
        }
         public static DataTable GetAllInternationalicesnsesByDriverID(int DriverID)
        {
            return clsDrivers.GetAllInternationalicesnsesByDriverID(DriverID);
        }


        public static DataTable GetDriversInfo(string ColumnName,string Value)
        {
            return clsDrivers.GetDriversInfo(ColumnName, Value);
        }


        public static int GetDriverIDByPersonID(int PersonID)
        {
            return clsDrivers.GetDriverIDByPersonID(PersonID);
        }


    }

}
