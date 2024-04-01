using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Access
{
    public class clsLocalDrivingLicenseApplications
    {
        static public void InsertLocalDrivingLicenseApplication(ref int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO [dbo].[LocalDrivingLicenseApplications]
 ([ApplicationID],[LicenseClassID])
 VALUES
(@ApplicationID,@LicenseClassID);
Select SCOPE_IDENTITY();";


            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    LocalDrivingLicenseApplicationID = ID;
                }

            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
        }


        static public bool UpdateLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"UPDATE [dbo].[LocalDrivingLicenseApplications] 
 SET [ApplicationID] = @ApplicationID
,[LicenseClassID] = @LicenseClassID
WHERE LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
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


        static public bool FindLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, ref int ApplicationID, ref int LicenseClassID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[LocalDrivingLicenseApplications] WHERE LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID); try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    ApplicationID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
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

        static public bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"DELETE  FROM [dbo].[LocalDrivingLicenseApplications] WHERE LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
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

        static public DataTable GetAllLocalDrivingLicenseApplications()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[LocalDrivingLicenseApplications_View]";

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


        static public DataTable GetLocalDrivingLicenseApplicationInfo(string ColumnName, string Value)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"Select * FROM [dbo].[LocalDrivingLicenseApplications_View]  where " + ColumnName + " LIKE  '" + Value + "%'";

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


    }
}
