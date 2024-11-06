using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using Repositories.Model;
using UserGroup = Repositories.Model.UserGroup;

namespace Services
{
    public class UserGroupService
    {
        UserGroupRepository userGroupRepository = new UserGroupRepository();

        public List<UserGroup> getUserGroup(string groupID)
        {
            return userGroupRepository.getUserGroup(groupID);
        }
        public string createUserGroup(string userID, string groupID, string role)
        {
            return userGroupRepository.createUserGroup(userID, groupID, role);
        }
        public string updateUserGroup(string userID, string groupID, string role)
        {
            return userGroupRepository.updateUserGroup(userID, groupID, role);
        }
    }
}
