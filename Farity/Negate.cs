using System;

namespace Farity
{
    public static partial class F
    {
        /// <summary>
        /// Negates a numeric value. Does not work with unsigned types.
        /// </summary>
        /// <typeparam name="T">The data type of the value to negate.</typeparam>
        /// <param name="n">The value to be negated.</param>
        /// <returns>The result of negating the provided value.</returns>
        public static T Negate<T>(T n)
            where T : struct,
            IComparable,
            IComparable<T>,
            IConvertible,
            IEquatable<T>,
            IFormattable => Operator<T>.Negate(n);
    }
}