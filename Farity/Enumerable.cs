using System.Collections.Generic;
using System.Linq;

namespace Farity
{
    public static partial class F
    {
        public static T Last<T>(IEnumerable<T> source) => source.Last();
    }
}