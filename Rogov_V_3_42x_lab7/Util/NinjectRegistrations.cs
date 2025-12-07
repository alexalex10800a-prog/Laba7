using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL7;
using BLL7.Interface;
using BLL7.Services;
using Ninject.Modules;
namespace Rogov_V_3_42x_lab7.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IDbCrud>().To<DBDataOperations>();
            Bind<IReportService>().To<ReportServiceForLab4>();
        }
    }
}
