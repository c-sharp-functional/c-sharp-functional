using System;

namespace Farity
{
    public static partial class F
    {
        /// <summary>
        /// Subtracts a numeric value from another.
        /// </summary>
        /// <typeparam name="T">The data type of the operands in the subtract operation.</typeparam>
        /// <param name="a">The value from which to subtract.</param>
        /// <param name="b">The value to be subtracted.</param>
        /// <returns>The result of the subtraction operation.</returns>
        public static T Subtract<T>(T a, T b)
            where T : struct,
            IComparable,
            IComparable<T>,
            IConvertible,
            IEquatable<T>,
            IFormattable => Operator<T>.Subtract(a, b);
    }
}