using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using Repositories.Model;

namespace Repositories
{
    public class DeparmentRepository
    {
        static DocManaContext docManaContext = new DocManaContext();

        private static string connectionString = docManaContext.getConnectionString();

        public List<Department> getDepartmentDataCEO()
        {
            List<Department> departmentList = new List<Department>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Departments", connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Department department = new Department
                            {
                                DepartmentId = reader["DepartmentID"].ToString() ?? string.Empty,
                                DepartmentName = reader["DepartmentName"]?.ToString(),
                                ManagerId = reader["ManagerID"]?.ToString(),
                                Description = reader["Description"]?.ToString(),
                                CreateDate = reader["CreateDate"] != DBNull.Value ? (DateTime?)reader["CreateDate"] : null,
                                ModifiedDate = reader["ModifiedDate"] != DBNull.Value ? (DateTime?)reader["ModifiedDate"] : null
                            };

                            departmentList.Add(department);
                        }
                    }
                    return departmentList;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Department> getDepartmentDataManager(string managerID)
        {
            List<Department> departmentList = new List<Department>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Departments where ManagerID = @ManagerID", connection);
                    command.Parameters.AddWithValue("@ManagerID", managerID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Department department = new Department
                            {
                                DepartmentId = reader["DepartmentID"].ToString() ?? string.Empty,
                                DepartmentName = reader["DepartmentName"]?.ToString(),
                                ManagerId = reader["ManagerID"]?.ToString(),
                                Description = reader["Description"]?.ToString(),
                                CreateDate = reader["CreateDate"] != DBNull.Value ? (DateTime?)reader["CreateDate"] : null,
                                ModifiedDate = reader["ModifiedDate"] != DBNull.Value ? (DateTime?)reader["ModifiedDate"] : null
                            };

                            departmentList.Add(department);
                        }
                    }
                    return departmentList;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string createDepartment(string departmentName, string managerID, string description) 
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("addDeparment", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@DepartmentName", departmentName);
                    command.Parameters.AddWithValue("@ManagerID", managerID);
                    command.Parameters.AddWithValue("@Description", description);

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

        public string updateDepartment(string departmentID, string managerID, string description)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("updateDepartment", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@DepartmentID", departmentID);
                    command.Parameters.AddWithValue("@ManagerID", managerID);
                    command.Parameters.AddWithValue("@Description", description);

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
