using System.Collections.Generic;
using System.Linq;

namespace Farity
{
    public static partial class F
    {
        /// <summary>
        /// Returns the last element of a sequence.
        /// </summary>
        /// <typeparam name="T">The type of elemenets in the sequence.</typeparam>
        /// <param name="source">The sequence over which to operate.</param>
        /// <returns>The last element of the provided sequence.</returns>
        public static T Last<T>(IEnumerable<T> source) => source.Last();
    }
}