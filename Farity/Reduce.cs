using System;
using System.Collections.Generic;

namespace Farity
{
    public static partial class F
    {
        /// <summary>
        /// Returns a single item by iterating through the list, successively calling
        /// the iterator function and passing it an accumulator value and the current
        /// value from the array, and then passing the result to the next call.
        /// </summary>
        /// <typeparam name="T">The type of the reduced value.</typeparam>
        /// <typeparam name="TSource">The type of items over which to reduce.</typeparam>
        /// <param name="reducer">The iterator function which is applied to every item in the list.</param>
        /// <param name="seed">The initial reduced value for the reduce operation.</param>
        /// <param name="items">The list of items over which to reduce.</param>
        /// <returns>The reduced value of the list using the provided seed and reducer function.</returns>
        public static T Reduce<T, TSource>(Func<T,TSource,T> reducer, T seed, IEnumerable<TSource> items)
        {
            var reduced = seed;
            foreach (var item in items)
                reduced = reducer(reduced, item);
            return reduced;
        }
    }
}
