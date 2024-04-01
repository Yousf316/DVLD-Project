using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Access
{
    public class clsLicenseClasses
    {

       

        static public bool UpdateLicenseClass(int LicenseClassID, string ClassName, string ClassDescription, int MinimumAllowedAge, int DefaultValidityLength, float ClassFees)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"UPDATE [dbo].[LicenseClasses] 
 ( SET[ClassName] = @ClassName
,[ClassDescription] = @ClassDescription
,[MinimumAllowedAge] = @MinimumAllowedAge
,[DefaultValidityLength] = @DefaultValidityLength
,[ClassFees] = @ClassFees
WHERE LicenseClassID =@LicenseClassID ;)";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            cmd.Parameters.AddWithValue("@ClassName", ClassName);
            cmd.Parameters.AddWithValue("@ClassDescription", ClassDescription);
            cmd.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
            cmd.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
            cmd.Parameters.AddWithValue("@ClassFees", ClassFees);
            try
            {
                connection.Open();

                rowsAffected = cmd.ExecuteNonQuery();


            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        static public bool FindLicenseClass(int LicenseClassID, ref string ClassName, ref string ClassDescription, ref int MinimumAllowedAge, ref int DefaultValidityLength, ref float ClassFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[LicenseClasses] WHERE LicenseClassID =@LicenseClassID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID); try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    ClassName = (string)reader["ClassName"];
                    ClassDescription = (string)reader["ClassDescription"];
                    MinimumAllowedAge = Convert.ToInt32(reader["MinimumAllowedAge"]);
                    DefaultValidityLength = Convert.ToInt32(reader["DefaultValidityLength"]);
                    ClassFees = Convert.ToUInt64(reader["ClassFees"]);
                    isFound =true;
                }

                reader.Close();
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        static public DataTable GetAllLicenseClasses()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"Select * FROM [dbo].[LicenseClasses]";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                clsEventLogs.WriteLog($"An error occurred: {ex.Message} ", System.Diagnostics.EventLogEntryType.Error);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        static public bool GetLicenseClassID(ref int LicenseClassID, string ClassName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"SELECT LicenseClassID FROM [dbo].[LicenseClasses] WHERE ClassName =@ClassName ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ClassName", ClassName); 
            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result !=null && int.TryParse(result.ToString(),out int _LicenseClassID))
                {
                    LicenseClassID = _LicenseClassID;
                    isFound = true;
                }

               
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

    }
}
