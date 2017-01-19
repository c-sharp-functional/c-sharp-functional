using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Functional
{
    public static partial class F
    {
        public static IEnumerable<int> Range(int start, int end) => Enumerable.Range(start, end - start + 1);

        public static IList<T> ToList<T>(IEnumerable<T> source) => source.ToList();

        public static IEnumerable<T> Reverse<T>(IEnumerable<T> source) => source.Reverse();

        public static IEnumerable<T> Drop<T>(int count, IEnumerable<T> source) => source.Skip(count);

        public static IEnumerable<T> Take<T>(int count, IEnumerable<T> source) => source.Take(count);

        public static IEnumerable<T> Sort<T>(IEnumerable<T> source) => source.OrderBy(x => x);

        public static IEnumerable<T> Unique<T>(IEnumerable<T> source) => source.Distinct();

        public static IEnumerable<T> SkipUntil<T>(int index, IEnumerable<T> source)
        {
            if (!(source is IReadOnlyList<T>))
            {
                var i = 0;
                foreach (var item in source)
                    if (index >= i++) yield return item;
            }
            var list = (IReadOnlyList<T>) source;
            for (var i = index; i < list.Count; i++)
                yield return list[i];
        }

        public static IEnumerable<T> Filter<T>(Func<T, bool> predicate, IEnumerable<T> source)
            => source.Where(predicate);

        public static IEnumerable<T> DefaultTo<T>(T value, IEnumerable<T> source) => source.DefaultIfEmpty(value);

        public static T First<T>(IEnumerable<T> source) => source.First();

        public static T Last<T>(IEnumerable<T> source) => source.Last();
    }
}