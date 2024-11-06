using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using Repositories.Model;

namespace Services
{
    public class GroupService
    {
        GroupRepository groupRepository = new GroupRepository();

        public List<Group> getDataGroup(string departmentID)
        {
            return groupRepository.getDataGroup(departmentID);  
        }

        public string createGroup(string groupName, string departmentID, string leaderID)
        {
            return groupRepository.createGroup(groupName, departmentID, leaderID);
        }

        public string updateDepartment(string groupID, string groupName, string leaderID)
        {
            return groupRepository.updateDepartment(groupID, groupName, leaderID);
        }
    }
}
