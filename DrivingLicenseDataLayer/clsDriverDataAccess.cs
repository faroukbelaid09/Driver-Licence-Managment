using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicenseDataLayer
{
    public class clsDriverDataAccess
    {
        public static int CreateDriver(int PersonID, int CreatedByUserID, string CreatedDate)
        {
            int DriverID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Insert into Drivers (PersonID, CreatedByUserID, CreatedDate)
                            Values(@PersonID, @CreatedByUserID, @CreatedDate);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    DriverID = insertedID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("DB: Error when creating a driver in DB.\n" + ex.Message);
            }
            finally
            {
                connection?.Close();
            }

            return DriverID;
        }
    
        public static bool Find(int personid)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select 1 from Drivers
                            where PersonID = @personid";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@personid", personid);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.HasRows)
                {
                    isFound = true;
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
            return isFound;
        }
        
        public static int GetDriverID(int personID)
        {
            int DriverID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select DriverID from Drivers
                            where PersonID = @personID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@personID", personID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    DriverID = insertedID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("DB: Error when getting driverID from DB.\n" + ex.Message);
            }
            finally
            {
                connection?.Close();
            }

            return DriverID;
        }
    
        public static DataTable GetAllDrivers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            string query = @"select Drivers.*, DriverName = People.FirstName+People.LastName, 
                            CreatedBy = Users.UserName from Drivers inner join People on 
                            Drivers.PersonID = People.PersonID inner join users on 
                            Drivers.CreatedByUserID = Users.UserID";

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
    }
}
