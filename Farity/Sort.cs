using System.Collections.Generic;
using System.Linq;

namespace Farity
{
    public static partial class F
    {
        /// <summary>
        /// Sorts the elements of a sequence in ascending order.
        /// </summary>
        /// <typeparam name="T">The type of elements in the sequence.</typeparam>
        /// <param name="source">The original, unsorted sequence.</param>
        /// <returns>A new sequence containing the elements of the provided sequence, sorted.</returns>
        public static IEnumerable<T> Sort<T>(IEnumerable<T> source) => source.OrderBy(x => x);

    }
}