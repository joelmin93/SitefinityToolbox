using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitefinityToolbox.HttpStatusSwitcher
{
    using Mvc.Models;
    using Ninject;
    using Telerik.Microsoft.Practices.Unity;
    using Telerik.Sitefinity.Abstractions;
    using Telerik.Sitefinity.Data;
    using Telerik.Sitefinity.Frontend;
    using Telerik.Sitefinity.Mvc;

    public class HttpStatusSwitcherInstaller
    {
        public static void PreApplicationStart()
        {
            Bootstrapper.Initialized += Bootstrapper_Initialized;
            Bootstrapper.Bootstrapped += Bootstrapper_Bootstrapped;
        }

        private static void Bootstrapper_Initialized(object sender, ExecutedEventArgs e)
        {
            if (e.CommandName == "Bootstrapped")
            {
                var resolver = FrontendModule.Current.DependencyResolver;
                resolver.Bind<IHttpStatusModel>().To<HttpStatusModel>();
            }
        }

        private static void Bootstrapper_Bootstrapped(object sender, EventArgs e)
        {
            ObjectFactory.Container.RegisterType<IControllerActionInvoker, HttpStatusPreservingActionInvoker>();
        }
    }
}