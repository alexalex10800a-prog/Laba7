using BLL7.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL7.Services
{
    // BLL/Services/EmployeeTransferService.cs
    public class EmployeeTransferService
    {
        private readonly DBDataOperations _dbOperations;

        public EmployeeTransferService(DBDataOperations dbOperations)
        {
            _dbOperations = dbOperations;
        }

        public bool TransferEmployee(EmployeeTransferDTO transferDto)
        {
            // 1. Get the employee
            var employee = _dbOperations.GetEmployeeById(transferDto.EmployeeId);
            if (employee == null)
                throw new Exception("Employee not found");

            // 2. Get the target department
            var departments = _dbOperations.GetAllDepartments();
            var targetDepartment = departments.FirstOrDefault(d => d.ID == transferDto.NewDepartmentId);
            if (targetDepartment == null)
                throw new Exception("Target department not found");

            // 3. Business rule: Check if employee can be transferred
            if (employee.DepartmentCode == transferDto.NewDepartmentId)
                throw new Exception("Employee is already in this department");

            // 4. Business rule: Check if target department has capacity
            var employeesInTargetDept = _dbOperations.GetAllEmployees()
                .Count(e => e.DepartmentCode == transferDto.NewDepartmentId);

            if (employeesInTargetDept >= 10) // Example business rule: max 10 employees per department
                throw new Exception("Target department is at full capacity");

            // 5. Update employee department
            employee.DepartmentCode = transferDto.NewDepartmentId;

            // 6. Save changes
            _dbOperations.UpdateEmployee(employee);

            return true;
        }
    }
}
