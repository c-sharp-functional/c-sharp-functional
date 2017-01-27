using System;

namespace Farity
{
	public static partial class F
	{
		#region Arity 2
		public static Func<T2, TResult> Partial<T1, T2, TResult>(Func<T1, T2, TResult> function, T1 a)
		{
			return (b) => function(a, b);
		}
		#endregion

		#region Arity 3
		public static Func<T2, T3, TResult> Partial<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, T1 a)
		{
			return (b, c) => function(a, b, c);
		}
		#endregion

		#region Arity 4
		public static Func<T2, T3, T4, TResult> Partial<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, T1 a)
		{
			return (b, c, d) => function(a, b, c, d);
		}
		#endregion

		#region Arity 5
		public static Func<T2, T3, T4, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, T1 a)
		{
			return (b, c, d, e) => function(a, b, c, d, e);
		}
		#endregion

		#region Arity 6
		public static Func<T2, T3, T4, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 a)
		{
			return (b, c, d, e, f) => function(a, b, c, d, e, f);
		}
		#endregion

		#region Arity 7
		public static Func<T2, T3, T4, T5, T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a)
		{
			return (b, c, d, e, f, g) => function(a, b, c, d, e, f, g);
		}
		#endregion

		#region Arity 8
		public static Func<T2, T3, T4, T5, T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a)
		{
			return (b, c, d, e, f, g, h) => function(a, b, c, d, e, f, g, h);
		}
		#endregion

		#region Arity 9
		public static Func<T2, T3, T4, T5, T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a)
		{
			return (b, c, d, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);
		}
		#endregion

		#region Arity 10
		public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a)
		{
			return (b, c, d, e, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);
		}
		#endregion

	}
}