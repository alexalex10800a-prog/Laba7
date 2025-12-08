
using DAL7.Repositories.MongoDB;
using DAL7.MongoDB;

namespace DAL7.Repositories.MongoDB
{
    public class EmployeeRepositoryMongo : MongoRepository<employee>
    {
        public EmployeeRepositoryMongo(MongoDbContext context)
            : base(context.Employees)
        {
        }
    }
}