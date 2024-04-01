using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Access
{
    public class clsTests
    {
        static public void InsertTest(ref int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO [dbo].[Tests]
 ([TestAppointmentID],[TestResult],[Notes],[CreatedByUserID])
 VALUES
(@TestAppointmentID,@TestResult,@Notes,@CreatedByUserID);
Select SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            cmd.Parameters.AddWithValue("@TestResult", TestResult);
            if (Notes != "" && Notes != null)
                cmd.Parameters.AddWithValue("@Notes", Notes);
            else
                cmd.Parameters.AddWithValue("@Notes", System.DBNull.Value);

            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    TestID = ID;
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

        static public bool UpdateTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"UPDATE [dbo].[Tests] 
 ( SET[TestAppointmentID] = @TestAppointmentID
,[TestResult] = @TestResult
,[Notes] = @Notes
,[CreatedByUserID] = @CreatedByUserID
WHERE TestID =@TestID ;)";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestID", TestID);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            cmd.Parameters.AddWithValue("@TestResult", TestResult);
            if (Notes != "" && Notes != null)
                cmd.Parameters.AddWithValue("@Notes", Notes);
            else
                cmd.Parameters.AddWithValue("@Notes", System.DBNull.Value);

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

        static public bool DeleteTest(int TestID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"DELETE * FROM [dbo].[Tests] WHERE TestID =@TestID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestID", TestID);
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

        static public bool FindTest(int TestID, ref int TestAppointmentID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[Tests] WHERE TestID =@TestID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestID", TestID); 
            
            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    TestResult = (bool)reader["TestResult"];

                    if (reader["Notes"] != DBNull.Value)
                        Notes = (string)reader["Notes"];

                    else
                        Notes = "";
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

        static public DataTable GetAllTests()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"Select * FROM [dbo].[Tests]";

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

        static public bool GetTestResult(int DLApplication, ref int Result)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"SELECT dbo.LocalDrivingLicenseApplications_View. PassedTestCount    
  FROM [DVLD].[dbo].[LocalDrivingLicenseApplications_View]
 where dbo.LocalDrivingLicenseApplications_View.LocalDrivingLicenseApplicationID =@DLApplication";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@DLApplication", DLApplication);
            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int _Result))
                {
                    Result = _Result;
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
