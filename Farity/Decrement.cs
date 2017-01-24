using System;

namespace Farity
{
    public static partial class F
    {
        public static T Decrement<T>(T value)
            where T : struct,
            IComparable,
            IComparable<T>,
            IConvertible,
            IEquatable<T>,
            IFormattable => Subtract(value, (T) (object) -1);
    }
}