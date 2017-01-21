using System;

namespace Farity
{
    public static partial class F
    {
        public static Func<TArg1, Func<TArg2, TResult>> Curry<TArg1, TArg2, TResult>(
            Func<TArg1, TArg2, TResult> function)
        {
            return a => b => function(a, b);
        }

        public static Func<TArg1, Func<TArg2, Func<TArg3, TResult>>> Curry<TArg1, TArg2, TArg3, TResult>(
            Func<TArg1, TArg2, TArg3, TResult> function)
        {
            return a => b => c => function(a, b, c);
        }

        public static Func<TArg1, Func<TArg2, Func<TArg3, Func<TArg4, TResult>>>> Curry
            <TArg1, TArg2, TArg3, TArg4, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TResult> function)
        {
            return a => b => c => d => function(a, b, c, d);
        }

        public static Func<TArg1, Func<TArg2, Func<TArg3, Func<TArg4, Func<TArg5, TResult>>>>> Curry
            <TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> function)
        {
            return a => b => c => d => e => function(a, b, c, d, e);
        }

        public static Func<TArg1, Func<TArg2, Func<TArg3, Func<TArg4, Func<TArg5, Func<TArg6, TResult>>>>>> Curry
            <TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(
                Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> function)
        {
            return a => b => c => d => e => f => function(a, b, c, d, e, f);
        }

        public static Func<TArg1, Func<TArg2, Func<TArg3, Func<TArg4, Func<TArg5, Func<TArg6, Func<TArg7, TResult>>>>>>>
            Curry<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(
                Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> function)
        {
            return a => b => c => d => e => f => g => function(a, b, c, d, e, f, g);
        }

        public static
            Func
            <TArg1, Func<TArg2, Func<TArg3, Func<TArg4, Func<TArg5, Func<TArg6, Func<TArg7, Func<TArg8, TResult>>>>>>>>
            Curry<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(
                Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> function)
        {
            return a => b => c => d => e => f => g => h => function(a, b, c, d, e, f, g, h);
        }

        public static
            Func
            <TArg1,
                Func
                <TArg2,
                    Func<TArg3, Func<TArg4, Func<TArg5, Func<TArg6, Func<TArg7, Func<TArg8, Func<TArg9, TResult>>>>>>>>>
            Curry<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(
                Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> function)
        {
            return a => b => c => d => e => f => g => h => i => function(a, b, c, d, e, f, g, h, i);
        }

        public static
            Func
            <TArg1,
                Func
                <TArg2,
                    Func
                    <TArg3,
                        Func
                        <TArg4, Func<TArg5, Func<TArg6, Func<TArg7, Func<TArg8, Func<TArg9, Func<TArg10, TResult>>>>>>>>
                >> Curry<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
                Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> function)
        {
            return a => b => c => d => e => f => g => h => i => j => function(a, b, c, d, e, f, g, h, i, j);
        }
    }
}