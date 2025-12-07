using BLL7.models;
using BLL7.Services;
using BLL7.Interface;
using DAL7;
using DAL7.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BLL7
{
    // BLL/DBDataOperations.cs
    public class DBDataOperations : IDbCrud
    {
        private IDbRepos _db;

        public DBDataOperations(IDbRepos repos)
        {
            _db = repos;
        }

        public bool HasEmployeesWithSpecialty(int specialtyId)
        {
            return _db.Employees.GetList().Any(e => e.specialty_code_FK1 == specialtyId);
        }

        public bool Save()
        {
            try
            {
                // With repository pattern, we don't have ChangeTracker
                // Just attempt to save and handle exceptions
                int recordsAffected = _db.Save();
                return true; // Success if no exception
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Save error: {ex.Message}");
                return false;
            }
        }

        public void UpdateEmployee(EmployeeDTO emp)
        {
            employee e = _db.Employees.GetItem(emp.ID);
            if (e != null)
            {
                e.full_name = emp.FullName;
                e.specialty_code_FK1 = emp.SpecialtyCode;
                e.department_code_FK2 = emp.DepartmentCode;
                _db.Employees.Update(e);
                Save();
            }
        }

        public void DeleteEmployee(int id)
        {
            employee emp = _db.Employees.GetItem(id);
            if (emp != null)
            {
                _db.Employees.Delete(id);
                Save();
            }
        }

        public BusinessResult CreateEmployee(EmployeeDTO e)
        {
            try
            {
                // BUSINESS RULE: Check if department already has 3 employees with this specialty
                var sameSpecialtyCount = _db.Employees.GetList()
                    .Count(emp => emp.department_code_FK2 == e.DepartmentCode
                               && emp.specialty_code_FK1 == e.SpecialtyCode);

                if (sameSpecialtyCount >= 3)
                {
                    var department = _db.Departments.GetItem(e.DepartmentCode);
                    var specialty = _db.Specialties.GetItem(e.SpecialtyCode);

                    return BusinessResult.Fail(
                        $"Отдел '{department.department_name}' уже имеет {sameSpecialtyCount} сотрудников " +
                        $"со специальностью '{specialty.specialty_name}'. Максимум 3 разрешено.");
                }

                // If rule passes, create the employee
                _db.Employees.Create(new employee()
                {
                    full_name = e.FullName,
                    specialty_code_FK1 = e.SpecialtyCode,
                    department_code_FK2 = e.DepartmentCode
                });

                bool saveResult = Save();

                if (saveResult)
                    return BusinessResult.Success("Сотрудник успешно создан!");
                else
                    return BusinessResult.Fail("Ошибка при сохранении сотрудника");
            }
            catch (Exception ex)
            {
                return BusinessResult.Fail($"Ошибка системы: {ex.Message}");
            }
        }

        public List<EmployeeDTO> GetAllEmployees()
        {
            return _db.Employees.GetList().Select(i => new EmployeeDTO(i)).ToList();
        }

        public void UpdateSpecialty(SpecialtyDTO sp)
        {
            specialty s = _db.Specialties.GetItem(sp.ID);
            if (s != null)
            {
                s.specialty_name = sp.SpecialtyName;
                _db.Specialties.Update(s);
                Save();
            }
        }

        public void DeleteSpecialty(int id)
        {
            specialty sp = _db.Specialties.GetItem(id);
            if (sp != null)
            {
                _db.Specialties.Delete(id);
                Save();
            }
        }

        public void CreateSpecialty(SpecialtyDTO e)
        {
            _db.Specialties.Create(new specialty() { specialty_name = e.SpecialtyName });
            Save();
        }

        public List<DepartmentStatsDto> GetDepartmentStats()
        {
            // This one is complex - you might need to keep using the context directly
            // or create a specialized repository method
            var employees = _db.Employees.GetList();
            var departments = _db.Departments.GetList();
            var contracts = _db.Contracts.GetList();

            var query = from e in employees
                        join d in departments on e.department_code_FK2 equals d.department_code
                        join c in contracts on e.employee_id equals c.leader_code_FK
                        where c.cost > 10000
                        group new { e, c } by d.department_name into g
                        select new DepartmentStatsDto
                        {
                            DepartmentName = g.Key,
                            EmployeeCount = g.Select(x => x.e.employee_id).Distinct().Count(),
                            AvgContractCost = g.Average(x => x.c.cost)
                        };

            return query.ToList();
        }

        public List<EmployeeDTO> GetEmployeesByDepartment(int departmentId)
        {
            // Use repository instead of stored procedure
            return _db.Employees.GetList()
                .Where(e => e.department_code_FK2 == departmentId)
                .Select(e => new EmployeeDTO(e))
                .ToList();
        }

        public List<EmployeeProjectsDTO> GetEmployeesWithProjectsByDepartment(int departmentId)
        {
            // This will work once Reports repository is implemented
            var reportData = _db.Reports.GetEmployeesWithProjectsByDepartment(departmentId);
            return reportData.Select(i => new EmployeeProjectsDTO
            {
                EmployeeId = i.EmployeeId,
                FullName = i.FullName,
                DepartmentName = i.DepartmentName,
                SpecialtyName = i.SpecialtyName,
                ProjectCode = i.ProjectCode,
                ParticipationStatus = i.ParticipationStatus
            }).ToList();
        }

        public List<DepartmentDTO> GetAllDepartments1()
        {
            return _db.Departments.GetList()
                .Select(d => new DepartmentDTO
                {
                    ID = d.department_code,
                    DepartmentName = d.department_name
                })
                .ToList();
        }

        public EmployeeDTO GetEmployeeById(int employeeId)
        {
            var employee = _db.Employees.GetItem(employeeId);
            if (employee == null) return null;

            // With repositories, you might need to load related entities manually
            var specialty = _db.Specialties.GetItem(employee.specialty_code_FK1);
            var department = _db.Departments.GetItem(employee.department_code_FK2);

            return new EmployeeDTO
            {
                ID = employee.employee_id,
                FullName = employee.full_name,
                SpecialtyCode = employee.specialty_code_FK1,
                SpecialtyName = specialty?.specialty_name,
                DepartmentCode = employee.department_code_FK2,
                DepartmentName = department?.department_name
            };
        }

        public List<SpecialtyDTO> GetAllSpecialties()
        {
            return _db.Specialties.GetList().Select(i => new SpecialtyDTO(i)).ToList();
        }

        public List<DepartmentDTO> GetAllDepartments()
        {
            return _db.Departments.GetList().Select(a => new DepartmentDTO(a)).ToList();
        }
    }
}
