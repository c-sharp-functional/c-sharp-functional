using System;
using System.Collections.Generic;
using System.Linq;

namespace Farity
{
    public static partial class F
    {
        /// <summary>
        ///     Projects each element of a sequence into a new form.
        ///     Functions that do not mutate are recommended as projection functions.
        /// </summary>
        /// <typeparam name="TSource">The type of items in the source.</typeparam>
        /// <typeparam name="TResult">The type of items in the result.</typeparam>
        /// <param name="map">The projection function.</param>
        /// <param name="source">The source of items.</param>
        /// <returns>An enumerable whose elements are the result of invoking the transform function on each element of source.</returns>
        public static IEnumerable<TResult> Map<TSource, TResult>(Func<TSource, TResult> map, IEnumerable<TSource> source)
            => source.Select(map);
    }
}