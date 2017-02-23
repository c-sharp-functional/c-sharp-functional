using System;

namespace Farity
{
    public static partial class F
    {
        /// <summary>
        /// Returns the curried version of a function with two arguments.
        /// </summary>
        /// <typeparam name="T1">The type of the first argument to the function.</typeparam>
        /// <typeparam name="T2">The type of the second argument to the function.</typeparam>
        /// <typeparam name="TResult">The type of result of the function.</typeparam>
        /// <param name="function">The function to be curried.</param>
        /// <returns>The curried function representing the provided function.</returns>
        public static
            FuncCurry<T1, T2, TResult>
            Curry<T1, T2, TResult>(
                Func<T1, T2, TResult> function)
            => a => b => function(a, b);

        /// <summary>
        /// Returns the curried version of a function with three arguments.
        /// </summary>
        /// <typeparam name="T1">The type of the first argument to the function.</typeparam>
        /// <typeparam name="T2">The type of the second argument to the function.</typeparam>
        /// <typeparam name="T3">The type of the third argument to the function.</typeparam>
        /// <typeparam name="TResult">The type of result of the function.</typeparam>
        /// <param name="function">The function to be curried.</param>
        /// <returns>The curried function representing the provided function.</returns>
        public static
            FuncCurry<T1, T2, T3, TResult>
            Curry<T1, T2, T3, TResult>(
                Func<T1, T2, T3, TResult> function)
            => a => b => c => function(a, b, c);

        /// <summary>
        /// Returns the curried version of a function with four arguments.
        /// </summary>
        /// <typeparam name="T1">The type of the first argument to the function.</typeparam>
        /// <typeparam name="T2">The type of the second argument to the function.</typeparam>
        /// <typeparam name="T3">The type of the third argument to the function.</typeparam>
        /// <typeparam name="T4">The type of the fourth argument to the function.</typeparam>
        /// <typeparam name="TResult">The type of result of the function.</typeparam>
        /// <param name="function">The function to be curried.</param>
        /// <returns>The curried function representing the provided function.</returns>
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