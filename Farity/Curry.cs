using System;

namespace Farity
{
    public static partial class F
    {
        public static
            FuncCurry<T1, T2, TResult>
            Curry<T1, T2, TResult>(
                Func<T1, T2, TResult> function)
            => a => b => function(a, b);

        public static
            FuncCurry<T1, T2, T3, TResult>
            Curry<T1, T2, T3, TResult>(
                Func<T1, T2, T3, TResult> function)
            => a => b => c => function(a, b, c);

        public static
            FuncCurry<T1, T2, T3, T4, TResult>
            Curry<T1, T2, T3, T4, TResult>(
                Func<T1, T2, T3, T4, TResult> function)
            => a => b => c => d => function(a, b, c, d);

        public static
            FuncCurry<T1, T2, T3, T4, T5, TResult>
            Curry<T1, T2, T3, T4, T5, TResult>(
                Func<T1, T2, T3, T4, T5, TResult> function)
            => a => b => c => d => e => function(a, b, c, d, e);

        public static FuncCurry<T1, T2, T3, T4, T5, T6, TResult>
            Curry<T1, T2, T3, T4, T5, T6, TResult>(
                Func<T1, T2, T3, T4, T5, T6, TResult> function)
            => a => b => c => d => e => f => function(a, b, c, d, e, f);

        public static
            FuncCurry<T1, T2, T3, T4, T5, T6, T7, TResult>
            Curry<T1, T2, T3, T4, T5, T6, T7, TResult>(
                Func<T1, T2, T3, T4, T5, T6, T7, TResult> function)
            => a => b => c => d => e => f => g => function(a, b, c, d, e, f, g);

        public static
            FuncCurry<T1, T2, T3, T4, T5, T6, T7, T8, TResult>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
                Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function)
            => a => b => c => d => e => f => g => h => function(a, b, c, d, e, f, g, h);

        public static
            FuncCurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
                Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function)
            => a => b => c => d => e => f => g => h => i => function(a, b, c, d, e, f, g, h, i);

        public static
            FuncCurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
                Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function)
            => a => b => c => d => e => f => g => h => i => j => function(a, b, c, d, e, f, g, h, i, j);
    }
}