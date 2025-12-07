using BLL7.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL7.Services
{
    // BLL/Services/ReportService.cs
    public class ReportService
    {
        private readonly DBDataOperations _dbOperations;

        public ReportService(DBDataOperations dbOperations)
        {
            _dbOperations = dbOperations;
        }

        public List<EmployeeDTO> GetDepartmentReport(int departmentId)
        {
            // You can add business logic here like validation, formatting, etc.
            if (departmentId <= 0)
                throw new ArgumentException("Invalid department ID");

            return _dbOperations.GetEmployeesByDepartment(departmentId);
        }
    }
}
