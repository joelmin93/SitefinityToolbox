namespace SitefinityToolbox.AnchorTag.IoC
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Factory;
    using Ninject.Modules;
    using Ninject.Web.Common;

    internal class AnchorTagModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IModelFactory>().To<ModelFactory>().InRequestScope();
        }
    }
}