using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Access
{
    public  class clsDrivers
    {
        static public void InsertDriver(ref int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO [dbo].[Drivers]
 ([PersonID],[CreatedByUserID],[CreatedDate])
 VALUES
(@PersonID,@CreatedByUserID,@CreatedDate);
Select SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, connection);

           
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    DriverID = ID;
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


        static public bool UpdateDriver(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"UPDATE [dbo].[Drivers] 
 SET[PersonID] = @PersonID
,[CreatedByUserID] = @CreatedByUserID
,[CreatedDate] = @CreatedDate
WHERE DriverID =@DriverID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@CreatedDate", CreatedDate);
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

        static public bool FindDriver(int DriverID, ref int PersonID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[Drivers] WHERE DriverID =@DriverID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound=true;
                    PersonID = (int)reader["PersonID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
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

        static public bool DeleteDriver(int DriverID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"DELETE  FROM [dbo].[Drivers] WHERE DriverID =@DriverID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@DriverID", DriverID);
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


        static public DataTable GetAllDrivers()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"Select * FROM [DVLD].[dbo].[Drivers_View]";

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
         static public DataTable GetAllLocalLicensesByDriverID(int DriverID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"SELECT dbo.Licenses.LicenseID, dbo.Licenses.ApplicationID, dbo.LicenseClasses.ClassName, dbo.Licenses.IssueDate, dbo.Licenses.ExpirationDate, dbo.Licenses.IsActive
FROM     dbo.Licenses INNER JOIN
                  dbo.LicenseClasses ON dbo.LicenseClasses.LicenseClassID = dbo.Licenses.LicenseClass
				  where Licenses.DriverID=@DriverID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
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
         static public DataTable GetAllInternationalicesnsesByDriverID(int DriverID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"SELECT  [InternationalLicenseID]
      ,[ApplicationID]
      ,[DriverID]
      ,[IssuedUsingLocalLicenseID]
      ,[IssueDate]
      ,[ExpirationDate]
      ,[IsActive]
      
  FROM [DVLD].[dbo].[InternationalLicenses]
  where DriverID=@DriverID;";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
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

        static public DataTable GetDriversInfo(string ColumnName, string Value)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"Select * FROM [DVLD].[dbo].[Drivers_View] where " + ColumnName + " LIKE  '" + Value + "%'";

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

         static public int GetDriverIDByPersonID(int PersonID)
        {
            int DriverID = -1;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"SELECT[DriverID]
      
  FROM [DVLD].[dbo].[Drivers]
  where PersonID=@PersonID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();

              if(result !=null&&int.TryParse(result.ToString(), out int _DriverID))
                {
                    DriverID = _DriverID;
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

            return DriverID;
        }

    }
}
