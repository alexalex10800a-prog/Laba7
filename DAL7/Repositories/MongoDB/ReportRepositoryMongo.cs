// ReportRepositoryMongo.cs
using DAL7.Entities;
using DAL7.Interfaces;
using DAL7.MongoDB;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace DAL7.Repositories.MongoDB
{
    public class ReportRepositoryMongo : IReportsRepository
    {
        private readonly MongoDbContext _context;

        public ReportRepositoryMongo(MongoDbContext context)
        {
            _context = context;
        }

        public List<EmployeeProjectsReport> GetEmployeesWithProjectsByDepartment(int departmentId)
        {
            // 1. Получаем название отдела по ID
            var departmentFilter = Builders<BsonDocument>.Filter.Eq("_id", departmentId);
            var departmentDoc = _context.Departments.Find(departmentFilter).FirstOrDefault();

            if (departmentDoc == null)
                return new List<EmployeeProjectsReport>();

            var departmentName = departmentDoc["department_name"].AsString;

            // 2. Получаем всех сотрудников этого отдела
            var employeeFilter = Builders<BsonDocument>.Filter.Eq("department_code_FK2", departmentId);
            var employeeDocs = _context.Employees.Find(employeeFilter).ToList();

            // 3. Собираем отчет
            var result = new List<EmployeeProjectsReport>();

            foreach (var empDoc in employeeDocs)
            {
                var employeeId = empDoc["_id"].AsInt32;
                var fullName = empDoc["full_name"].AsString;
                var specialtyId = empDoc["specialty_code_FK1"].AsInt32;

                // Находим специальность
                var specialtyFilter = Builders<BsonDocument>.Filter.Eq("_id", specialtyId);
                var specialtyDoc = _context.Specialties.Find(specialtyFilter).FirstOrDefault();
                var specialtyName = specialtyDoc?["specialty_name"].AsString ?? "Не указана";

                // Находим участие в проектах
                var participationFilter = Builders<BsonDocument>.Filter.Eq("employee_id_FK1", employeeId);
                var participationDoc = _context.Participations.Find(participationFilter).FirstOrDefault();

                int projectCode = 0;
                string status = "не назначен";

                if (participationDoc != null)
                {
                    var projectId = participationDoc["project_code_FK2"].AsInt32;
                    var projectFilter = Builders<BsonDocument>.Filter.Eq("_id", projectId);
                    var projectDoc = _context.Projects.Find(projectFilter).FirstOrDefault();

                    projectCode = projectDoc?["_id"].AsInt32 ?? 0;
                    status = participationDoc["status"].AsString;
                }

                result.Add(new EmployeeProjectsReport
                {
                    EmployeeId = employeeId,
                    FullName = fullName,
                    DepartmentName = departmentName,
                    SpecialtyName = specialtyName,
                    ProjectCode = projectCode,
                    ParticipationStatus = status
                });
            }

            return result;
        }
    }
}