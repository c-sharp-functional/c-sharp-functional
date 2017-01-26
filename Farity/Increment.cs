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
            IFormattable => Add((T) Convert.ChangeType(1, typeof(T)), value);
    }
}