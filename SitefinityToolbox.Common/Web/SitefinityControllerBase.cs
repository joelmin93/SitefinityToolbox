using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitefinityToolbox.Common.Web
{
    using System.Web.Mvc;

    public abstract class SitefinityControllerBase : Controller
    {
        protected override void HandleUnknownAction(string actionName)
        {
            ActionInvoker.InvokeAction(ControllerContext, "Index");
        }
    }
}