using System;

namespace Farity
{
    public delegate
        Func<T2, TResult>
        FuncCurry<in T1, in T2, out TResult>(T1 arg);

    public delegate
        FuncCurry<T2, T3, TResult>
        FuncCurry<in T1, in T2, in T3, out TResult>(T1 arg);

    public delegate
        FuncCurry<T2, T3, T4, TResult>
        FuncCurry<in T1, in T2, in T3, in T4, out TResult>(T1 arg);

    public delegate
        FuncCurry<T2, T3, T4, T5, TResult>
        FuncCurry<in T1, in T2, in T3, in T4, in T5, out TResult>(T1 arg);

    public delegate
        FuncCurry<T2, T3, T4, T5, T6, TResult>
        FuncCurry<in T1, in T2, in T3, in T4, in T5, in T6, out TResult>(T1 arg);

    public delegate
        FuncCurry<T2, T3, T4, T5, T6, T7, TResult>
        FuncCurry<in T1, in T2, in T3, in T4, in T5, in T6, in T7, out TResult>(T1 arg);

    public delegate
        FuncCurry<T2, T3, T4, T5, T6, T7, T8, TResult>
        FuncCurry<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, out TResult>(T1 arg);

    public delegate
        FuncCurry<T2, T3, T4, T5, T6, T7, T8, T9, TResult>
        FuncCurry<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, out TResult>(T1 arg);

    public delegate
        FuncCurry<T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>
        FuncCurry<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, out TResult>(T1 arg);
}