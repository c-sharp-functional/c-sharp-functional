using System;

namespace Farity
{
    public static partial class F
    {
        /// <summary>
        /// Decrements a numeric value by 1.
        /// </summary>
        /// <typeparam name="T">The type of the numeric value.</typeparam>
        /// <param name="value">The value to decrement.</param>
        /// <returns>The value decremented by 1.</returns>
        public static T Decrement<T>(T value)
            where T : struct,
            IComparable,
            IComparable<T>,
            IConvertible,
            IEquatable<T>,
            IFormattable => Subtract(value, (T) Convert.ChangeType(1, typeof(T)));
    }
}