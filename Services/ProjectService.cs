using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using Repositories.Model;
using Project = Repositories.Model.Project;

namespace Services
{
    public class ProjectService
    {
        ProjectRepository projectRepository = new ProjectRepository();

        public List<Project> getProject()
        {
            return projectRepository.getProject();
        }

        public string createProject(string projectName, string description, string status, string createdBy)
        {
            return projectRepository.createProject(projectName, description, status, createdBy);
        }

        public string updateProject(string projectID, string description, DateTime endTime, string status)
        {
            return projectRepository.updateProject(projectID, description, endTime, status);    
        }
    }
}
