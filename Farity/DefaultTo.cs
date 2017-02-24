using System.Linq;
using System.Collections.Generic;

namespace Farity
{
    public static partial class F
    {
        /// <summary>
        /// Returns the elements of the specified sequence or the specified value in a singleton collection if the sequence is empty.
        /// </summary>
        /// <typeparam name="T">The type of elements in the sequence.</typeparam>
        /// <param name="value">The default value.</param>
        /// <param name="source">The sequence to operate on.</param>
        /// <returns>The elements of the specified sequence, or the specified value in a singleton collection if the sequence is empty.</returns>
        public static IEnumerable<T> DefaultTo<T>(T value, IEnumerable<T> source) => source.DefaultIfEmpty(value);
    }
}
