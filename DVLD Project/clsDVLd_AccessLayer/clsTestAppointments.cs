using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_Access
{

    public class clsTestAppointments
    {

        static public void InsertTestAppointment(ref int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, float PaidFees, int CreatedByUserID, bool IsLocked)
        {
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO [dbo].[TestAppointments]
 ([TestTypeID],[LocalDrivingLicenseApplicationID],[AppointmentDate],[PaidFees],[CreatedByUserID],[IsLocked])
 VALUES
(@TestTypeID,@LocalDrivingLicenseApplicationID,@AppointmentDate,@PaidFees,@CreatedByUserID,@IsLocked);
Select SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, connection);

            
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@IsLocked", IsLocked);
            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    TestAppointmentID = ID;
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

        static public bool UpdateTestAppointment(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, float PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"Update  TestAppointments  
                            set TestTypeID = @TestTypeID,
                                LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID,
                                AppointmentDate = @AppointmentDate,
                                PaidFees = @PaidFees,
                                CreatedByUserID = @CreatedByUserID,
                                IsLocked=@IsLocked,
                                RetakeTestApplicationID=@RetakeTestApplicationID
                                where TestAppointmentID = @TestAppointmentID";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@IsLocked", IsLocked);

            if (RetakeTestApplicationID == -1)

                cmd.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);


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

        static public bool FindTestAppointment(int TestAppointmentID, ref int TestTypeID, ref int LocalDrivingLicenseApplicationID, ref DateTime AppointmentDate, ref float PaidFees, ref int CreatedByUserID, ref bool IsLocked,ref int RetakeTestApplicationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[TestAppointments] WHERE TestAppointmentID =@TestAppointmentID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound= true;
                    TestTypeID = (int)reader["TestTypeID"];
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    PaidFees = Convert.ToSingle(reader["PaidFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    
                    IsLocked = (bool)reader["IsLocked"];

                    if (reader["RetakeTestApplicationID"] == DBNull.Value)
                        RetakeTestApplicationID = -1;
                    else
                        RetakeTestApplicationID = (int)reader["RetakeTestApplicationID"];
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

        static public bool DeleteTestAppointment(int TestAppointmentID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"DELETE  FROM [dbo].[TestAppointments] WHERE TestAppointmentID =@TestAppointmentID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
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

        static public DataTable GetAllTestAppointments(int LocalDrivingLicenseApplicationID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"Select * FROM [dbo].[TestAppointments] where LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID; ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

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
         static public DataTable GetApplicantTestAppointments(int LocalDrivingLicenseApplicationID,int TestTypeID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"SELECT [TestAppointmentID]  
      ,[AppointmentDate]
      ,[PaidFees]
      ,[IsLocked]
  FROM [DVLD].[dbo].[TestAppointments_View]
  where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID and TestTypeID=@TestTypeID ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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

        static public bool IsExists(int LocalDrivingLicenseApplicationID,int TestTypeID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"SELECT top 1 Found=1
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID 
                                
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                            AND(TestAppointments.TestTypeID = @TestTypeID)
                            ORDER BY TestAppointments.TestAppointmentID desc;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result!=null)
                {
                    IsFound = true;
                }

            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }
        static public bool IsUnLocked(int LocalDrivingLicenseApplicationID,int TestTypeID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"SELECT top 1 Found=1
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID 
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)  
                            AND(TestAppointments.TestTypeID = @TestTypeID) and isLocked=0
                            ORDER BY TestAppointments.TestAppointmentID desc";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result !=null )
                {
                    IsFound = true;
                }

            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }
         static public bool IsPassedTest(int LocalDrivingLicenseApplicationID,int TestTypeID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"SELECT top 1 TestResult
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                 Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                            AND(TestAppointments.TestTypeID = @TestTypeID)
                            ORDER BY TestAppointments.TestAppointmentID desc";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result !=null&& bool.TryParse(result.ToString(), out bool Result))
                {
                    IsFound = Result;
                }

            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

         static public int GetTestID(int TestAppointmentID)
        {
            int TestID = -1;
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"select TestID from Tests where TestAppointmentID=@TestAppointmentID;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result !=null&& int.TryParse(result.ToString(), out int Result))
                {
                    TestID = Result;
                }

            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return TestID;
        }
         static public int GetTrailsPersonInTest(int LocalDrivingLicenseApplicationID,int TestTypeID)
        {
            int TestID = -1;
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"select count(TestID)as TestID from
TestAppointments inner join Tests on Tests.TestAppointmentID=TestAppointments.TestAppointmentID
where TestAppointments.LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID and TestAppointments.TestTypeID=@TestTypeID
";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result !=null&& int.TryParse(result.ToString(), out int Result))
                {
                    TestID = Result;
                }

            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return TestID;
        }




    }
}
