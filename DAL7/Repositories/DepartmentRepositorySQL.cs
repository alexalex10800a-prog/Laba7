using DAL7.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL7.Repositories
{
    public class DepartmentRepositorySQL : IRepository<department>
    {
        private Model1 db;

        public DepartmentRepositorySQL(Model1 dbcontext)
        {
            this.db = dbcontext;
        }

        public List<department> GetList() => db.departments.ToList();
        public department GetItem(int id) => db.departments.Find(id);
        public void Create(department item) => db.departments.Add(item);
        public void Update(department item) => db.Entry(item).State = EntityState.Modified;
        public void Delete(int id)
        {
            department item = db.departments.Find(id);
            if (item != null)
                db.departments.Remove(item);
        }
    }
}
