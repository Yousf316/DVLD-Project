using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DVLD_Access
{
    static public  class clsDVLdDataAccessSettings
    {

        //static public  string ConnectionString = "Server=.; Database =DVLD; User Id=sa; Password =123456;";
        static public string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        
    }
}
