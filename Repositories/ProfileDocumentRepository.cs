using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Repositories.Model;

namespace Repositories
{
    public class ProfileDocumentRepository
    {
        static DocManaContext docManaContext = new DocManaContext();

        private static string connectionString = docManaContext.getConnectionString();

        public List<Document> getProfileDocument(string profileID)
        {
            List<Document> documentList = new List<Document>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    //SqlCommand command = new SqlCommand("SELECT Documents.* FROM Profile_Documents, Documents WHERE Documents.DocumentID =  Profile_Documents.DocumentID and Profile_Documents.ProfileID = @ProfileID", connection);
                    SqlCommand command = new SqlCommand("SELECT * FROM Documents", connection);
                    //command.Parameters.AddWithValue("@ProfileID", profileID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Document document = new Document
                            {
                                DocumentId = reader["DocumentID"].ToString(),
                                DocumentName = reader["DocumentName"].ToString(),
                                ProjectId = reader["ProjectID"].ToString(),
                                Version = reader["Version"].ToString(),
                                Status = reader["Status"].ToString(),
                                SubmittedBy = reader["SubmittedBy"].ToString(),
                                CreatedDate = reader["CreatedDate"] != DBNull.Value ? (DateTime?)reader["CreatedDate"] : null,
                                ModifiedDate = reader["ModifiedDate"] != DBNull.Value ? (DateTime?)reader["ModifiedDate"] : null
                            };
                            documentList.Add(document);
                        }
                    }
                    return documentList;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string createProfileDocument(string profileID, string documentID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("addProfile_Document", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ProfileID", profileID);
                    command.Parameters.AddWithValue("@DocumentID", documentID);

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
