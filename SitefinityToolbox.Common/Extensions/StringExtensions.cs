namespace SitefinityToolbox.Common.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public static class StringExtensions
    {
        public static string ReplaceEnd(this string source, string find, string replaceWith)
        {
            var place = source.LastIndexOf(find, StringComparison.Ordinal);

            if (place == -1)
            {
                return source;
            }

            var result = source.Remove(place, find.Length).Insert(place, replaceWith);
            return result;
        }

        /// <summary>
        ///     Splits a camel-cased or pascal-cased string.
        /// </summary>
        /// <param name="this">The string to split.</param>
        /// <param name="splitter">The splitter.</param>
        /// <returns>The split string.</returns>
        public static string SplitIntercapped(this string @this, string splitter = " ")
        {
            const string exp = "/([A-Z]+(?=$|[A-Z][a-z])|[A-Z]?[a-z]+)/g";
            return Regex.Replace(@this, exp, splitter);
        }
    }
}