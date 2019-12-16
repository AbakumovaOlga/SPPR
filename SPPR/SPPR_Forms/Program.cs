using SPPR_Services;
using SPPR_Services.ImplementationBD;
using SPPR_Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace SPPR_Forms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<Form_Start>());
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<DbContext, SPPRDbContext>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<IAnalizeService, AnalizeServiceBD>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IMarkParamService, MarkParamServiceBD>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IParametrService, ParametrSeviceBD>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ITelephoneService, TelephoneServiceBD>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ITelepParamService, TelepParamServiceBD>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ITrendService, TrendSeviceBD>(new HierarchicalLifetimeManager());

            return currentContainer;
        }
    }
}
