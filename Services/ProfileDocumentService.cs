using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using Repositories.Model;

namespace Services
{
    public class ProfileDocumentService
    {
        ProfileDocumentRepository profileDocumentRepository = new ProfileDocumentRepository();

        public List<Document> getProfileDocument(string profileID)
        {
            return profileDocumentRepository.getProfileDocument(profileID);
        }
        public string createProfileDocument(string profileID, string documentID)
        {
            return profileDocumentRepository.createProfileDocument(profileID, documentID);
        }
    }
}
