using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitefinityToolbox.HttpStatusSwitcher.Mvc.Models
{
    using System.Net;
    using System.Web;

    public interface IHttpStatusModel
    {
        void SwitchStatus(HttpResponseBase response);

        HttpStatusCode HttpStatusCode { get; set; }

        string StatusDescription { get; set; }
    }
}