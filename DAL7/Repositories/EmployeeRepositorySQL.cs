using DAL7.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL7.Repositories
{
    public class EmployeeRepositorySQL : IRepository<employee>
    {
        private Model1 db;

        public EmployeeRepositorySQL(Model1 dbcontext)
        {
            this.db = dbcontext;
        }

        public List<employee> GetList() => db.employees.ToList();
        public employee GetItem(int id) => db.employees.Find(id);
        public void Create(employee item) => db.employees.Add(item);
        public void Update(employee item) => db.Entry(item).State = EntityState.Modified;
        public void Delete(int id)
        {
            employee item = db.employees.Find(id);
            if (item != null)
                db.employees.Remove(item);
        }
    }
}
