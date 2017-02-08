using System;

namespace Farity
{
    public static partial class F
    {
        public static
            Func<T1, TResult>
            Compose<T1, T2, TResult>(
                Func<T2, TResult> function2,
                Func<T1, T2> function1)
            => a => function2(function1(a));
    }
}