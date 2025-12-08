
using DAL7.Repositories.MongoDB;
using DAL7.MongoDB;

namespace DAL7.Repositories.MongoDB
{
    public class DepartmentRepositoryMongo : MongoRepository<department>
    {
        public DepartmentRepositoryMongo(MongoDbContext context)
            : base(context.Departments)
        {
        }
    }
}