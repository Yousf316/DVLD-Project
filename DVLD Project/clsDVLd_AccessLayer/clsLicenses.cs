using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Access
{
    public class clsLicenses
    {

        static public void InsertLicense(ref int LicenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, float PaidFees, bool IsActive, int IssueReason, int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO [dbo].[Licenses]
 ([ApplicationID],[DriverID],[LicenseClass],[IssueDate],[ExpirationDate],[Notes],[PaidFees],[IsActive],[IssueReason],[CreatedByUserID])
 VALUES
(@ApplicationID,@DriverID,@LicenseClass,@IssueDate,@ExpirationDate,@Notes,@PaidFees,@IsActive,@IssueReason,@CreatedByUserID);
Select SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            if (Notes != "" && Notes != null)
                cmd.Parameters.AddWithValue("@Notes", Notes);
            else
                cmd.Parameters.AddWithValue("@Notes", System.DBNull.Value);

            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            cmd.Parameters.AddWithValue("@IssueReason", IssueReason);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    LicenseID = ID;
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

        static public bool UpdateLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, float PaidFees, bool IsActive, int IssueReason, int CreatedByUserID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"UPDATE [dbo].[Licenses] 
  SET[ApplicationID] = @ApplicationID
,[DriverID] = @DriverID
,[LicenseClass] = @LicenseClass
,[IssueDate] = @IssueDate
,[ExpirationDate] = @ExpirationDate
,[Notes] = @Notes
,[PaidFees] = @PaidFees
,[IsActive] = @IsActive
,[IssueReason] = @IssueReason
,[CreatedByUserID] = @CreatedByUserID
WHERE LicenseID =@LicenseID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            if (Notes != "" && Notes != null)
                cmd.Parameters.AddWithValue("@Notes", Notes);
            else
                cmd.Parameters.AddWithValue("@Notes", System.DBNull.Value);

            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            cmd.Parameters.AddWithValue("@IssueReason", IssueReason);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
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

        static public bool FindLicense(int LicenseID, ref int ApplicationID, ref int DriverID, ref int LicenseClass, ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes, ref float PaidFees, ref bool IsActive, ref int IssueReason, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[Licenses] WHERE LicenseID =@LicenseID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LicenseID", LicenseID); try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClass = (int)reader["LicenseClass"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];

                    if (reader["Notes"] != DBNull.Value)
                        Notes = (string)reader["Notes"];

                    else
                        Notes = "";
                    PaidFees = Convert.ToSingle(reader["PaidFees"]);
                    IsActive = (bool)reader["IsActive"];
                    IssueReason = Convert.ToInt32(reader["IssueReason"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
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


        static public bool DeleteLicense(int LicenseID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"DELETE  FROM [dbo].[Licenses] WHERE LicenseID =@LicenseID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
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

        static public DataTable GetAllLicenses()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"Select * FROM [dbo].[Licenses]";

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
        static public bool IsLicenseExsitsByApplicationID(int ApplicationID)
        {
           bool Found=false;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"select Found=1 from Licenses where Licenses.ApplicationID=@ApplicationID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result !=null)

                {
                    Found=true;
                }

               


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return Found;
        }

        static public bool ThereIsLicenseActive(int DriverID,int LicenseClass)
        {
            bool Found = false;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"select Found=1 from Licenses where Licenses.DriverID=@DriverID and IsActive=1 and LicenseClass=@LicenseClass
";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@LicenseClass", LicenseClass);

            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)

                {
                    Found = true;
                }




            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return Found;
        }
        static public bool IsLicenseExsits(int LicenseID)
        {
            bool Found = false;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"select Found=1 from Licenses where LicenseID=@LicenseID
";

            SqlCommand cmd = new SqlCommand(query, connection);
          
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)

                {
                    Found = true;
                }




            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return Found;
        }

         static public int GetLicenseIDByApplicationID(int ApplicationID)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"select Licenses.LicenseID from Licenses 
where Licenses.ApplicationID=@ApplicationID
";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
        

            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(),out int _LicenseID ))

                {
                    LicenseID = _LicenseID;
                }




            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return LicenseID ;
            
        }


    }
}
