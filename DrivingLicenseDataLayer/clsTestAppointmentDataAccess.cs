using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicenseDataLayer
{
    public class clsTestAppointmentDataAccess
    {
        public static int Create(int testtypeid, int localdrivingappid, string appointmentdate,
            int paidfees, int createdbyuserid, int islocked, int retaketestappid)
        {
            int TestAppointmentID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Insert into TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID,
                            AppointmentDate,PaidFees, IsLocked, RetakeTestApplicationID)
                            Values(@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, 
                            @PaidFees, @IsLocked, @RetakeTestApplicationID);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", testtypeid);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localdrivingappid);
            command.Parameters.AddWithValue("@AppointmentDate", appointmentdate);
            command.Parameters.AddWithValue("@PaidFees", paidfees);
            command.Parameters.AddWithValue("@IsLocked", islocked);
            if(retaketestappid != null)
            {
                command.Parameters.AddWithValue("@RetakeTestApplicationID", retaketestappid);
            }
            else
            {
                command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            }

                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        TestAppointmentID = insertedID;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("DB: Error when creating a test appointment in DB.\n" + ex.Message);
                }
                finally
                {
                    connection?.Close();
                }

            return TestAppointmentID;
        }
    
        public static DataTable GetAllVisionAppointmentsTest(int localDrivingLicenseAppID)
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from TestAppointments where 
                            TestAppointments.LocalDrivingLicenseApplicationID = @localdrivingappid
                            and TestTypeID = 1";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@localdrivingappid", localDrivingLicenseAppID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    table.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex.Message);
            }
            finally
            {
                connection?.Close();
            }

            return table;
        }

        public static DataTable GetAllWritingAppointmentsTest(int localDrivingLicenseAppID)
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from TestAppointments where 
                            TestAppointments.LocalDrivingLicenseApplicationID = @localdrivingappid
                            and TestTypeID = 2";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@localdrivingappid", localDrivingLicenseAppID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    table.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex.Message);
            }
            finally
            {
                connection?.Close();
            }

            return table;
        }

        public static DataTable GetAllStreetAppointmentsTest(int localDrivingLicenseAppID)
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from TestAppointments where 
                            TestAppointments.LocalDrivingLicenseApplicationID = @localdrivingappid
                            and TestTypeID = 3";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@localdrivingappid", localDrivingLicenseAppID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    table.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex.Message);
            }
            finally
            {
                connection?.Close();
            }

            return table;
        }

        public static bool FindTestAppointment(int testAppointmentID,ref int testtypeid,ref int localdrivingappid, 
           ref string appointmentdate,ref int paidfees,ref int createdbyuserid,ref int islocked,ref int retaketestappid)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select top 1 * from TestAppointments where 
                            TestAppointments.LocalDrivingLicenseApplicationID = @localdrivingappid
                            order by TestAppointmentID desc";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@localdrivingappid", localdrivingappid);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    found = true;

                    testtypeid = (int)reader["TestTypeID"];
                    localdrivingappid = (int)reader["LocalDrivingLicenseApplicationID"];
                    appointmentdate = ((DateTime)reader["AppointmentDate"]).ToString();
                    paidfees = (int)reader["PaidFees"];
                    createdbyuserid = (int)reader["CreatedByUserID"];
                    islocked = (int)reader["IsLocked"];
                    retaketestappid = reader["RetakeTestApplicationID"] != null 
                        ? (int)reader["RetakeTestApplicationID"] : -1;
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                found = false;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection?.Close();
            }
            return found;
        }

    }
}
