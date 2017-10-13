using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SitefinityToolbox.AnchorTag.Services
{
    using Model;

    public class AnchorTagService : IAnchorTagService
    {
        public IEnumerable<IAnchorTag> GetAnchorTagsByPageId(Guid pageNodeId)
        {
            return null;
        }
    }
}