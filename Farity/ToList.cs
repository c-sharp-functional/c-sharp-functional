using System.Collections.Generic;
using System.Collections.Immutable;

namespace Farity
{
    public static partial class F
    {
        public static IReadOnlyList<T> ToList<T>(IEnumerable<T> source) => source.ToImmutableList();
    }
}
