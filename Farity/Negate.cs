using System;

namespace Farity
{
    public static partial class F
    {
        public static T Negate<T>(T n)
            where T : struct,
            IComparable,
            IComparable<T>,
            IConvertible,
            IEquatable<T>,
            IFormattable => Operator<T>.Negate(n);
    }
}