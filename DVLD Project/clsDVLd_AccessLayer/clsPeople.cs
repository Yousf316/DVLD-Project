using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Access
{
    public class clsPeople
    {
        static public void InsertPerson(ref int PersonID, string NationalNo, string FirstName,
            string SecondName, string ThirdName,
            string LastName, DateTime DateOfBirth,
            int Gendor, string Address, string Phone,
            string Email, int NationalityCountryID, string ImagePath)
        {
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO [dbo].[People]
 ([NationalNo],[FirstName],[SecondName],[ThirdName],[LastName],[DateOfBirth],[Gendor],[Address],[Phone],[Email],[NationalityCountryID],[ImagePath])
 VALUES
(@NationalNo,@FirstName,@SecondName,@ThirdName,@LastName,@DateOfBirth,@Gendor,@Address,@Phone,@Email,@NationalityCountryID,@ImagePath);
Select SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, connection);

            
            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@SecondName", SecondName);
            if (ThirdName != "" && ThirdName != null)
                cmd.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                cmd.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);

            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@Gendor", Gendor);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            if (Email != "" && Email != null)
                cmd.Parameters.AddWithValue("@Email", Email);
            else
                cmd.Parameters.AddWithValue("@Email", System.DBNull.Value);

            cmd.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (ImagePath != "" && ImagePath != null)
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                cmd.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    PersonID = ID;
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

        static public bool UpdatePerson(int PersonID,
            string NationalNo, string FirstName, string SecondName,
            string ThirdName, string LastName, DateTime DateOfBirth,
            int Gendor, string Address, string Phone, string Email,
            int NationalityCountryID, string ImagePath)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"UPDATE [dbo].[People] 
 SET [NationalNo] = @NationalNo
,[FirstName] = @FirstName
,[SecondName] = @SecondName
,[ThirdName] = @ThirdName
,[LastName] = @LastName
,[DateOfBirth] = @DateOfBirth
,[Gendor] = @Gendor
,[Address] = @Address
,[Phone] = @Phone
,[Email] = @Email
,[NationalityCountryID] = @NationalityCountryID
,[ImagePath] = @ImagePath
WHERE PersonID =@PersonID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@SecondName", SecondName);
            if (ThirdName != "" && ThirdName != null)
                cmd.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                cmd.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);

            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@Gendor", Gendor);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            if (Email != "" && Email != null)
                cmd.Parameters.AddWithValue("@Email", Email);
            else
                cmd.Parameters.AddWithValue("@Email", System.DBNull.Value);

            cmd.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (ImagePath != "" && ImagePath != null)
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                cmd.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

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

        static public bool FindPerson(int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref int Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[People] WHERE PersonID =@PersonID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    NationalNo = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];

                    if (reader["ThirdName"] != DBNull.Value)
                        ThirdName = (string)reader["ThirdName"];

                    else
                        ThirdName = "";
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                     Gendor =Convert.ToInt32(reader["Gendor"]);
                    
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];

                    else
                        Email = "";
                    NationalityCountryID = (int)reader["NationalityCountryID"];

                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];

                    else
                        ImagePath = "";
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

        static public bool DeletePerson(int PersonID)
        {
            int rowsAffected = -1;
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"DELETE  FROM [dbo].[People] WHERE PersonID =@PersonID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);
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

        static public bool IsExists(string NationalNo)
        {
          bool isFound = false; 
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"Select PersonID FROM [dbo].[People] WHERE NationalNo =@NationalNo ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.HasRows)
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

        static public bool IsExists(string NationalNo,ref int PersonID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"Select PersonID FROM [dbo].[People] WHERE NationalNo =@NationalNo ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result !=null && int.TryParse(result.ToString(),out int _PersonID))
                {
                    PersonID = _PersonID;
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

        static public bool IsExists(int PersonID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"Select Find='X' FROM [dbo].[People] WHERE PersonID =@PersonID ;";
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

        static public DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"Select * FROM People_View";

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


        static public DataTable GetPersonInfo(int PersonID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"Select * FROM People_View where PersonID=@PersonID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);

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

        static public DataTable GetPersonInfo(string ColumnName,string Value)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"Select * FROM People_View  where "+ ColumnName+" LIKE  '"+ Value +"%'";

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
