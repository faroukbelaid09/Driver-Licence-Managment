using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicenseDataLayer
{
    public class clsUserDataAccess
    {
        public static bool CheckIfUserExist(int personID)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select 1 from Users where Users.PersonID = @personID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@personID", personID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int res))
                {
                    found = true;
                }
            }
            catch (Exception ex)
            {
                found = false;
                Console.WriteLine("DB: Error when adding a user in DB.\n" + ex.Message);
            }
            finally
            {
                connection?.Close();
            }

            return found;
        }
        public static int AddUser(int PersonID,string UserName,string Password,bool IsActive)
        {
            int UserID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Insert into Users (PersonID, UserName, Password, IsActive)
                            Values(@PersonID, @UserName, @Password, @IsActive);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    UserID = insertedID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("DB: Error when adding a user in DB.\n" + ex.Message);
            }
            finally
            {
                connection?.Close();
            }
            return UserID;
        }
    }
}
