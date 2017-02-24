using System.Collections.Generic;
using System.Linq;

namespace Farity
{
    public static partial class F
    {
        /// <summary>
        /// Returns a new sequence containing the first n elements of the provided sequence.
        /// </summary>
        /// <typeparam name="T">The type of elements in the sequence.</typeparam>
        /// <param name="count">The count of first elements to take.</param>
        /// <param name="source">The original sequence on which to operate.</param>
        /// <returns>A new sequence containing the first n elements of the provided sequence.</returns>
        public static IEnumerable<T> Take<T>(int count, IEnumerable<T> source) => source.Take(count);
    }
}