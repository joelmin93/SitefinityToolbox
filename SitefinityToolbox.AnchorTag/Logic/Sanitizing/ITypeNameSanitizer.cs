namespace SitefinityToolbox.AnchorTag.Logic.Sanitizing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ITypeNameSanitizer
    {
        void Sanitize(Type objectType, ref string output);
    }
}