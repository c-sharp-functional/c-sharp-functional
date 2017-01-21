using System;

namespace Farity
{
    public static partial class F
    {
        public static
            Func<T1, T2, TResult>
            Uncurry<T1, T2, TResult>(
                FuncCurry<T1, T2, TResult> curried)
            => (a, b) => curried(a)(b);

        public static
            Func<T1, T2, T3, TResult>
            Uncurry<T1, T2, T3, TResult>(
                FuncCurry<T1, T2, T3, TResult> curried)
            => (a, b, c) => curried(a)(b)(c);

        public static
            Func<T1, T2, T3, T4, TResult>
            Uncurry<T1, T2, T3, T4, TResult>(
                FuncCurry<T1, T2, T3, T4, TResult> curried)
            => (a, b, c, d) => curried(a)(b)(c)(d);

        public static
            Func<T1, T2, T3, T4, T5, TResult>
            Uncurry<T1, T2, T3, T4, T5, TResult>(
                FuncCurry<T1, T2, T3, T4, T5, TResult> curried)
            => (a, b, c, d, e) => curried(a)(b)(c)(d)(e);

        public static Func<T1, T2, T3, T4, T5, T6, TResult>
            Uncurry<T1, T2, T3, T4, T5, T6, TResult>(
                FuncCurry<T1, T2, T3, T4, T5, T6, TResult> curried)
            => (a, b, c, d, e, f) => curried(a)(b)(c)(d)(e)(f);

        public static
            Func<T1, T2, T3, T4, T5, T6, T7, TResult>
            Uncurry<T1, T2, T3, T4, T5, T6, T7, TResult>(
                FuncCurry<T1, T2, T3, T4, T5, T6, T7, TResult> curried)
            => (a, b, c, d, e, f, g) => curried(a)(b)(c)(d)(e)(f)(g);

        public static
            Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>
            Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
                FuncCurry<T1, T2, T3, T4, T5, T6, T7, T8, TResult> curried)
            => (a, b, c, d, e, f, g, h) => curried(a)(b)(c)(d)(e)(f)(g)(h);

        public static
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>
            Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
                FuncCurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> curried)
            => (a, b, c, d, e, f, g, h, i) => curried(a)(b)(c)(d)(e)(f)(g)(h)(i);

        public static
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>
            Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
                FuncCurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> curried)
            => (a, b, c, d, e, f, g, h, i, j) => curried(a)(b)(c)(d)(e)(f)(g)(h)(i)(j);
    }
}