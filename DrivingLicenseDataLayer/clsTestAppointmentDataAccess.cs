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
                            AppointmentDate,PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID)
                            Values(@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, 
                            @PaidFees, @createdbyuserid, @IsLocked, @RetakeTestApplicationID);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", testtypeid);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localdrivingappid);
            command.Parameters.AddWithValue("@AppointmentDate", appointmentdate);
            command.Parameters.AddWithValue("@PaidFees", paidfees);
            command.Parameters.AddWithValue("@createdbyuserid", createdbyuserid);
            command.Parameters.AddWithValue("@IsLocked", islocked);
            
            if(retaketestappid != -1)
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
    
        public static bool Update(int testappointmentid,int testtypeid, int localdrivingappid, string appointmentdate,
            int paidfees, int createdbyuserid, int islocked, int retaketestappid)
        {
            bool isUpdated = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update TestAppointments 
                           Set TestTypeID = @testtypeid, LocalDrivingLicenseApplicationID = @localdrivingappid, 
                            AppointmentDate = @appointmentdate,PaidFees = @paidfees, CreatedByUserID = @createdbyuserid, 
                            IsLocked = @islocked,RetakeTestApplicationID=@retaketestappid
                            Where TestAppointmentID = @testappointmentid";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@testappointmentid", testappointmentid);
            command.Parameters.AddWithValue("@testtypeid", testtypeid);
            command.Parameters.AddWithValue("@localdrivingappid", localdrivingappid);
            command.Parameters.AddWithValue("@appointmentdate", appointmentdate);
            command.Parameters.AddWithValue("@paidfees", paidfees);
            command.Parameters.AddWithValue("@createdbyuserid", createdbyuserid);
            command.Parameters.AddWithValue("@islocked", islocked);

            if (retaketestappid != -1)
            {
                command.Parameters.AddWithValue("@retaketestappid", retaketestappid);
            }
            else
            {
                command.Parameters.AddWithValue("@retaketestappid", DBNull.Value);
            }


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
                Console.WriteLine("DB: Error when updating test appointment." + ex.ToString());
            }
            finally
            {
                connection?.Close();
            }

            return isUpdated;

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
                            and TestAppointments.TestTypeID = 2";

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

        public static bool UpdateRetakeAppID(int testAppointmentID, int retakeID)
        {
            bool updated = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update TestAppointments 
                           Set RetakeTestApplicationID = @retakeID
                           Where TestAppointmentID = @testAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@retakeID", retakeID);
            command.Parameters.AddWithValue("@testAppointmentID", testAppointmentID);

            try
            {
                Console.WriteLine("::::RETAKE:::: " + retakeID + "##" + testAppointmentID);
                connection.Open();
                int rowAffected = command.ExecuteNonQuery();

                if (rowAffected > 0)
                {
                    updated = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("DB: Error when updating test appointment." + ex.ToString());
            }
            finally
            {
                connection?.Close();
            }

            return updated;
        }
    }
}
