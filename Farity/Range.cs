using System.Collections.Generic;
using System.Linq;

namespace Farity
{
    public static partial class F
    {
        /// <summary>
        /// Returns a new sequence of integral numbers within a specified range.
        /// </summary>
        /// <param name="start">The first number in the expected sequence.</param>
        /// <param name="end">The last number in the expected sequence.</param>
        /// <returns>A new sequence of integral numbers within the specified range.</returns>
        public static IEnumerable<int> Range(int start, int end)
            => start > end ? Enumerable.Empty<int>() : Enumerable.Range(start, end - start + 1);
    }
}