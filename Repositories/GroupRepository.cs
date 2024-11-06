using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Repositories.Model;

namespace Repositories
{
    public class GroupRepository
    {
        static DocManaContext docManaContext = new DocManaContext();

        private static string connectionString = docManaContext.getConnectionString();

        public List<Group> getDataGroup(string departmentID)
        {
            List<Group> groupList = new List<Group>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Groups WHERE DepartmentID = @departmentID", connection);
                    command.Parameters.AddWithValue("@departmentID", departmentID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Group group = new Group
                            {
                                GroupId = reader["GroupID"].ToString() ?? string.Empty,
                                GroupName = reader["GroupName"]?.ToString(),
                                DepartmentId = reader["DepartmentID"]?.ToString(),
                                LeaderId = reader["LeaderID"]?.ToString(),
                                CreateDate = reader["CreateDate"] != DBNull.Value ? (DateTime?)reader["CreateDate"] : null,
                                ModifiedDate = reader["ModifiedDate"] != DBNull.Value ? (DateTime?)reader["ModifiedDate"] : null
                            };

                            groupList.Add(group);
                        }
                    }
                    return groupList;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string createGroup(string groupName, string departmentID, string leaderID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("addGroup", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@GroupName", groupName);
                    command.Parameters.AddWithValue("@DeparmentID", departmentID);
                    command.Parameters.AddWithValue("@LeaderID", leaderID);

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

        public string updateDepartment(string groupID, string groupName, string leaderID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("updateGroup", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@GroupID", groupID);
                    command.Parameters.AddWithValue("@GroupName", groupName);
                    command.Parameters.AddWithValue("@LeaderID", leaderID);

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
