using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repositories;
using System.Threading.Tasks;
using Repositories.Model;

namespace Services
{
    public class DepartmentService
    {
        DeparmentRepository deparmentRepository = new DeparmentRepository();

        public List<Department> getListDepartmentCEO()
        {
            return deparmentRepository.getDepartmentDataCEO();
        }

        public List<Department> getListDepartmentManager(string managerID)
        {
            return deparmentRepository.getDepartmentDataManager(managerID);
        }

        public string create(string departmentName, string managerID, string description)
        {
            return deparmentRepository.createDepartment(departmentName, managerID, description);
        }

        public string update(string departmentID, string managerID, string description)
        {
            return deparmentRepository.updateDepartment(departmentID, managerID, description);
        }
    }
}
