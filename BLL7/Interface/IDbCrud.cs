
using BLL7.models;
using BLL7.Services;
using System.Collections.Generic;

namespace BLL7.Interface
{
    public interface IDbCrud
    {
        // Employee operations
        bool HasEmployeesWithSpecialty(int specialtyId);
        void UpdateEmployee(EmployeeDTO emp);
        void DeleteEmployee(int id);
        BusinessResult CreateEmployee(EmployeeDTO e);
        List<EmployeeDTO> GetAllEmployees();
        EmployeeDTO GetEmployeeById(int employeeId);
        List<EmployeeDTO> GetEmployeesByDepartment(int departmentId);
        List<EmployeeProjectsDTO> GetEmployeesWithProjectsByDepartment(int departmentId);

        // Specialty operations
        void UpdateSpecialty(SpecialtyDTO sp);
        void DeleteSpecialty(int id);
        void CreateSpecialty(SpecialtyDTO e);
        List<SpecialtyDTO> GetAllSpecialties();

        // Department operations
        List<DepartmentDTO> GetAllDepartments();
        List<DepartmentDTO> GetAllDepartments1();
        List<DepartmentStatsDto> GetDepartmentStats();

        // Common operations
        bool Save();
    }
}