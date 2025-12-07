using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL7.Interfaces
{
    public interface IDbRepos
    {
        IRepository<project> Projects { get; }
        IRepository<contract> Contracts { get; }
        IRepository<employee> Employees { get; }
        IRepository<department> Departments { get; }
        IRepository<specialty> Specialties { get; }
        IRepository<participation> Participations { get; }

        // Reports repository
        IReportsRepository Reports { get; }

        // Save changes
        int Save();
    }
}
