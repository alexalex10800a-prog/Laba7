using DAL7.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL7.Interfaces
{
    public interface IReportsRepository 
    {
        List<EmployeeProjectsReport> GetEmployeesWithProjectsByDepartment(int departmentId);
    }
}
