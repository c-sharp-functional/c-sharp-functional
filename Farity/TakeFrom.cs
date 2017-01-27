using System.Collections.Generic;

namespace Farity
{
    public static partial class F
    {
        /// <summary>
        /// Returns the contiguous elements of a source, starting from a specified index.
        /// </summary>
        /// <typeparam name="T">The type of elements in the source.</typeparam>
        /// <param name="index">The index from which to start taking the elements.</param>
        /// <param name="list">The list of elements.</param>
        /// <returns>The contiguous elements of the source, starting from the specified index.</returns>
        /// <remarks>Category: List</remarks>
        public static IEnumerable<T> TakeFrom<T>(int index, IReadOnlyList<T> list)
        {
            if (list.Count <= index) yield break;
            for (var i = index; i < list.Count; i++)
                yield return list[i];
        }
    }
}
