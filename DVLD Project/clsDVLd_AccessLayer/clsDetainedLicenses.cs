using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Access
{
    public  class clsDetainedLicenses
    {

        static public void InsertDetainendLicense(ref int DetainID, int LicenseID, DateTime DetainDate, float FineFees, int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO [dbo].[DetainedLicenses]
 ([LicenseID],[DetainDate],[FineFees],[CreatedByUserID],[IsReleased])
 VALUES
(@LicenseID,@DetainDate,@FineFees,@CreatedByUserID,0);
Select SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
            cmd.Parameters.AddWithValue("@DetainDate", DetainDate);
            cmd.Parameters.AddWithValue("@FineFees", FineFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            
           
             

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    DetainID = ID;
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

        static public bool UpdateDetainendLicense(int DetainID, int LicenseID, DateTime DetainDate, float FineFees, int CreatedByUserID, bool IsReleased, DateTime? ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);

            string query = @"UPDATE [dbo].[DetainedLicenses] 
 SET [LicenseID] = @LicenseID
,[DetainDate] = @DetainDate
,[FineFees] = @FineFees
,[CreatedByUserID] = @CreatedByUserID
,[IsReleased] = @IsReleased
,[ReleaseDate] = @ReleaseDate
,[ReleasedByUserID] = @ReleasedByUserID
,[ReleaseApplicationID] = @ReleaseApplicationID
WHERE DetainID =@DetainID ;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@DetainID", DetainID);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
            cmd.Parameters.AddWithValue("@DetainDate", DetainDate);
            cmd.Parameters.AddWithValue("@FineFees", FineFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@IsReleased", IsReleased);
            if ( ReleaseDate != null&& ReleaseDate != DateTime.MaxValue)
                cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            else
                cmd.Parameters.AddWithValue("@ReleaseDate", System.DBNull.Value);

            if (ReleasedByUserID != -1 && ReleasedByUserID != null)
                cmd.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            else
                cmd.Parameters.AddWithValue("@ReleasedByUserID", System.DBNull.Value);

            if (ReleaseApplicationID != -1 && ReleaseApplicationID != null)
                cmd.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            else
                cmd.Parameters.AddWithValue("@ReleaseApplicationID", System.DBNull.Value);

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

        static public bool FindDetainendLicense(int DetainID, ref int LicenseID, ref DateTime DetainDate, ref float FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime? ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[DetainedLicenses] WHERE DetainID =@DetainID ;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@DetainID", DetainID);
            
            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    LicenseID = (int)reader["LicenseID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = Convert.ToSingle(reader["FineFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];

                    if (reader["ReleaseDate"] != DBNull.Value)
                        ReleaseDate = (DateTime)reader["ReleaseDate"];

                    else
                        ReleaseDate = null;

                    if (reader["ReleasedByUserID"] != DBNull.Value)
                        ReleasedByUserID = (int)reader["ReleasedByUserID"];

                    else
                        ReleasedByUserID = -1;

                    if (reader["ReleaseApplicationID"] != DBNull.Value)
                        ReleaseApplicationID = (int)reader["ReleaseApplicationID"];

                    else
                        ReleaseApplicationID = -1;

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

        static public bool DeleteDetainendLicense(int DetainID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"DELETE * FROM [dbo].[DetainedLicenses] WHERE DetainID =@DetainID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@DetainID", DetainID);
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

        static public DataTable GetAllDetainedLicenses()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"SELECT [DetainID]
      ,[DetainedLicenses].[LicenseID]
	  ,People_View.FirstName+' '+People_View.SecondName+' '+ISNULL(People_View.ThirdName,'')+' '+People_View.LastName as FullName
      ,[DetainDate]
      ,[FineFees]
      ,[DetainedLicenses].[CreatedByUserID]
      ,[IsReleased]
      ,[ReleaseDate]
      ,[ReleasedByUserID]
      ,[ReleaseApplicationID]
  FROM [DVLD].[dbo].[DetainedLicenses] inner join Licenses on Licenses.LicenseID = DetainedLicenses.LicenseID
  inner join Applications on Applications.ApplicationID =Licenses.ApplicationID
  inner join People_View on People_View.PersonID =Applications.ApplicantPersonID";

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

        static public bool IsLicenseDetaiend(int LicenseID)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"SELECT Found='x'
  FROM [DVLD].[dbo].[DetainedLicenses]
  where DetainedLicenses.LicenseID=@LicenseID and DetainedLicenses.IsReleased=0
";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result !=null)

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
         static public int GetDetainIDByDetainedLicense(int LicenseID)
        {

            int DetainID = -1;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"select DetainID from DetainedLicenses 
where DetainedLicenses.LicenseID=@LicenseID and DetainedLicenses.IsReleased=0
";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result !=null && int.TryParse(result.ToString(),out int _DetainID))

                {
                    DetainID = _DetainID;

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

            return DetainID;
        }



        static public DataTable GetDetainedLicenseInfo(string ColumnName, string Value)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"select * from
(
SELECT [DetainID]
      ,[DetainedLicenses].[LicenseID]
	  ,People_View.FirstName+' '+People_View.SecondName+' '+ISNULL(People_View.ThirdName,'')+' '+People_View.LastName as FullName
      ,[DetainDate]
      ,[FineFees]
      ,[DetainedLicenses].[CreatedByUserID]
      ,[IsReleased]
      ,[ReleaseDate]
      ,[ReleasedByUserID]
      ,[ReleaseApplicationID]
  FROM [DVLD].[dbo].[DetainedLicenses] inner join Licenses on Licenses.LicenseID = DetainedLicenses.LicenseID
  inner join Applications on Applications.ApplicationID =Licenses.ApplicationID
  inner join People_View on People_View.PersonID =Applications.ApplicantPersonID
  ) R1
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
