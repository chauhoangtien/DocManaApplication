using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using Repositories.Model;

namespace Services
{
    public class DocumentService
    {
        DocumentRepository documentRepository = new DocumentRepository();

        public Document getDocument(string documentID)
        {
            return documentRepository.getDocument(documentID);
        }

        public string createDocument(DateOnly date, string projectID, string documentName, string version, string status, string submittedBy, string filePath)
        {
            return documentRepository.createDocument(date, projectID, documentName, version, status, submittedBy, filePath);
        }

        public string updateDocument(string documentID, string status)
        {
            return documentRepository.updateDocument(documentID, status);
        }
    }
}
