using System.Collections.Generic;
using System.Linq;

namespace Farity
{
    public static partial class F
    {
        /// <summary>
        /// Returns a new sequence in which all but the first n elements are present.
        /// </summary>
        /// <typeparam name="T">The type of elements in the sequence.</typeparam>
        /// <param name="count">The count of elements to remove.</param>
        /// <param name="source">The sequence of elements from which to drop elements.</param>
        /// <returns>A new sequence in which all but the first n elements are present.</returns>
        public static IEnumerable<T> Drop<T>(int count, IEnumerable<T> source) => source.Skip(count);
    }
}