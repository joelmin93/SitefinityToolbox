using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitefinityToolbox.Common.Extensions
{
    using System.Linq.Expressions;
    using System.Web.Mvc;
    using Utilities;

    public static class HtmlHelperExtensions
    {
        /// <summary>
        ///     Renders the Angular attribute that represents the property of given widget.
        /// </summary>
        /// <typeparam name="TWidgetController">The type of widget controller.</typeparam>
        /// <param name="helper">The helper.</param>
        /// <param name="propertyExpression">The property expression.</param>
        /// <returns>The Angular attribute.</returns>
        public static string AngularPropertyFor<TWidgetController>(
            this HtmlHelper helper,
            Expression<Func<TWidgetController, object>> propertyExpression)
            where TWidgetController : Controller
        {
            Check.NotNull(propertyExpression, nameof(propertyExpression));

            var propertyName = propertyExpression.GetPropertyName();

            return $"properties.{propertyName}.PropertyValue";
        }

        /// <summary>
        ///     Enumerates all values of target enum.
        /// </summary>
        /// <typeparam name="TEnum">The type of target enum</typeparam>
        /// <param name="helper">The HtmlHelper</param>
        /// <returns>Enumerated values of the target enum</returns>
        public static IEnumerable<TEnum> EnumerateEnum<TEnum>(this HtmlHelper helper)
            where TEnum : struct
        {
            return Enum.GetValues(typeof(TEnum)).Cast<TEnum>().ToList();
        }
    }
}