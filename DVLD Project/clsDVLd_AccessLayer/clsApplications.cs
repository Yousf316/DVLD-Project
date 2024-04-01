using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Access
{
    public  class clsApplications
    {
        static public void InsertApplication(ref int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO [dbo].[Applications]
 ([ApplicantPersonID],[ApplicationDate],[ApplicationTypeID],[ApplicationStatus],[LastStatusDate],[PaidFees],[CreatedByUserID])
 VALUES
(@ApplicantPersonID,@ApplicationDate,@ApplicationTypeID,@ApplicationStatus,@LastStatusDate,@PaidFees,@CreatedByUserID);
Select SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, connection);

            
            cmd.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            cmd.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            cmd.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            cmd.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    ApplicationID = ID;
                }

            }
            catch (Exception ex) 
            {
                clsEventLogs.WriteLog($"An error occurred: {ex.Message} ", System.Diagnostics.EventLogEntryType.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        static public bool UpdateApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"UPDATE [dbo].[Applications] 
  SET [ApplicantPersonID] = @ApplicantPersonID
,[ApplicationDate] = @ApplicationDate
,[ApplicationTypeID] = @ApplicationTypeID
,[ApplicationStatus] = @ApplicationStatus
,[LastStatusDate] = @LastStatusDate
,[PaidFees] = @PaidFees
,[CreatedByUserID] = @CreatedByUserID
WHERE ApplicationID =@ApplicationID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            cmd.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            cmd.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            cmd.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
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

        static public bool FindApplication(int ApplicationID, ref int ApplicantPersonID, ref DateTime ApplicationDate, ref int ApplicationTypeID, ref byte ApplicationStatus, ref DateTime LastStatusDate, ref float PaidFees, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[Applications] WHERE ApplicationID =@ApplicationID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    ApplicantPersonID = (int)reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = Convert.ToInt64(reader["PaidFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    isFound = true;
                }

                reader.Close();
            }
            catch(Exception ex) 
            {
                clsEventLogs.WriteLog($"An error occurred: {ex.Message} ", System.Diagnostics.EventLogEntryType.Error);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        static public DataTable GetAllApplications()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"Select * FROM [dbo].[Applications]";

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

        static public bool DeleteApplication(int ApplicationID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"DELETE  FROM [dbo].[Applications] WHERE ApplicationID =@ApplicationID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
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

        static public bool IsExists(int ApplicationID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"Select Find='X' FROM [dbo].[Applications] WHERE ApplicationID =@ApplicationID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    isFound = true;
                }

            }
            catch( Exception ex ) 
            {
                clsEventLogs.WriteLog($"An error occurred: {ex.Message} ", System.Diagnostics.EventLogEntryType.Error);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        static public bool IsExists(int ApplicantPersonID,int LicenseClassID,ref int Status)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"select Applications.ApplicationStatus from Applications
inner join  LocalDrivingLicenseApplications on Applications.ApplicationID =LocalDrivingLicenseApplications.ApplicationID
where Applications.ApplicantPersonID =@ApplicantPersonID and LocalDrivingLicenseApplications.LicenseClassID=@LicenseClassID";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result !=null &&int.TryParse(result.ToString(),out int _Status))
                {
                    isFound = true;
                    Status = _Status;
                }

            }
            catch(Exception ex ) 
            {
                clsEventLogs.WriteLog($"An error occurred: {ex.Message} ", System.Diagnostics.EventLogEntryType.Error);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
          static public bool IsExists(int ApplicantPersonID,int ApplicationTypeID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"Select Find='X' FROM [dbo].[Applications] WHERE ApplicantPersonID =@ApplicantPersonID and ApplicationTypeID =@ApplicationTypeID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    isFound = true;
                }

            }
            catch( Exception ex ) 
            {
                clsEventLogs.WriteLog($"An error occurred: {ex.Message} ", System.Diagnostics.EventLogEntryType.Error);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        static public bool UpdateStatus(int ApplicationID, byte ApplicationStatus)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"UPDATE [dbo].[Applications] 
  SET 
[ApplicationStatus] = @ApplicationStatus
,[LastStatusDate] = @LastStatusDate
WHERE ApplicationID =@ApplicationID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            
            cmd.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            cmd.Parameters.AddWithValue("@LastStatusDate", DateTime.Now);
          
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

    }
}
