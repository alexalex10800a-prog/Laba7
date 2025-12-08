using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL7.Interfaces;
using DAL7.Repositories;
using DAL7.Repositories.MongoDB;
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
            Bind<IDbRepos>().To<DbReposMongo>().InSingletonScope().WithConstructorArgument(connectionString);
            //Bind<IDbRepos>().To<DbReposSQL>().InSingletonScope().WithConstructorArgument(connectionString);
        }
    }
}
