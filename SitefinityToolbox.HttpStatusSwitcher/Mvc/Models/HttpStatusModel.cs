using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitefinityToolbox.HttpStatusSwitcher.Mvc.Models
{
    using System.Net;
    using System.Web;

    public class HttpStatusModel : IHttpStatusModel
    {
        /// <inheritdoc/>
        public void SwitchStatus(HttpResponseBase response)
        {
            response.StatusCode = (int)HttpStatusCode;
            response.StatusDescription = StatusDescription;
        }

        /// <inheritdoc/>
        public HttpStatusCode HttpStatusCode { get; set; }

        /// <inheritdoc/>
        public string StatusDescription { get; set; }
    }
}