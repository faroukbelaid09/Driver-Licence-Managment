﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Security.Policy;

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

        public static bool CheckIfUserNameExist(string username)
        {
            bool found = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select 1 from Users where Users.UserName = @username;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);

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
                Console.WriteLine("DB: Error when looking for a user in DB.\n" + ex.Message);
            }
            finally
            {
                connection?.Close();
            }

            return found;
        }
        public static bool FindUserByUserNameAndPassword(ref int userID, ref int personID,ref string username,ref string password,ref bool isActive)
        {
            bool userFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            string query = "select * from Users where UserName = @username and Password = @password";

            SqlCommand command = new SqlCommand(query, connection);

            Console.WriteLine("USN: " + username);
            Console.WriteLine("PASS: " + password);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())

                {
                    userID = (int)reader["UserID"];
                    personID = (int)reader["PersonID"];
                    username = (string)reader["UserName"];
                    //fullname = (string)reader["FullName"];
                    password = (string)reader["Password"];
                    isActive = (bool)reader["IsActive"];

                    userFound = true;
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

            return userFound;
        }
        public static DataTable GetUsers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            string query = "select Users.*, FullName = People.FirstName+People.LastName from Users inner join People on Users.PersonID = People.PersonID";

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
        
        public static bool UpdateUser(int UserID, string UserName, string Password,bool IsActive)
        {
            bool isUpdated = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update Users 
                           Set UserName = @UserName, Password = @Password,IsActive = @IsActive
                           Where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

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
                Console.WriteLine("DB: Error when updating user." + ex.ToString());
            }
            finally
            {
                connection?.Close();
            }

            return isUpdated;
        }

        public static bool DeleteUser(int UserID)
        {
            bool isDeleted = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Delete from Users where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                int rowAffected = command.ExecuteNonQuery();

                if (rowAffected > 0)
                {
                    isDeleted = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("DB: Error when deleting this user.");
            }
            finally
            {
                connection?.Close();
            }
            return isDeleted;
        }
    }
}
