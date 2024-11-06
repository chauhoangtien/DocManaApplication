using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using Repositories.Model;
using UserDepartment = Repositories.Model.UserDepartment;

namespace Services
{
    public class UserDepartmentService
    {
        UserDepartmentRepository userDepartmentRepository = new UserDepartmentRepository(); 

        public List<UserDepartment> getUserDepartment(string departmentID)
        {
            return userDepartmentRepository.getUserDepartment(departmentID);
        }
        public string createUserDepartment(string userID, string departmentID, string role)
        {
            return userDepartmentRepository.createUserDepartment(userID, departmentID, role);
        }
        public string updateUserDepartment(string userID, string departmentID, string role)
        {
            return userDepartmentRepository.updateUserDepartment(userID, departmentID, role);
        }
    }
}
