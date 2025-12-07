using DAL7.Interfaces;
using DAL7.Entities;
using DAL7.Interfaces;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DAL7.Repositories
{
    public class ReportRepositorySQL : IReportsRepository
    {
        private Model1 db;

        public ReportRepositorySQL(Model1 dbcontext)
        {
            this.db = dbcontext;
        }

        public List<EmployeeProjectsReport> GetEmployeesWithProjectsByDepartment(int departmentId)
        {
            return db.Database.SqlQuery<EmployeeProjectsReport>(
                "EXEC mydb.GetEmployeesWithProjectsByDepartment @DepartmentId",
                new SqlParameter("@DepartmentId", departmentId))
                .ToList();
        }
    }
}