using System;
using System.Collections.Generic;

namespace Farity
{
    public static partial class F
    {
        /// <summary>
        /// Iterates over an input enumerable, calling a provided function for each element in the enumerable.
        /// Functions that don't mutate the items in the source are recommended.
        /// </summary>
        /// <typeparam name="T">The type of elements in the enumerable.</typeparam>
        /// <param name="function">The function to be called for each element.</param>
        /// <param name="source">The source of items.</param>
        /// <returns>The items in the source.</returns>
        /// <remarks>Category: List</remarks>
        public static IEnumerable<T> ForEach<T>(Action<T> function, IEnumerable<T> source)
        {
            var tap = Partial<Action<T>, T, T>(Tap, function);
            foreach (var item in source) yield return tap(item);
        }
    }
}