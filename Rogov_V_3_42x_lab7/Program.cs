using BLL7;
using BLL7.Interface;
using MongoDB.Driver.Core.Configuration;
using Ninject;
using Rogov_V_3_42x_lab7.Util;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Rogov_V_3_42x_lab7
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connection = ConfigurationManager.ConnectionStrings["MongoDB_lab7"].ConnectionString;
            Debug.WriteLine($"Using connection string: {connection}");
            var kernel = new StandardKernel(new NinjectRegistrations(), new ServiceModule(connection));

            IDbCrud crudServ = kernel.Get<IDbCrud>();
            IReportService reportService = kernel.Get<IReportService>();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(crudServ, reportService));
        }
    }
}
