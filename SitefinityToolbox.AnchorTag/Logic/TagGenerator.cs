namespace SitefinityToolbox.AnchorTag.Logic
{
    using Common.Extensions;
    using Sanitizing;
    using Sanitizing.Strategies;

    public static class TagGenerator
    {
        public static readonly SanitizerCollection TypeNameSanitizers;

        static TagGenerator()
        {
            TypeNameSanitizers = new SanitizerCollection();
            TypeNameSanitizers.Add<ControllerSanitizer>();
        }

        public static string Generate<TAnchorTaggedWidget>(string nameSplitter = "-")
            where TAnchorTaggedWidget : IAnchorTaggedWidget
        {
            var typeName = GetSanitizedTypeName<TAnchorTaggedWidget>();

            return typeName.SplitIntercapped(nameSplitter);
        }

        private static string GetSanitizedTypeName<TAnchorTaggedWidget>() where TAnchorTaggedWidget : IAnchorTaggedWidget
        {
            var type = typeof(TAnchorTaggedWidget);
            var typeName = type.Name;
            foreach (var typeNameSanitizer in TypeNameSanitizers)
            {
                typeNameSanitizer.Sanitize(type, ref typeName);
            }

            return typeName;
        }
    }
}