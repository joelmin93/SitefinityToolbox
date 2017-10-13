namespace SitefinityToolbox.AnchorTag.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AnchorTag : IAnchorTag
    {
        public virtual string Tag { get; set; }

        public virtual string WidgetName { get; set; }

        public virtual Guid WidgetId { get; set; }
    }
}