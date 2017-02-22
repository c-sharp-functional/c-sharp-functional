using System;
using System.Collections.Generic;

namespace Farity
{
    public static partial class F
    {
        /// <summary>
        /// Like <seealso cref="Reduce"/>, this returns a single item by iterating through
        ///  the list, successively calling the iterator function. It also takes a predicate
        ///  that is evaluated before each step. If the predicate returns <seealso cref="false"/>,
        ///  it "short-circuits" the iteration and returns the current value of the accumulator.
        /// </summary>
        /// <typeparam name="T">The type of the reduced value.</typeparam>
        /// <typeparam name="TSource">The type of items over which to reduce.</typeparam>
        /// <param name="predicate">The predicate function which is passed the reduced value and the current item.</param>
        /// <param name="reducer">The iterator function which is applied to every item in the list.</param>
        /// <param name="seed">The initial reduced value for the reduce operation.</param>
        /// <param name="items">The list of items over which to reduce.</param>
        /// <returns>The reduced value of the list using the provided seed and reducer function.</returns>
        public static T ReduceWhile<T, TSource>(Func<T, TSource, bool> predicate, Func<T, TSource, T> reducer, T seed, IEnumerable<TSource> items)
        {
            var reduced = seed;
            foreach (var item in items)
            {
                if (!predicate(reduced, item))
                    return reduced;
                reduced = reducer(reduced, item);
            }
            return reduced;
        }
    }
}
