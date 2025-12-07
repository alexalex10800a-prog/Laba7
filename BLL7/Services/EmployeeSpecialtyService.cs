using BLL7.models;
using BLL7.Services;
using DAL7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace YourProject.BLL7.Services
{
    public class EmployeeSpecialtyService
    {
        private readonly Model1 _context;

        public EmployeeSpecialtyService()
        {
            _context = new Model1();
        }

        public BusinessResult AssignSpecialty(int employeeId, int newSpecialtyId)
        {
            var employee = _context.employees.Find(employeeId);
            var newSpecialty = _context.specialties.Find(newSpecialtyId);

            // BUSINESS RULE 1: Employee exists
            if (employee == null)
                return BusinessResult.Fail("Employee not found");

            // BUSINESS RULE 2: Specialty exists
            if (newSpecialty == null)
                return BusinessResult.Fail("Specialty not found");

            // BUSINESS RULE 3: Not already assigned to this specialty
            if (employee.specialty_code_FK1 == newSpecialtyId)
                return BusinessResult.Fail("Сотрудник уже является специалистом этой профессии");

            // BUSINESS RULE 4: Department specialty limit
            var sameSpecialtyCount = _context.employees
     .Count(e => e.department_code_FK2 == employee.department_code_FK2
              && e.specialty_code_FK1 == newSpecialtyId
              && e.employee_id != employeeId);

            // DEBUG: Output to Visual Studio Output window
            System.Diagnostics.Debug.WriteLine($"=== DEBUG BUSINESS RULE ===");
            System.Diagnostics.Debug.WriteLine($"Department ID: {employee.department_code_FK2}");
            System.Diagnostics.Debug.WriteLine($"New Specialty ID: {newSpecialtyId}");
            System.Diagnostics.Debug.WriteLine($"Count (excluding current): {sameSpecialtyCount}");

            // Get detailed info about found employees
            var debugEmployees = _context.employees
                .Where(e => e.department_code_FK2 == employee.department_code_FK2
                         && e.specialty_code_FK1 == newSpecialtyId)
                .Select(e => new { e.employee_id, e.full_name, e.specialty_code_FK1 })
                .ToList();

            foreach (var emp in debugEmployees)
            {
                System.Diagnostics.Debug.WriteLine($"- Employee: {emp.full_name}, ID: {emp.employee_id}, Specialty: {emp.specialty_code_FK1}");
            }

            if (sameSpecialtyCount >= 3)
            {
                System.Diagnostics.Debug.WriteLine($"RULE TRIGGERED: Count {sameSpecialtyCount} >= 3");
                return BusinessResult.Fail($"Невозможно сменить профессию. В отделе уже есть {sameSpecialtyCount} сотрудник(а) такой профессии");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine($"RULE PASSED: Count {sameSpecialtyCount} < 3");
            }

            // BUSINESS RULE 5: Employee not currently on projects requiring old specialty
            var currentProjects = _context.participations
                .Count(p => p.employee_id_FK1 == employeeId);

            if (currentProjects > 0)
                return BusinessResult.Fail("Невозможно сменить профессию. Сотрудник участвует в проекте");

            // If all rules pass, update the specialty
            employee.specialty_code_FK1 = newSpecialtyId;
            _context.SaveChanges();

            return BusinessResult.Success($"Specialty changed to {newSpecialty.specialty_name}");
        }
        public List<SpecialtyDTO> GetAllSpecialties()
        {
            return _context.specialties
                .Select(s => new SpecialtyDTO
                {
                    ID = s.specialty_code,
                    SpecialtyName = s.specialty_name
                })
                .ToList();
        }
    }
}
