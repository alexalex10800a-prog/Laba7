using DAL7.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL7.Repositories
{
    public class SpecialtyRepositorySQL : IRepository<specialty>
    {
        private Model1 db;

        public SpecialtyRepositorySQL(Model1 dbcontext)
        {
            this.db = dbcontext;
        }

        public List<specialty> GetList() => db.specialties.ToList();
        public specialty GetItem(int id) => db.specialties.Find(id);
        public void Create(specialty item) => db.specialties.Add(item);
        public void Update(specialty item) => db.Entry(item).State = EntityState.Modified;
        public void Delete(int id)
        {
            specialty item = db.specialties.Find(id);
            if (item != null)
                db.specialties.Remove(item);
        }
    }
}
