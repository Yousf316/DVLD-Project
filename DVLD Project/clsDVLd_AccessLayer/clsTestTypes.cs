using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Access
{
    public class clsTestTypes
    {

        

        static public bool UpdateTestType(int TestTypeID, string TestTypeTitle, string TestTypeDescription, float TestTypeFees)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"UPDATE [dbo].[TestTypes] 
  SET [TestTypeTitle] = @TestTypeTitle
,[TestTypeDescription] = @TestTypeDescription
,[TestTypeFees] = @TestTypeFees
WHERE TestTypeID =@TestTypeID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            cmd.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            cmd.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);
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

        static public bool FindTestType(int TestTypeID, ref string TestTypeTitle, ref string TestTypeDescription, ref float TestTypeFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[TestTypes] WHERE TestTypeID =@TestTypeID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID); try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    TestTypeTitle = (string)reader["TestTypeTitle"];
                    TestTypeDescription = (string)reader["TestTypeDescription"];
                    TestTypeFees = Convert.ToInt64(reader["TestTypeFees"]);

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

        static public DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLdDataAccessSettings.ConnectionString);
            string query = @"Select * FROM [dbo].[TestTypes]";

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
