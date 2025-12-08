
using DAL7.Repositories.MongoDB;
using DAL7.MongoDB;

namespace DAL7.Repositories.MongoDB
{
    public class SpecialtyRepositoryMongo : MongoRepository<specialty>
    {
        public SpecialtyRepositoryMongo(MongoDbContext context)
            : base(context.Specialties)
        {
        }
    }
}