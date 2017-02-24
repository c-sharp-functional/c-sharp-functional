using System.Collections.Generic;
using System.Linq;

namespace Farity
{
    public static partial class F
    {
        public static IEnumerable<T> DefaultTo<T>(T value, IEnumerable<T> source) => source.DefaultIfEmpty(value);

        public static T First<T>(IEnumerable<T> source) => source.First();

        public static T Last<T>(IEnumerable<T> source) => source.Last();
    }
}