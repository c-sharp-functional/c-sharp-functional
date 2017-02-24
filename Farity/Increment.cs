using System;

namespace Farity
{
    public static partial class F
    {
        /// <summary>
        /// Increments a numeric value by 1.
        /// </summary>
        /// <typeparam name="T">The type of the value to increment.</typeparam>
        /// <param name="value">The value to increment.</param>
        /// <returns>The provided value incremented by 1.</returns>
        public static T Increment<T>(T value)
            where T : struct,
            IComparable,
            IComparable<T>,
            IConvertible,
            IEquatable<T>,
            IFormattable => Add((T) Convert.ChangeType(1, typeof(T)), value);
    }
}