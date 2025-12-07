using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL7.Interface
{
    public interface IReportService
    {
        List<EmployeeProjectsResult> GetEmployeesWithProjectsByDepartment(int departmentId);
    }

    // Define the result class
    public class EmployeeProjectsResult
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string DepartmentName { get; set; }
        public string SpecialtyName { get; set; }
        public int ProjectCode { get; set; }
        public string ParticipationStatus { get; set; }
    }
}