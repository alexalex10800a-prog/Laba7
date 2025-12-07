using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL7.Interfaces;
using DAL7.Repositories;
using Ninject.Modules;

namespace BLL7
{
    public class ServiceModule : NinjectModule
    {
        private string connectionString;
        public ServiceModule (string connection)
        {
            connectionString = connection;
        }
        public override void Load()
        {
            Bind<IDbRepos>().To<DbReposSQL>().InSingletonScope().WithConstructorArgument(connectionString);
        }
    }
}
