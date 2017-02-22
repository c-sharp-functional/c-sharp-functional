using System;
using System.Collections.Generic;
using System.Linq;

namespace Farity
{
    public static partial class F
    {
        public static IEnumerable<T> Filter<T>(Func<T, bool> predicate, IEnumerable<T> source)
            => source.Where(predicate);

        public static IEnumerable<T> Filter<T>(FuncAny<bool> predicate, IEnumerable<T> source)
            => source.Where(item => predicate(item));
    }
}