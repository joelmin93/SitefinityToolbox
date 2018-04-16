using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitefinityToolbox.HttpStatusSwitcher.Mvc.Controllers
{
    using System.ComponentModel;
    using System.Net;
    using System.Web.Mvc;
    using Common.Web;
    using Models;
    using Telerik.Sitefinity.Frontend.Mvc.Infrastructure.Controllers;
    using Telerik.Sitefinity.Modules.Pages.Configuration;
    using Telerik.Sitefinity.Mvc;
    using Telerik.Sitefinity.Services;
    using Telerik.Sitefinity.Web.UI;

    [ControllerToolboxItem(
        Name = "HttpStatusSwitcher",
        Title = "Http Status Switcher",
        SectionName = "SitefinityToolbox")]
    public class HttpStatusSwitcherController : SitefinityControllerBase, ICustomWidgetVisualizationExtended
    {
        public virtual bool IsEmpty => Model.HttpStatusCode == HttpStatusCode.OK;

        public string EmptyLinkText { get; set; } = "Click here to override the HTTP status code for this page";

        public string WidgetCssClass => string.Empty;

        private IHttpStatusModel _model;

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public IHttpStatusModel Model => _model ?? (_model = ControllerModelFactory.GetModel<IHttpStatusModel>(GetType()));

        public ActionResult Index()
        {
            if (SystemManager.IsDesignMode)
            {
                return View("Index", Model);
            }

            Model.SwitchStatus(Response);

            return new EmptyResult();
        }
    }
}