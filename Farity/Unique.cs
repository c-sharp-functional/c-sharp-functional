using System.Collections.Generic;
using System.Linq;

namespace Farity
{
    public static partial class F
    {
        /// <summary>
        /// Returns distinct elements from a sequence by using the default equality comparer to compare values.
        /// </summary>
        /// <typeparam name="T">The type of elements in the sequence.</typeparam>
        /// <param name="source">The sequence of elements on which to operate.</param>
        /// <returns>A new sequence containing distinct elements from the provided sequence.</returns>
        public static IEnumerable<T> Unique<T>(IEnumerable<T> source) => source.Distinct();
    }
}
