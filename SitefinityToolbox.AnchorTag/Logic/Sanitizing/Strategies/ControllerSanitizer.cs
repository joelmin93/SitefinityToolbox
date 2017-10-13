namespace SitefinityToolbox.AnchorTag.Logic.Sanitizing.Strategies
{
    using System;
    using System.Web.Mvc;
    using Common.Extensions;

    public class ControllerSanitizer : ITypeNameSanitizer
    {
        public void Sanitize(Type objectType, ref string output)
        {
            if (objectType.IsAssignableFrom(typeof(Controller)))
            {
                output = output.ReplaceEnd(nameof(Controller), string.Empty);
            }
        }
    }
}