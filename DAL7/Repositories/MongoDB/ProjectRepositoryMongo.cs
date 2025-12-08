
using DAL7.Repositories.MongoDB;
using DAL7.MongoDB;

namespace DAL7.Repositories.MongoDB
{
    public class ProjectRepositoryMongo : MongoRepository<project>
    {
        public ProjectRepositoryMongo(MongoDbContext context)
            : base(context.Projects)
        {
        }
    }
}