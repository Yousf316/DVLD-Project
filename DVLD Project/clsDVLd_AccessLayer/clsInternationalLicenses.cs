using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Access
{
    public class clsInternationalLicenses
    {
        static public void InsertInternationalLicense(ref int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO [dbo].[InternationalLicenses]
 ([ApplicationID],[DriverID],[IssuedUsingLocalLicenseID],[IssueDate],[ExpirationDate],[IsActive],[CreatedByUserID])
 VALUES
(@ApplicationID,@DriverID,@IssuedUsingLocalLicenseID,@IssueDate,@ExpirationDate,@IsActive,@CreatedByUserID);
Select SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    InternationalLicenseID = ID;
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

        static public bool UpdateInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"UPDATE [dbo].[InternationalLicenses] 
  SET[ApplicationID] = @ApplicationID
,[DriverID] = @DriverID
,[IssuedUsingLocalLicenseID] = @IssuedUsingLocalLicenseID
,[IssueDate] = @IssueDate
,[ExpirationDate] = @ExpirationDate
,[IsActive] = @IsActive
,[CreatedByUserID] = @CreatedByUserID
WHERE InternationalLicenseID =@InternationalLicenseID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
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

        static public bool FindInternationalLicense(int InternationalLicenseID, ref int ApplicationID, ref int DriverID, ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[InternationalLicenses] WHERE InternationalLicenseID =@InternationalLicenseID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID); try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    IsActive = (bool)reader["IsActive"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
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

        static public bool DeleteInternationalLicense(int InternationalLicenseID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"DELETE * FROM [dbo].[InternationalLicenses] WHERE InternationalLicenseID =@InternationalLicenseID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
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

        static public DataTable GetAllInternationalLicenses()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"SELECT [InternationalLicenseID]
      ,[ApplicationID]
      ,InternationalLicenses.[DriverID]
	  ,People.FirstName +' '+People.SecondName +' '+ IsNull(People.ThirdName,'')+' '+People.LastName as FullName
      ,[IssuedUsingLocalLicenseID]
      ,[IssueDate]
      ,[ExpirationDate]
      ,[IsActive]
      ,InternationalLicenses.[CreatedByUserID]
  FROM [dbo].[InternationalLicenses] inner join Drivers on Drivers.DriverID=InternationalLicenses.DriverID
  inner join People on People.PersonID =Drivers.PersonID";

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

        static public bool IsThereInernationalLicenseWithLocalLicense(int IssuedUsingLocalLicenseID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"SELECT Found=1
  FROM [DVLD].[dbo].[InternationalLicenses]
  where InternationalLicenses.IssuedUsingLocalLicenseID=@IssuedUsingLocalLicenseID
";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);

            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result!=null)

                {
                   IsFound = true;
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

            

            return IsFound;
        }

        static public DataTable GetInternationalLicenseInfo(string ColumnName, string Value)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"select  * from(
SELECT [InternationalLicenseID]
      ,[ApplicationID]
      ,InternationalLicenses.[DriverID]
	  ,People.FirstName +' '+People.SecondName +' '+ IsNull(People.ThirdName,'')+' '+People.LastName as FullName
      ,[IssuedUsingLocalLicenseID]
      ,[IssueDate]
      ,[ExpirationDate]
      ,[IsActive]
      ,InternationalLicenses.[CreatedByUserID]
  FROM [dbo].[InternationalLicenses] inner join Drivers on Drivers.DriverID=InternationalLicenses.DriverID
  inner join People on People.PersonID =Drivers.PersonID
  )R1
where R1." + ColumnName + " LIKE  '" + Value + "%'";

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
