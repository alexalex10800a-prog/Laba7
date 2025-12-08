using DAL7.Interfaces;
using DAL7.Repositories.MongoDB;
using DAL7.MongoDB;

namespace DAL7.Repositories.MongoDB
{
    public class DbReposMongo : IDbRepos
    {
        private MongoDbContext _db;
        private ProjectRepositoryMongo _projectRepository;
        private ContractRepositoryMongo _contractRepository;
        private EmployeeRepositoryMongo _employeeRepository;
        private DepartmentRepositoryMongo _departmentRepository;
        private SpecialtyRepositoryMongo _specialtyRepository;
        private ParticipationRepositoryMongo _participationRepository;
        private ReportRepositoryMongo _reportRepository;

        public DbReposMongo()
        {
            _db = MongoConfig.CreateContext();
            // Раскомментировать для первоначального заполнения данных:
            // _db.Seed();
        }

        public IRepository<project> Projects
        {
            get
            {
                if (_projectRepository == null)
                    _projectRepository = new ProjectRepositoryMongo(_db);
                return _projectRepository;
            }
        }

        public IRepository<contract> Contracts
        {
            get
            {
                if (_contractRepository == null)
                    _contractRepository = new ContractRepositoryMongo(_db);
                return _contractRepository;
            }
        }

        public IRepository<employee> Employees
        {
            get
            {
                if (_employeeRepository == null)
                    _employeeRepository = new EmployeeRepositoryMongo(_db);
                return _employeeRepository;
            }
        }

        public IRepository<department> Departments
        {
            get
            {
                if (_departmentRepository == null)
                    _departmentRepository = new DepartmentRepositoryMongo(_db);
                return _departmentRepository;
            }
        }

        public IRepository<specialty> Specialties
        {
            get
            {
                if (_specialtyRepository == null)
                    _specialtyRepository = new SpecialtyRepositoryMongo(_db);
                return _specialtyRepository;
            }
        }

        public IRepository<participation> Participations
        {
            get
            {
                if (_participationRepository == null)
                    _participationRepository = new ParticipationRepositoryMongo(_db);
                return _participationRepository;
            }
        }

        public IReportsRepository Reports
        {
            get
            {
                if (_reportRepository == null)
                    _reportRepository = new ReportRepositoryMongo(_db);
                return _reportRepository;
            }
        }
        public int Save()
        {
            // В MongoDB нет SaveChanges() как в EF
            // Все операции сразу сохраняются
            return 1; // Возвращаем 1 как успешную операцию
        }

        public void Dispose()
        {
            // MongoDB клиент не требует Dispose в большинстве случаев
        }
    }
}