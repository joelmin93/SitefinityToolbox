using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SitefinityToolbox.AnchorTag.Services
{
    using Model;

    [ServiceContract]
    public interface IAnchorTagService
    {
        [OperationContract]
        IEnumerable<IAnchorTag> GetAnchorTagsByPageId(Guid pageNodeId);
    }
}