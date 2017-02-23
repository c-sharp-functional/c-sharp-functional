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
        /// <typeparam name="T">The type of items in the source.</typeparam>
        /// <typeparam name="TResult">The type of items in the result.</typeparam>
        /// <param name="map">The projection function.</param>
        /// <param name="source">The source of items.</param>
        /// <returns>An enumerable whose elements are the result of invoking the transform function on each element of source.</returns>
        public static IEnumerable<TResult> Map<T, TResult>(Func<T, TResult> map, IEnumerable<T> source)
            => source.Select(map);

        /// <summary>
        ///     Projects each element of a sequence into a new form.
        /// </summary>
        /// <typeparam name="T">The type of items in the source.</typeparam>
        /// <typeparam name="TResult">The type of items in the result.</typeparam>
        /// <param name="map">The projection function.</param>
        /// <param name="source">The source of items.</param>
        /// <returns>An enumerable whose elements are the result of invoking the transform function on each element of source.</returns>
        public static IEnumerable<TResult> Map<T, TResult>(FuncAny<TResult> map, IEnumerable<T> source)
            => Map((T item) => map(item), source);
    }
}