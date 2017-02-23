using System.Collections.Generic;
using System.Linq;

namespace Farity
{
    public static partial class F
    {
        /// <summary>
        /// Returns a new sequence in which the elements are in reverse order.
        /// </summary>
        /// <typeparam name="T">The type of elements in the sequence.</typeparam>
        /// <param name="source">The sequence of elements to reverse.</param>
        /// <returns>A new sequence in which the elements are in reverse order.</returns>
        public static IEnumerable<T> Reverse<T>(IEnumerable<T> source) => new List<T>(source.Reverse()).AsEnumerable();
    }
}