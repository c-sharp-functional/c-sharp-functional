using System;
using System.Collections.Generic;
using System.Linq;

namespace Farity
{
    public static partial class F
    {
        /// <summary>
        ///     Takes a predicate and an enumerable, and returns an enumerable of the same type containing the members of the given
        ///     enumerable which satisfy the given predicate. Pure functions are recommended as predicates.
        /// </summary>
        /// <typeparam name="T">The type of elements in the source.</typeparam>
        /// <param name="predicate">The predicate function to filter with.</param>
        /// <param name="source">The source of elements to filter.</param>
        /// <returns>An enumerable with the elements filtered with the predicate.</returns>
        public static IEnumerable<T> Filter<T>(Func<T, bool> predicate, IEnumerable<T> source)
            => source.Where(predicate);

        /// <summary>
        ///     Takes a predicate and an enumerable, and returns an enumerable of the same type containing the members of the given
        ///     enumerable which satisfy the given predicate.
        /// </summary>
        /// <typeparam name="T">The type of elements in the source.</typeparam>
        /// <param name="predicate">The predicate function to filter with.</param>
        /// <param name="source">The source of elements to filter.</param>
        /// <returns>An enumerable with the elements filtered with the predicate.</returns>
        public static IEnumerable<T> Filter<T>(FuncAny<bool> predicate, IEnumerable<T> source)
            => Filter((T item) => predicate(item), source);
    }
}