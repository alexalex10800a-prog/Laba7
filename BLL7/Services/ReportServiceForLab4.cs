using BLL7.models;
using BLL7.Interface;
using DAL7;
using DAL7.Entities;
using DAL7.Interfaces;
using System;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace BLL7.Services
{
    public class ReportServiceForLab4 : IReportService
    {
        private IDbRepos _db;

        // Constructor injection
        public ReportServiceForLab4(IDbRepos repos)
        {
            _db = repos;
        }

        // Your report data structure (like OrdersByMonth in the example)

        // Execute stored procedure through repository
        public List<EmployeeProjectsResult> GetEmployeesWithProjectsByDepartment(int departmentId)
        {
            // Use the Reports repository instead of creating DbContext directly
            var reportData = _db.Reports.GetEmployeesWithProjectsByDepartment(departmentId);

            // Convert from DAL report entity to service result
            return reportData.Select(r => new EmployeeProjectsResult
            {
                EmployeeId = r.EmployeeId,
                FullName = r.FullName,
                DepartmentName = r.DepartmentName,
                SpecialtyName = r.SpecialtyName,
                ProjectCode = r.ProjectCode,
                ParticipationStatus = r.ParticipationStatus
            }).ToList();
        }
    }
}