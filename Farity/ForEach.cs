using System;
using System.Collections.Generic;

namespace Farity
{
    public static partial class F
    {
        /// <summary>
        /// Iterates over an input enumerable, calling a provided function for each element in the enumerable.
        /// </summary>
        /// <typeparam name="T">The type of elements in the enumerable.</typeparam>
        /// <param name="function">The function to be called for each element.</param>
        /// <param name="source">The source of items.</param>
        /// <remarks>Category: List</remarks>
        public static void ForEach<T>(Action<T> function, IEnumerable<T> source)
        {
            foreach (var item in source)
                function(item);
        }
    }
}