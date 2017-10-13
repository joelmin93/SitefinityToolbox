namespace SitefinityToolbox.AnchorTag.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IAnchorTag
    {
        string Tag { get; set; }

        string WidgetName { get; set; }

        Guid WidgetId { get; set; }
    }
}