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
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _mode = enMode.AddNew;

        int UserID { get; set; }
        int PersonID { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        bool _IsActive { get; set; }
        public clsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this._IsActive = false;
            _mode = enMode.AddNew;
        }
        private clsUser(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this._IsActive = IsActive;
            _mode = enMode.Update;
        }
        public bool UserColumns( int PersonID, string UserName, string Password, bool IsActive)
        {
            if (PersonID == -1 || UserName == "" || Password == "")
                return false;


           
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this._IsActive = IsActive;
            return true;
        }

        public bool UpdatePassword( string Password)
        {
            if (Password == "")
                return false;



            this.Password = Password;
           
            return true;
        }
        private bool _AddNewUsers()
        {
            int ID = -1;
            clsUsers.InsertUser(ref ID, this.PersonID, this.UserName, this.Password, this._IsActive);
            this.UserID = ID;
            return this.UserID != -1;
        }
        private bool _UpdateUsers()
        {
            return clsUsers.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this._IsActive);
        }
        public bool SaveUsers()
        {

            switch (_mode)
            {
                case enMode.AddNew:
                    if (_AddNewUsers())
                    {

                        _mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateUsers();
            }
            return false;
        }

        public static clsUser FindUser(int UserID)
        {
            int PersonID = -1;
            string UserName = "";
            string Password = "";
            bool IsActive = false;

            if (clsUsers.FindUser(UserID, ref PersonID, ref UserName, ref Password, ref IsActive))
            {

                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            else
            {
                return null;
            }


        }
         public static clsUser FindUserByUserNameAndPassword(string UserName, string Password)
        {
            int PersonID = -1;
            int UserID = -1;
          
            
            bool IsActive = false;

            if (clsUsers.FindUserByUsernameAndPassword( UserName, Password,ref UserID,ref PersonID, ref IsActive))
            {

                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            else
            {
                return null;
            }


        }

        public static DataTable GetAllUsers()
        {


            return clsUsers.GetAllUsers();



        }


        public static DataTable GetUserInfo(string ColumnName,string Value)
        {


            return clsUsers.GetUserInfo(ColumnName, Value);



        }

        public static bool IsExists(int PersonID)
        {
            return clsUsers.IsExists(PersonID);
        }

        public int GetPersonID()
        {
            return PersonID;
        }

        public string GetPassword()
        {
            return Password;
        }
        public string GetUserName()
        {
            return this.UserName;
        }

        public bool GetIsActive()
        {
            return _IsActive;
        }

        public int GetUserID()
        {
            return UserID;
        }


        public static bool IsExists(string UserName)
        {
            int UserID = -1;
            return clsUsers.IsExists(UserName, ref UserID);
        }
         public static bool IsActive(int UserID)
        {
            
            return clsUsers.IsActive(UserID);
        }

        public static int GetUserID(string UserName)
        {
            int UserID = -1;

            clsUsers.IsExists(UserName, ref UserID);

            return UserID;
        }
        public static int GetUserID(string UserName,string Password)
        {
            int UserID = -1;

            clsUsers.IsExists(UserName, Password, ref UserID);

            return UserID;
        }


        public static bool DeleteUser(int UserID)
        {
            return clsUsers.DeleteUser(UserID);
        }
    }

}


