using System.Collections.Generic;
using System.Linq;

namespace Farity
{
    public static partial class F
    {
        /// <summary>
        /// Returns the first element of a sequence.
        /// </summary>
        /// <typeparam name="T">The type of elements in a sequence.</typeparam>
        /// <param name="source">The sequence from which to take the first element.</param>
        /// <returns>The first element of the provided sequence.</returns>
        public static T First<T>(IEnumerable<T> source) => source.First();
    }
}
