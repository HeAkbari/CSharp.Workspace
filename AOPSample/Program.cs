using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOPSample
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var unityContainer = new UnityContainer();

            unityContainer.AddNewExtension<Interception>();

            unityContainer.Configure<Interception>().SetDefaultInterceptorFor<IMyOperation>(new InterfaceInterceptor());

            unityContainer.RegisterType<IMyOperation, MyOperation>();




            Application.Run(new Form1());
        }
    }
}
