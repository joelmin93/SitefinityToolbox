namespace SitefinityToolbox.AnchorTag
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Model;

    public class AnchorTagManager : IAnchorTagManager
    {
        public IEnumerable<IAnchorTag> GetAnchorTagsByPageNodeId(Guid pageNodeId)
        {
            return null;
        }

        public IEnumerable<IAnchorTag> GetAnchorTagsByPageDataId(Guid pageDataId)
        {
            return null;
        }
    }
}