using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using Repositories.Model;

namespace Services
{
    public class ProfileService
    {
        ProfileRepository profileRepository = new ProfileRepository();

        public List<Profile> getProfile(string projectID)
        {
            return profileRepository.getProfile(projectID); 
        }
        public string createProfile(string profileName, string projectID, string description)
        {
            return profileRepository.createProfile(profileName, projectID, description);
        }
        public string updateProfile(string projectID, string description, DateTime endDate)
        {
            return profileRepository.updateProfile(projectID, description, endDate);
        }
    }
}
