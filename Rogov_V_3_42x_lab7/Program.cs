using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using BLL7;
using BLL7.Interface;
using Rogov_V_3_42x_lab7.Util;
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

            var kernel = new StandardKernel(new NinjectRegistrations(), new ServiceModule("Model1"));

            IDbCrud crudServ = kernel.Get<IDbCrud>();
            IReportService reportService = kernel.Get<IReportService>();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(crudServ, reportService));
        }
    }
}
