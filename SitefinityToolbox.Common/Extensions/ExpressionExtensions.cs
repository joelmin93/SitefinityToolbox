using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitefinityToolbox.Common.Extensions
{
    using System.Linq.Expressions;

    public static class ExpressionExtensions
    {
        /// <summary>
        ///     Gets the name of the property that the expression is pointing to.
        /// </summary>
        /// <typeparam name="T">Parent type.</typeparam>
        /// <param name="propertyExpression">The expression.</param>
        /// <returns>The property name.</returns>
        public static string GetPropertyName<T>(this Expression<Func<T, object>> propertyExpression) where T : class
        {
            var body = propertyExpression.Body;
            if (body is MemberExpression me)
            {
                return me.Member.Name;
            }

            if (body is ConstantExpression ce)
            {
                return ce.ToString();
            }

            if (body is UnaryExpression ue)
            {
                return ((MemberExpression)ue.Operand).Member.Name;
            }

            throw new InvalidOperationException($"Unknown expression of {propertyExpression} was requested.");
        }
    }
}