namespace SitefinityToolbox.AnchorTag.Logic.Sanitizing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SanitizerCollection : List<ITypeNameSanitizer>
    {
        public void Add<TSanitizer>() where TSanitizer : ITypeNameSanitizer, new()
        {
            Add(new TSanitizer());
        }

        public void Remove<TSanitizer>() where TSanitizer : ITypeNameSanitizer
        {
            var sanitizer = this.FirstOrDefault(s => s.GetType() == typeof(TSanitizer));
            if (sanitizer != null)
            {
                Remove(sanitizer);
            }
        }
    }
}