
using DAL7.Repositories.MongoDB;
using DAL7.MongoDB;
using MongoDB.Driver;

namespace DAL7.Repositories.MongoDB
{
    public class ContractRepositoryMongo : MongoRepository<contract>
    {
        public ContractRepositoryMongo(MongoDbContext context)
            : base(context.Contracts)
        {
        }
    }
}