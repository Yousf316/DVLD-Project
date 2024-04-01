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

    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _mode = enMode.AddNew;

        int PersonID { get; set; }
        string NationalNo { get; set; }
        string FirstName { get; set; }
        string SecondName { get; set; }
        string ThirdName { get; set; }
        string LastName { get; set; }
        DateTime DateOfBirth { get; set; }
       public int Age { get {return   DateTime.Now.Year- DateOfBirth.Year; } }
        int Gendor { get; set; }
        string Address { get; set; }
        string Phone { get; set; }
        string Email { get; set; }
        int NationalityCountryID { get; set; }
        string ImagePath { get; set; }
        public clsPerson()
        {
            this.PersonID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Gendor = 0;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";
            _mode = enMode.AddNew;
        }
        private clsPerson(int PersonID, string NationalNo, string FirstName, string SecondName,
            string ThirdName, string LastName, DateTime DateOfBirth, int Gendor,
            string Address, string Phone, string Email, int NationalityCountryID,
            string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
            _mode = enMode.Update;
        }

        public bool SetPersoninfo(string NationalNo, string FirstName, string SecondName,
            string ThirdName, string LastName, DateTime DateOfBirth, int Gendor,
            string Address, string Phone, string Email, int NationalityCountryID,
            string ImagePath)
        {
            if (NationalNo == "" || FirstName == "" || SecondName == "" || LastName == ""
                || Address == "" || Phone == "")
            {
                return false;
            }

            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;

            return true;
        }
        private bool _AddNewPeople()
        {
            int ID = -1;
            clsPeople.InsertPerson(ref ID, this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
            this.PersonID = ID;
            return this.PersonID != -1;
        }
        private bool _UpdatePeople()
        {
            return clsPeople.UpdatePerson(this.PersonID, this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
        }
        public bool SavePeople()
        {

            switch (_mode)
            {
                case enMode.AddNew:
                    if (_AddNewPeople())
                    {

                        _mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePeople();
            }
            return false;
        }


        public static clsPerson FindPerson(int PersonID)
        {
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            int Gendor = -1;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            if (clsPeople.FindPerson(PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {

                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else
            {
                return null;
            }
        }

        public int GetPersonID()
        {
            return this.PersonID;
        }

        public string GetFullName()
        {
            return this.FirstName + " " + this.SecondName
                + " " +this.ThirdName+" "+ this.LastName;
        }

        public string GetFirstName()
        {
            return this.FirstName ;
        }

        public string GetSecondName()
        {
            return  this.SecondName;
        }

        public string GetLastName()
        {
            return this.LastName;
        }
        public string GetThirdName()
        {
            return this.ThirdName;
        }
        public string GetPhoneNumber()
        {
            return this.Phone;
        }

        public DateTime GetBirthDate()
        {
            return this.DateOfBirth;
        }

        public int GetGender()
        {
            return this.Gendor;
        }

        public string GetGenderName()
        {
            return (this.Gendor == 0) ? "Male" : "Femal";
        }

        public int GetNationalityCountryID()
        {
            return this.NationalityCountryID;
        }

        public string GetImagePath()
        {
            return this.ImagePath;
        }

        public string GetEmail()
        {
            return this.Email;
        }

        public string GetAddress()
        {
            return this.Address;
        }

        public string GetNationalNo()
        {
            return this.NationalNo;
        }

        static public bool IsExists(string NationalNo)
        {
            return clsPeople.IsExists(NationalNo);
        }
        static public bool IsExists(int PersonID)
        {
            return clsPeople.IsExists(PersonID);
        }

        static public bool IsExists(string NationalNo,ref int PersonID)
        {
            return clsPeople.IsExists(NationalNo,ref PersonID);
        }
        static string GetCountryName(int CountryID)
        {
            return clsCountry.FindCountries(CountryID);
        }

        public string GetDefaultImage()
        {

            if (this.Gendor == 1)
            {

                return "C:\\Users\\USERZ\\Desktop\\DVLD Project\\Icons\\person_girl.png";


            }
            else
            {
                return "C:\\Users\\USERZ\\Desktop\\DVLD Project\\Icons\\person_man.png";


            }

            

        }


       static public DataTable GetAllPeopleInfo()
        {
            return clsPeople.GetAllPeople();
        }

        static public DataTable GetPersonInfo(int PersonID)
        {
            return clsPeople.GetPersonInfo(PersonID);
        }

        static public DataTable GetPersonInfo(string ColumnName,string Value)
        {
            return clsPeople.GetPersonInfo(ColumnName,Value);
        }

        static public bool DeletePerson(int PersonID)
        {
            return clsPeople.DeletePerson(PersonID);
        }
    }
}

