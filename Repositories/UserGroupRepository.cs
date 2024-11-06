using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Repositories.Model;

namespace Repositories
{
    public class UserGroupRepository
    {
        static DocManaContext docManaContext = new DocManaContext();

        private static string connectionString = docManaContext.getConnectionString();

        //public List<User> getUserGroup(string groupID)
        //{
        //    List<User> userList = new List<User>();
        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            connection.Open();

        //            SqlCommand command = new SqlCommand("SELECT Users.* FROM Users, User_Groups where Users.UserID = User_Groups.UserID and User_Groups.GroupID = @GroupID", connection);
        //            command.Parameters.AddWithValue("@GroupID", groupID);

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
        public List<UserGroup> getUserGroup(string groupID)
        {
            List<UserGroup> userGroupList = new List<UserGroup>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM User_Groups WHERE User_Groups.GroupID = @GroupID", connection);
                    command.Parameters.AddWithValue("@GroupID", groupID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserGroup userGroup = new UserGroup
                            {
                                UserId = reader["UserID"].ToString(),
                                GroupId = reader["GroupID"].ToString(),
                                Role = reader["Role"].ToString(),
                                JoinedDate = reader["JoinedDate"] != DBNull.Value ? (DateTime?)reader["JoinedDate"] : null,
                            };
                            userGroupList.Add(userGroup);
                        }
                    }
                    return userGroupList;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string createUserGroup(string userID, string groupID, string role)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("addUser_Group", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@GroupID", groupID);
                    command.Parameters.AddWithValue("@Role", role);

                    SqlParameter messageParam = new SqlParameter("@Message", System.Data.SqlDbType.NVarChar, 200)
                    {
                        Direction = System.Data.ParameterDirection.Output
                    };
                    command.Parameters.Add(messageParam);

                    command.ExecuteNonQuery();

                    return messageParam.ToString();
                }
            }
            catch (Exception ex)
            {
                return "Connection Failed";
            }
        }
        public string updateUserGroup(string userID, string groupID, string role)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("updateUser_Group", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@GroupID", groupID);
                    command.Parameters.AddWithValue("@Role", role);

                    SqlParameter messageParam = new SqlParameter("@Message", System.Data.SqlDbType.NVarChar, 200)
                    {
                        Direction = System.Data.ParameterDirection.Output
                    };
                    command.Parameters.Add(messageParam);

                    command.ExecuteNonQuery();

                    return messageParam.ToString();
                }
            }
            catch (Exception ex)
            {
                return "Connection Failed";
            }
        }
    }
}
