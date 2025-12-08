using DAL7.Repositories.MongoDB;
using DAL7.MongoDB;

namespace DAL7.Repositories.MongoDB
{
    public class ParticipationRepositoryMongo : MongoRepository<participation>
    {
        public ParticipationRepositoryMongo(MongoDbContext context)
            : base(context.Participations)
        {
        }
    }
}