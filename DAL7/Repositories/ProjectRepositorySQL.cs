using DAL7.Interfaces;
using DAL7;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL7.Repositories
{
    public class ProjectRepositorySQL : IRepository<project>
    {
        private Model1 db;

        public ProjectRepositorySQL(Model1 dbcontext)
        {
            this.db = dbcontext;
        }

        public List<project> GetList()
        {
            return db.projects.ToList();
        }

        public project GetItem(int id)
        {
            return db.projects.Find(id);
        }

        public void Create(project item)
        {
            db.projects.Add(item);
        }

        public void Update(project item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            project item = db.projects.Find(id);
            if (item != null)
                db.projects.Remove(item);
        }
    }
}