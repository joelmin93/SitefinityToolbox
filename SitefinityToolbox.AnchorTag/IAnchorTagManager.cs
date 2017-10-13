namespace SitefinityToolbox.AnchorTag
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Model;

    public interface IAnchorTagManager
    {
        IEnumerable<IAnchorTag> GetAnchorTagsByPageNodeId(Guid pageNodeId);

        IEnumerable<IAnchorTag> GetAnchorTagsByPageDataId(Guid pageDataId);
    }
}