using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using Repositories.Model;
using ProjectGroup = Repositories.Model.ProjectGroup;

namespace Services
{
    public class ProjectGroupService
    {
        ProjectGroupRepository projectGroupRepository = new ProjectGroupRepository();

        public List<ProjectGroup> getProjectGroup(string groupID)
        {
            return projectGroupRepository.getProjectGroup(groupID);
        }
        public string createProjectGroup(string projectID, string groupID)
        {
            return projectGroupRepository.createProjectGroup(projectID, groupID);
        }
    }
}
