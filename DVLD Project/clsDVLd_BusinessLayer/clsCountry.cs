using DVLD_Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Access;

namespace DVLD_Business
{
    public class clsCountry
    {
        static public DataTable GetAllCountries()
        {
            return clsCountries.GetAllCountries();
        }

        static public int GetCountryID(string CountryName)
        {
            int CountryID = -1;
            clsCountries.FindDBCountries(ref CountryID,CountryName);
            
            return CountryID;
        }

        public static string FindCountries(int CountryID)
        {
            string CountryName = "";

            if (clsCountries.FindCountries(CountryID, ref CountryName))
            {

                return CountryName;
            }
            else
            {
                return null;
            }
        }

    }
}
