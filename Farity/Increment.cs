using System;

namespace Farity
{
    public static partial class F
    {
        public static T Increment<T>(T value)
            where T : struct,
            IComparable,
            IComparable<T>,
            IConvertible,
            IEquatable<T>,
            IFormattable => Add((T) (object) 1, value);
    }
}