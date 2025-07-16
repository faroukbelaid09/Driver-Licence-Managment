using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicenseDataLayer
{
    public class clsTestTypesDataAccess
    {
        public static DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select * from TestTypes";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection?.Close();
            }

            return dt;

        }

        public static bool UpdateTestType(int testID, string testTitle,string TestDesc, int testFees)
        {
            bool isUpdated = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update TestTypes 
                           Set TestTypeTitle = @testTitle, TestTypeDescription = @TestDesc, TestTypeFees = @testFees
                           Where TestTypeID = @testID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@testID", testID);
            command.Parameters.AddWithValue("@testTitle", testTitle);
            command.Parameters.AddWithValue("@TestDesc", TestDesc);
            command.Parameters.AddWithValue("@testFees", testFees);

            try
            {
                connection.Open();
                int rowAffected = command.ExecuteNonQuery();

                if (rowAffected > 0)
                {
                    isUpdated = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("DB: Error when updating test." + ex.ToString());
            }
            finally
            {
                connection?.Close();
            }

            return isUpdated;

        }
    }
}
