using DAL7.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL7.Repositories
{
    public class ParticipationRepositorySQL : IRepository<participation>
    {
        private Model1 db;

        public ParticipationRepositorySQL(Model1 dbcontext)
        {
            this.db = dbcontext;
        }

        public List<participation> GetList() => db.participations.ToList();
        public participation GetItem(int id) => db.participations.Find(id);
        public void Create(participation item) => db.participations.Add(item);
        public void Update(participation item) => db.Entry(item).State = EntityState.Modified;
        public void Delete(int id)
        {
            participation item = db.participations.Find(id);
            if (item != null)
                db.participations.Remove(item);
        }
    }
}
