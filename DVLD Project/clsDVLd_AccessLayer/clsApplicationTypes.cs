using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Access
{
    public class clsApplicationTypes
    {

        static public bool UpdateApplicationType(int ApplicationTypeID, string ApplicationTypeTitle, float ApplicationFees)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"UPDATE [dbo].[ApplicationTypes] 
  SET [ApplicationTypeTitle] = @ApplicationTypeTitle
,[ApplicationFees] = @ApplicationFees
WHERE ApplicationTypeID =@ApplicationTypeID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            cmd.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            cmd.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
            try
            {
                connection.Open();

                rowsAffected = cmd.ExecuteNonQuery();


            }
            catch(Exception ex)
            
            {
                clsEventLogs.WriteLog($"An error occurred: {ex.Message} ", System.Diagnostics.EventLogEntryType.Error);
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        static public bool FindApplicationType(int ApplicationTypeID, ref string ApplicationTypeTitle, ref float ApplicationFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[ApplicationTypes] WHERE ApplicationTypeID =@ApplicationTypeID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                    ApplicationFees = Convert.ToInt64(reader["ApplicationFees"]);
                    isFound = true;
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


        static public DataTable GetAllApplicationTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"Select * FROM [dbo].[ApplicationTypes]";

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
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }
        static public bool GetApplicationTypeID(ref int ApplicationTypeID,  string ApplicationTypeTitle)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"SELECT ApplicationTypeID FROM [dbo].[ApplicationTypes] WHERE ApplicationTypeTitle =@ApplicationTypeTitle ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);

            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(),out int _AppID))
                {
                    ApplicationTypeID =_AppID;
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
