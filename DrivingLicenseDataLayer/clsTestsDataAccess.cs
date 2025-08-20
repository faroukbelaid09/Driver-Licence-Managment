using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DrivingLicenseDataLayer
{
    public class clsTestsDataAccess
    {
        public static int Create(int testappointmentid,int testresult,string testnote,int createdbyuser)
        {
            int TestID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            
            string query = @"Insert into Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID)
                            Values(@testappointmentid, @testresult, @testnote, @createdbyuser);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@testappointmentid", testappointmentid);
            command.Parameters.AddWithValue("@testresult", testresult);
            command.Parameters.AddWithValue("@testnote", testnote);
            command.Parameters.AddWithValue("@createdbyuser", createdbyuser);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TestID = insertedID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("DB: Error when adding a test in DB.\n" + ex.Message);
            }
            finally
            {
                connection?.Close();
            }
            return TestID;

        }
        public static void CheckTestResult(int testAppointmentID, ref int testResult)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select TestResult from Tests where TestAppointmentID = @testAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@testAppointmentID", testAppointmentID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    testResult = (int)reader["TestResult"];
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection?.Close();
            }
        }
    }
}
