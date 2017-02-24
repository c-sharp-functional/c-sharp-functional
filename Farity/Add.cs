using System;
using Farity.Operators;

namespace Farity
{
    public static partial class F
    {
        /// <summary>
        /// Adds two numeric values.
        /// </summary>
        /// <typeparam name="T">The data type of the operands in the add operation.</typeparam>
        /// <param name="a">The addendum.</param>
        /// <param name="b">The additive.</param>
        /// <returns>The result of adding the two values.</returns>
        public static T Add<T>(T a, T b)
            where T : struct,
            IComparable,
            IComparable<T>,
            IConvertible,
            IEquatable<T>,
            IFormattable => Operator<T>.Add(a, b);
    }
}