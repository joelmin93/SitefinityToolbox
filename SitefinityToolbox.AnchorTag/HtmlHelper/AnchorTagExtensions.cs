using System.Web.Mvc;

namespace SitefinityToolbox.AnchorTag.HtmlHelper
{
    using HtmlHelper = System.Web.Mvc.HtmlHelper;

    public static class AnchorTagExtensions
    {
        /// <summary>
        ///     Generates an id attribute with the anchor tag of currently executing widget.
        /// </summary>
        /// <param name="helper">The HtmlHelper.</param>
        /// <returns>The "id" attribute with the anchor tag.</returns>
        public static MvcHtmlString RenderCurrentWidgetAnchorTag(this HtmlHelper helper)
        {
            var controller = helper.ViewContext.Controller;
            if (controller is IAnchorTaggedWidget widget)
            {
                return MvcHtmlString.Create($@"id=""{widget.WidgetAnchorTag}""");
            }

            return MvcHtmlString.Empty;
        }

        public static string GetCurrentWidgetAnchorTag(this HtmlHelper helper)
        {
            var controller = helper.ViewContext.Controller;
            if (controller is IAnchorTaggedWidget widget)
            {
                return widget.WidgetAnchorTag;
            }

            return null;
        }
    }
}