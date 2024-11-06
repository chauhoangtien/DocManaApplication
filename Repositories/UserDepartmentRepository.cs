using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Repositories.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Repositories
{
    public class UserDepartmentRepository
    {
        static DocManaContext docManaContext = new DocManaContext();

        private static string connectionString = docManaContext.getConnectionString();

        //public List<User> getUserDepartment(string departmentID)
        //{
        //    List<User> userList = new List<User>();
        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            connection.Open();

        //            SqlCommand command = new SqlCommand("SELECT Users.* FROM Users, User_Departments where Users.UserID = User_Departments.UserID and User_Departments.DepartmentID = @DepartmentID", connection);
        //            command.Parameters.AddWithValue("@DepartmentID", departmentID);

        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    User user = new User
        //                    {
        //                        UserId = reader["UserID"].ToString(),
        //                        Password = reader["Password"].ToString(),
        //                        FullName = reader["FullName"].ToString(),
        //                        Address = reader["Address"].ToString(),
        //                        Gender = reader["Gender"].ToString(),
        //                        Email = reader["Email"].ToString(),
        //                        Avatar = reader["Avatar"] != DBNull.Value ? (byte[])reader["Avatar"] : null,
        //                        Role = reader["Role"].ToString(),
        //                        Status = reader["Status"].ToString(),
        //                        CreateDate = reader["CreateDate"] != DBNull.Value ? (DateTime?)reader["CreateDate"] : null,
        //                        ModifiedDate = reader["ModifiedDate"] != DBNull.Value ? (DateTime?)reader["ModifiedDate"] : null
        //                    };
        //                    userList.Add(user);
        //                }
        //            }
        //            return userList;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}

        public List<UserDepartment> getUserDepartment(string departmentID)
        {
            List<UserDepartment> userDepartmentList = new List<UserDepartment>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM User_Departments WHERE User_Departments.DepartmentID = @DepartmentID", connection);
                    command.Parameters.AddWithValue("@DepartmentID", departmentID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserDepartment userDepartment = new UserDepartment
                            {
                                UserId = reader["UserID"].ToString(),
                                DepartmentId = reader["DepartmentID"].ToString(),
                                Role = reader["Role"].ToString(),
                                JoinedDate = reader["JoinedDate"] != DBNull.Value ? (DateTime?)reader["JoinedDate"] : null,
                            };
                            userDepartmentList.Add(userDepartment);
                        }
                    }
                    return userDepartmentList;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string createUserDepartment(string userID, string departmentID, string role)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("addUser_Department", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@DepartmentID", departmentID);
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
        public string updateUserDepartment(string userID, string departmentID, string role)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("updateUser_Department", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@DepartmentID", departmentID);
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
    }
}
