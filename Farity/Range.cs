using System;
using System.Collections.Generic;
using System.Linq;

namespace Farity
{
    public static partial class F
    {
        public static readonly Func<int, int, IEnumerable<int>> Range =
            (start, end) => start > end ? Enumerable.Empty<int>() : Enumerable.Range(start, end - start + 1);
    }
}