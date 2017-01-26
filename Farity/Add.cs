using System;

namespace Farity
{
    public static partial class F
    {
        public static T Add<T>(T a, T b)
            where T : struct,
            IComparable,
            IComparable<T>,
            IConvertible,
            IEquatable<T>,
            IFormattable => Operator<T>.Add(a, b);
    }
}