using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Access
{
    public class clsUsers
    {
        static public void InsertUser(ref int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO [dbo].[Users]
 ([PersonID],[UserName],[Password],[IsActive])
 VALUES
(@PersonID,@UserName,@Password,@IsActive);
Select SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, connection);

           
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    UserID = ID;
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


        static public bool UpdateUser(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"UPDATE [dbo].[Users] 
  SET [PersonID] = @PersonID
,[UserName] = @UserName
,[Password] = @Password
,[IsActive] = @IsActive
WHERE UserID =@UserID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
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

        static public bool FindUser(int UserID, ref int PersonID, ref string UserName, ref string Password, ref bool IsActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[Users] WHERE UserID =@UserID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserID", UserID); try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
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
        static public bool FindUserByUsernameAndPassword( string UserName,   string Password ,ref int UserID,ref int PersonID, ref bool IsActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[Users] WHERE UserName =@UserName and Password=@Password;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
                
               try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    UserID = (int)reader["UserID"];
                   
                    IsActive = (bool)reader["IsActive"];
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

        static public bool DeleteUser(int UserID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"DELETE  FROM [dbo].[Users] WHERE UserID =@UserID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);
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

        static public DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"Select * FROM [dbo].[View_Users]";

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



        static public DataTable GetUserInfo(string ColumnName, string Value)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"Select * FROM [dbo].[View_Users]  where " + ColumnName + " LIKE  '" + Value + "%'";

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

        static public bool IsExists(int PersonID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"Select UserID FROM [dbo].[View_Users] WHERE PersonID =@PersonID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
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

        static public bool IsExists(string UserName,ref int UserID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"Select UserID FROM [dbo].[View_Users] WHERE UserName =@UserName ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(),out int _UserID))
                {
                    UserID=_UserID;
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


        static public bool IsExists(string UserName,string Password,ref int UserID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"Select UserID FROM [dbo].[Users] WHERE UserName =@UserName and Password=@Password ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
           
            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int _UserID))
                {
                    UserID = _UserID;
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

          static public bool IsActive(int UserID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"Select IsActive FROM [dbo].[View_Users] WHERE UserID =@UserID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);
           
           
            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result != null && bool.TryParse(result.ToString(), out bool _UserID))
                {
                    
                    isFound = _UserID;
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
