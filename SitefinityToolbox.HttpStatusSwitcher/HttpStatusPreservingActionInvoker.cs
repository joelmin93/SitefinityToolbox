namespace SitefinityToolbox.HttpStatusSwitcher
{
    using System.Web;
    using Telerik.Microsoft.Practices.Unity;
    using Telerik.Sitefinity.Abstractions;
    using Telerik.Sitefinity.Frontend.Mvc.Infrastructure.Routing;
    using Telerik.Sitefinity.Mvc;
    using Telerik.Sitefinity.Services;

    /// <summary>
    ///     A <see cref="FeatherActionInvoker"/> that preserves http status code when switching from the temporary <see cref="HttpContext"/> for MVC
    ///     widgets to the actual application <see cref="HttpContext"/>.
    /// </summary>
    public class HttpStatusPreservingActionInvoker : FeatherActionInvoker
    {
        protected override void RestoreHttpContext(string output, HttpContext initialContext)
        {
            PopulateResponseStatus(HttpContext.Current, initialContext);

            base.RestoreHttpContext(output, initialContext);
        }

        private void PopulateResponseStatus(HttpContext httpContext, HttpContext initialContext)
        {
            if (!SystemManager.IsDesignMode && httpContext.Response.StatusCode != 200)
            {
                initialContext.Response.Status = httpContext.Response.Status;
                initialContext.Response.StatusCode = httpContext.Response.StatusCode;
                initialContext.Response.StatusDescription = httpContext.Response.StatusDescription;
            }
        }
    }
}