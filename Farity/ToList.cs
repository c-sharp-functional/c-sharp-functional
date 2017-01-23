using System.Collections.Generic;
using System.Collections.Immutable;

namespace Farity
{
    public static partial class F
    {
        /// <summary>
        /// Converts the source into a read only list.
        /// </summary>
        /// <typeparam name="T">The type of element in the list.</typeparam>
        /// <param name="source">The source of items.</param>
        /// <returns>A read-only list consisting of the elements in the source.</returns>
        public static IReadOnlyList<T> ToList<T>(IEnumerable<T> source) => source.ToImmutableList();
    }
}
