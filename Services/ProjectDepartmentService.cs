using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using Repositories.Model;
using ProjectDepartment = Repositories.Model.ProjectDepartment;

namespace Services
{
    public class ProjectDepartmentService
    {
        ProjectDepartmentRepository projectDepartmentRepository = new ProjectDepartmentRepository();

        public List<ProjectDepartment> getProjectDepartment(string departmentID)
        {
            return projectDepartmentRepository.getProjectDepartment(departmentID);
        }

        public string createProjectDepartment(string projectID, string departmentID)
        {
            return projectDepartmentRepository.createProjectDepartment(projectID, departmentID);
        }
    }
}
