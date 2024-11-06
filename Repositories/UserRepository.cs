using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using Repositories.Model;
using User = Repositories.Model.User;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Repositories
{
    public class UserRepository
    {
        static DocManaContext docManaContext = new DocManaContext();

        private static string connectionString = docManaContext.getConnectionString();

        public User getUser(string userID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM Users where UserID = @UserID", connection);
                    command.Parameters.AddWithValue("@UserID", userID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            User user = new User
                            {
                                UserId = reader["UserID"].ToString(),
                                Password = reader["Password"].ToString(),
                                FullName = reader["FullName"].ToString(),
                                Address = reader["Address"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                Email = reader["Email"].ToString(),
                                Avatar = reader["Avatar"] != DBNull.Value ? (byte[])reader["Avatar"] : null,
                                Role = reader["Role"].ToString(),
                                Status = reader["Status"].ToString(),
                                CreateDate = reader["CreateDate"] != DBNull.Value ? (DateTime?)reader["CreateDate"] : null,
                                ModifiedDate = reader["ModifiedDate"] != DBNull.Value ? (DateTime?)reader["ModifiedDate"] : null
                            };

                            return user;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<User> getDataUser_CEO()
        {
            List<User> userList = new List<User>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM Users ", connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User
                            {
                                UserId = reader["UserID"].ToString(),
                                Password = reader["Password"].ToString(),
                                FullName = reader["FullName"].ToString(),
                                Address = reader["Address"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                Email = reader["Email"].ToString(),
                                Avatar = reader["Avatar"] != DBNull.Value ? (byte[])reader["Avatar"] : null,
                                Role = reader["Role"].ToString(),
                                Status = reader["Status"].ToString(),
                                CreateDate = reader["CreateDate"] != DBNull.Value ? (DateTime?)reader["CreateDate"] : null,
                                ModifiedDate = reader["ModifiedDate"] != DBNull.Value ? (DateTime?)reader["ModifiedDate"] : null
                            };
                            userList.Add(user);
                        }
                        return userList;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<User> getManagerID()
        {
            List<User> userList = new List<User>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM Users where Role = N'Quản lý'", connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User
                            {
                                UserId = reader["UserID"].ToString(),
                                Password = reader["Password"].ToString(),
                                FullName = reader["FullName"].ToString(),
                                Address = reader["Address"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                Email = reader["Email"].ToString(),
                                Avatar = reader["Avatar"] != DBNull.Value ? (byte[])reader["Avatar"] : null,
                                Role = reader["Role"].ToString(),
                                Status = reader["Status"].ToString(),
                                CreateDate = reader["CreateDate"] != DBNull.Value ? (DateTime?)reader["CreateDate"] : null,
                                ModifiedDate = reader["ModifiedDate"] != DBNull.Value ? (DateTime?)reader["ModifiedDate"] : null
                            };
                            userList.Add(user);
                        }
                        return userList;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<User> getUserID()
        {
            List<User> userList = new List<User>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM Users where Role <> N'Giám đốc'", connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User
                            {
                                UserId = reader["UserID"].ToString(),
                                Password = reader["Password"].ToString(),
                                FullName = reader["FullName"].ToString(),
                                Address = reader["Address"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                Email = reader["Email"].ToString(),
                                Avatar = reader["Avatar"] != DBNull.Value ? (byte[])reader["Avatar"] : null,
                                Role = reader["Role"].ToString(),
                                Status = reader["Status"].ToString(),
                                CreateDate = reader["CreateDate"] != DBNull.Value ? (DateTime?)reader["CreateDate"] : null,
                                ModifiedDate = reader["ModifiedDate"] != DBNull.Value ? (DateTime?)reader["ModifiedDate"] : null
                            };
                            userList.Add(user);
                        }
                        return userList;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string checkRole(string userID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT Role FROM Users WHERE UserID = @userID", connection);
                    command.Parameters.AddWithValue("@userID", userID);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        return $"{reader["Role"]}";
                    }
                    return "User has no role yet";
                }
            }
            catch (Exception ex)
            {
                return "Connection Failed";
            }
        }
        public string createUser(string password, string fullname, string gender, string email, string role)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("addUser", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@FullName", fullname);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Role", role);

                    SqlParameter messageParam = new SqlParameter("@Message", System.Data.SqlDbType.NVarChar, 200)
                    {
                        Direction = System.Data.ParameterDirection.Output
                    };
                    command.Parameters.Add(messageParam);

                    command.ExecuteNonQuery();

                    return messageParam.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                return "Connection Failed";
            }
        }
        public string updateUser(string userID, string password, string fullname, string address, string gender, byte[] avatar, string role, string status)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("updateUser", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@FullName", fullname);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@Avatar", avatar);
                    command.Parameters.AddWithValue("@Role", role);
                    command.Parameters.AddWithValue("@Status", status);

                    SqlParameter messageParam = new SqlParameter("@Message", System.Data.SqlDbType.NVarChar, 200)
                    {
                        Direction = System.Data.ParameterDirection.Output
                    };
                    command.Parameters.Add(messageParam);

                    command.ExecuteNonQuery();

                    return messageParam.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                return "Connection Failed";
            }
        }
        public int countUserActive_CEO()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Users where Status = N'Hoạt động'";
                    SqlCommand cmdQuery = new SqlCommand(query, connection);
                    int rowCount = (int)cmdQuery.ExecuteScalar();
                    return rowCount;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public int countUserDeActive_CEO()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Users where Status <> N'Hoạt động'";
                    SqlCommand cmdQuery = new SqlCommand(query, connection);
                    int rowCount = (int)cmdQuery.ExecuteScalar();
                    return rowCount;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public bool blockUser(string userID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Update Users set Status = N'Bị khóa' where UserID = @userID", connection);
                    command.Parameters.AddWithValue("@userID", userID);

                    int affectedRows = command.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string checkStatus(string userID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT Status FROM Users WHERE UserID = @userID", connection);
                    command.Parameters.AddWithValue("@userID", userID);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        return $"{reader["Status"]}";
                    }
                    return "User has no role yet";
                }
            }
            catch (Exception ex)
            {
                return "Connection Failed";
            }
        }
    }
}
