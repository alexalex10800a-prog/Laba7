using DAL7.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL7.Repositories
{
    public class ContractRepositorySQL : IRepository<contract>
    {
        private Model1 db;

        public ContractRepositorySQL(Model1 dbcontext)
        {
            this.db = dbcontext;
        }

        public List<contract> GetList() => db.contracts.ToList();
        public contract GetItem(int id) => db.contracts.Find(id);
        public void Create(contract item) => db.contracts.Add(item);
        public void Update(contract item) => db.Entry(item).State = EntityState.Modified;
        public void Delete(int id)
        {
            contract item = db.contracts.Find(id);
            if (item != null)
                db.contracts.Remove(item);
        }
    }

}
