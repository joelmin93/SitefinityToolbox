using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitefinityToolbox.Common.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    /// <summary>
    ///     A static utility that provides means to perform common precondition checks.
    /// </summary>
    public static class Check
    {
        /// <summary>
        ///     Ensures the parameter is not null.
        /// </summary>
        /// <typeparam name="T">Type of parameter</typeparam>
        /// <param name="target">Value of parameter</param>
        /// <param name="paramName">The parameter name</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void NotNull<T>(T target, string paramName)
            where T : class
        {
            if (target == null)
            {
                throw new ArgumentNullException($"Parameter [{paramName}] must not be null.");
            }
        }

        /// <summary>
        ///     Ensures the parameter is not null.
        /// </summary>
        /// <typeparam name="T">Type of parameter</typeparam>
        /// <param name="target">Value of parameter</param>
        /// <param name="paramName">The parameter name</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void NotNull<T>(T? target, string paramName)
            where T : struct
        {
            if (target == null)
            {
                throw new ArgumentNullException($"Parameter [{paramName}] must not be null.");
            }
        }

        /// <summary>
        ///     Ensures the parameter is not a default value.
        /// </summary>
        /// <typeparam name="T">Type of parameter</typeparam>
        /// <param name="target">Value of parameter</param>
        /// <param name="paramName">The parameter name</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void NotDefault<T>(T target, string paramName)
            where T : struct
        {
            if (EqualityComparer<T>.Default.Equals(target, default(T)))
            {
                throw new ArgumentException($"Parameter [{paramName}] must not be a default value of {typeof(T).Name}.");
            }
        }

        /// <summary>
        ///     Ensures the parameter is not null or empty.
        /// </summary>
        /// <typeparam name="T">Type of parameter</typeparam>
        /// <param name="target">Value of parameter</param>
        /// <param name="paramName">The parameter name</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void NotNullOrEmpty<T>(IEnumerable<T> target, string paramName)
        {
            NotNull(target, paramName);
            if (!target.Any())
            {
                throw new ArgumentException($"Parameter [{paramName}] must not be null or an empty collection.");
            }
        }
    }
}