using System;
using P = Farity.Placeholder;

namespace Farity
{
	public static partial class F
	{
		#region Arity 2

		public static
			Func<T1, TResult>
			Partial<T1, T2, TResult>(
				Func<T1, T2, TResult> function,
				P pA, T2 b)
		=> (a) => function(a, b);

		public static
			Func<T2, TResult>
			Partial<T1, T2, TResult>(
				Func<T1, T2, TResult> function,
				T1 a)
		=> (b) => function(a, b);

		#endregion

		#region Arity 3

		public static
			Func<T1, T2, TResult>
			Partial<T1, T2, T3, TResult>(
				Func<T1, T2, T3, TResult> function,
				P pA, P pB, T3 c)
		=> (a, b) => function(a, b, c);

		public static
			Func<T1, T3, TResult>
			Partial<T1, T2, T3, TResult>(
				Func<T1, T2, T3, TResult> function,
				P pA, T2 b)
		=> (a, c) => function(a, b, c);

		public static
			Func<T1, TResult>
			Partial<T1, T2, T3, TResult>(
				Func<T1, T2, T3, TResult> function,
				P pA, T2 b, T3 c)
		=> (a) => function(a, b, c);

		public static
			Func<T2, T3, TResult>
			Partial<T1, T2, T3, TResult>(
				Func<T1, T2, T3, TResult> function,
				T1 a)
		=> (b, c) => function(a, b, c);

		public static
			Func<T2, TResult>
			Partial<T1, T2, T3, TResult>(
				Func<T1, T2, T3, TResult> function,
				T1 a, P pB, T3 c)
		=> (b) => function(a, b, c);

		public static
			Func<T3, TResult>
			Partial<T1, T2, T3, TResult>(
				Func<T1, T2, T3, TResult> function,
				T1 a, T2 b)
		=> (c) => function(a, b, c);

		#endregion

		#region Arity 4

		public static
			Func<T1, T2, T3, TResult>
			Partial<T1, T2, T3, T4, TResult>(
				Func<T1, T2, T3, T4, TResult> function,
				P pA, P pB, P pC, T4 d)
		=> (a, b, c) => function(a, b, c, d);

		public static
			Func<T1, T2, T4, TResult>
			Partial<T1, T2, T3, T4, TResult>(
				Func<T1, T2, T3, T4, TResult> function,
				P pA, P pB, T3 c)
		=> (a, b, d) => function(a, b, c, d);

		public static
			Func<T1, T2, TResult>
			Partial<T1, T2, T3, T4, TResult>(
				Func<T1, T2, T3, T4, TResult> function,
				P pA, P pB, T3 c, T4 d)
		=> (a, b) => function(a, b, c, d);

		public static
			Func<T1, T3, T4, TResult>
			Partial<T1, T2, T3, T4, TResult>(
				Func<T1, T2, T3, T4, TResult> function,
				P pA, T2 b)
		=> (a, c, d) => function(a, b, c, d);

		public static
			Func<T1, T3, TResult>
			Partial<T1, T2, T3, T4, TResult>(
				Func<T1, T2, T3, T4, TResult> function,
				P pA, T2 b, P pC, T4 d)
		=> (a, c) => function(a, b, c, d);

		public static
			Func<T1, T4, TResult>
			Partial<T1, T2, T3, T4, TResult>(
				Func<T1, T2, T3, T4, TResult> function,
				P pA, T2 b, T3 c)
		=> (a, d) => function(a, b, c, d);

		public static
			Func<T1, TResult>
			Partial<T1, T2, T3, T4, TResult>(
				Func<T1, T2, T3, T4, TResult> function,
				P pA, T2 b, T3 c, T4 d)
		=> (a) => function(a, b, c, d);

		public static
			Func<T2, T3, T4, TResult>
			Partial<T1, T2, T3, T4, TResult>(
				Func<T1, T2, T3, T4, TResult> function,
				T1 a)
		=> (b, c, d) => function(a, b, c, d);

		public static
			Func<T2, T3, TResult>
			Partial<T1, T2, T3, T4, TResult>(
				Func<T1, T2, T3, T4, TResult> function,
				T1 a, P pB, P pC, T4 d)
		=> (b, c) => function(a, b, c, d);

		public static
			Func<T2, T4, TResult>
			Partial<T1, T2, T3, T4, TResult>(
				Func<T1, T2, T3, T4, TResult> function,
				T1 a, P pB, T3 c)
		=> (b, d) => function(a, b, c, d);

		public static
			Func<T2, TResult>
			Partial<T1, T2, T3, T4, TResult>(
				Func<T1, T2, T3, T4, TResult> function,
				T1 a, P pB, T3 c, T4 d)
		=> (b) => function(a, b, c, d);

		public static
			Func<T3, T4, TResult>
			Partial<T1, T2, T3, T4, TResult>(
				Func<T1, T2, T3, T4, TResult> function,
				T1 a, T2 b)
		=> (c, d) => function(a, b, c, d);

		public static
			Func<T3, TResult>
			Partial<T1, T2, T3, T4, TResult>(
				Func<T1, T2, T3, T4, TResult> function,
				T1 a, T2 b, P pC, T4 d)
		=> (c) => function(a, b, c, d);

		public static
			Func<T4, TResult>
			Partial<T1, T2, T3, T4, TResult>(
				Func<T1, T2, T3, T4, TResult> function,
				T1 a, T2 b, T3 c)
		=> (d) => function(a, b, c, d);

		#endregion

		#region Arity 5

		public static
			Func<T1, T2, T3, T4, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				P pA, P pB, P pC, P pD, T5 e)
		=> (a, b, c, d) => function(a, b, c, d, e);

		public static
			Func<T1, T2, T3, T5, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				P pA, P pB, P pC, T4 d)
		=> (a, b, c, e) => function(a, b, c, d, e);

		public static
			Func<T1, T2, T3, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e)
		=> (a, b, c) => function(a, b, c, d, e);

		public static
			Func<T1, T2, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				P pA, P pB, T3 c)
		=> (a, b, d, e) => function(a, b, c, d, e);

		public static
			Func<T1, T2, T4, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e)
		=> (a, b, d) => function(a, b, c, d, e);

		public static
			Func<T1, T2, T5, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				P pA, P pB, T3 c, T4 d)
		=> (a, b, e) => function(a, b, c, d, e);

		public static
			Func<T1, T2, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e)
		=> (a, b) => function(a, b, c, d, e);

		public static
			Func<T1, T3, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				P pA, T2 b)
		=> (a, c, d, e) => function(a, b, c, d, e);

		public static
			Func<T1, T3, T4, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e)
		=> (a, c, d) => function(a, b, c, d, e);

		public static
			Func<T1, T3, T5, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				P pA, T2 b, P pC, T4 d)
		=> (a, c, e) => function(a, b, c, d, e);

		public static
			Func<T1, T3, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e)
		=> (a, c) => function(a, b, c, d, e);

		public static
			Func<T1, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				P pA, T2 b, T3 c)
		=> (a, d, e) => function(a, b, c, d, e);

		public static
			Func<T1, T4, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e)
		=> (a, d) => function(a, b, c, d, e);

		public static
			Func<T1, T5, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				P pA, T2 b, T3 c, T4 d)
		=> (a, e) => function(a, b, c, d, e);

		public static
			Func<T1, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e)
		=> (a) => function(a, b, c, d, e);

		public static
			Func<T2, T3, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				T1 a)
		=> (b, c, d, e) => function(a, b, c, d, e);

		public static
			Func<T2, T3, T4, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e)
		=> (b, c, d) => function(a, b, c, d, e);

		public static
			Func<T2, T3, T5, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				T1 a, P pB, P pC, T4 d)
		=> (b, c, e) => function(a, b, c, d, e);

		public static
			Func<T2, T3, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e)
		=> (b, c) => function(a, b, c, d, e);

		public static
			Func<T2, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				T1 a, P pB, T3 c)
		=> (b, d, e) => function(a, b, c, d, e);

		public static
			Func<T2, T4, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e)
		=> (b, d) => function(a, b, c, d, e);

		public static
			Func<T2, T5, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				T1 a, P pB, T3 c, T4 d)
		=> (b, e) => function(a, b, c, d, e);

		public static
			Func<T2, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e)
		=> (b) => function(a, b, c, d, e);

		public static
			Func<T3, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				T1 a, T2 b)
		=> (c, d, e) => function(a, b, c, d, e);

		public static
			Func<T3, T4, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e)
		=> (c, d) => function(a, b, c, d, e);

		public static
			Func<T3, T5, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				T1 a, T2 b, P pC, T4 d)
		=> (c, e) => function(a, b, c, d, e);

		public static
			Func<T3, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e)
		=> (c) => function(a, b, c, d, e);

		public static
			Func<T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				T1 a, T2 b, T3 c)
		=> (d, e) => function(a, b, c, d, e);

		public static
			Func<T4, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e)
		=> (d) => function(a, b, c, d, e);

		public static
			Func<T5, TResult>
			Partial<T1, T2, T3, T4, T5, TResult>(
				Func<T1, T2, T3, T4, T5, TResult> function,
				T1 a, T2 b, T3 c, T4 d)
		=> (e) => function(a, b, c, d, e);

		#endregion

		#region Arity 6

		public static
			Func<T1, T2, T3, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f)
		=> (a, b, c, d, e) => function(a, b, c, d, e, f);

		public static
			Func<T1, T2, T3, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, P pB, P pC, P pD, T5 e)
		=> (a, b, c, d, f) => function(a, b, c, d, e, f);

		public static
			Func<T1, T2, T3, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f)
		=> (a, b, c, d) => function(a, b, c, d, e, f);

		public static
			Func<T1, T2, T3, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, P pB, P pC, T4 d)
		=> (a, b, c, e, f) => function(a, b, c, d, e, f);

		public static
			Func<T1, T2, T3, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f)
		=> (a, b, c, e) => function(a, b, c, d, e, f);

		public static
			Func<T1, T2, T3, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e)
		=> (a, b, c, f) => function(a, b, c, d, e, f);

		public static
			Func<T1, T2, T3, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f)
		=> (a, b, c) => function(a, b, c, d, e, f);

		public static
			Func<T1, T2, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, P pB, T3 c)
		=> (a, b, d, e, f) => function(a, b, c, d, e, f);

		public static
			Func<T1, T2, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f)
		=> (a, b, d, e) => function(a, b, c, d, e, f);

		public static
			Func<T1, T2, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e)
		=> (a, b, d, f) => function(a, b, c, d, e, f);

		public static
			Func<T1, T2, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f)
		=> (a, b, d) => function(a, b, c, d, e, f);

		public static
			Func<T1, T2, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, P pB, T3 c, T4 d)
		=> (a, b, e, f) => function(a, b, c, d, e, f);

		public static
			Func<T1, T2, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f)
		=> (a, b, e) => function(a, b, c, d, e, f);

		public static
			Func<T1, T2, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e)
		=> (a, b, f) => function(a, b, c, d, e, f);

		public static
			Func<T1, T2, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f)
		=> (a, b) => function(a, b, c, d, e, f);

		public static
			Func<T1, T3, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, T2 b)
		=> (a, c, d, e, f) => function(a, b, c, d, e, f);

		public static
			Func<T1, T3, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f)
		=> (a, c, d, e) => function(a, b, c, d, e, f);

		public static
			Func<T1, T3, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e)
		=> (a, c, d, f) => function(a, b, c, d, e, f);

		public static
			Func<T1, T3, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f)
		=> (a, c, d) => function(a, b, c, d, e, f);

		public static
			Func<T1, T3, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, T2 b, P pC, T4 d)
		=> (a, c, e, f) => function(a, b, c, d, e, f);

		public static
			Func<T1, T3, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f)
		=> (a, c, e) => function(a, b, c, d, e, f);

		public static
			Func<T1, T3, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e)
		=> (a, c, f) => function(a, b, c, d, e, f);

		public static
			Func<T1, T3, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f)
		=> (a, c) => function(a, b, c, d, e, f);

		public static
			Func<T1, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, T2 b, T3 c)
		=> (a, d, e, f) => function(a, b, c, d, e, f);

		public static
			Func<T1, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f)
		=> (a, d, e) => function(a, b, c, d, e, f);

		public static
			Func<T1, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e)
		=> (a, d, f) => function(a, b, c, d, e, f);

		public static
			Func<T1, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f)
		=> (a, d) => function(a, b, c, d, e, f);

		public static
			Func<T1, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, T2 b, T3 c, T4 d)
		=> (a, e, f) => function(a, b, c, d, e, f);

		public static
			Func<T1, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f)
		=> (a, e) => function(a, b, c, d, e, f);

		public static
			Func<T1, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e)
		=> (a, f) => function(a, b, c, d, e, f);

		public static
			Func<T1, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f)
		=> (a) => function(a, b, c, d, e, f);

		public static
			Func<T2, T3, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a)
		=> (b, c, d, e, f) => function(a, b, c, d, e, f);

		public static
			Func<T2, T3, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f)
		=> (b, c, d, e) => function(a, b, c, d, e, f);

		public static
			Func<T2, T3, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e)
		=> (b, c, d, f) => function(a, b, c, d, e, f);

		public static
			Func<T2, T3, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f)
		=> (b, c, d) => function(a, b, c, d, e, f);

		public static
			Func<T2, T3, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, P pB, P pC, T4 d)
		=> (b, c, e, f) => function(a, b, c, d, e, f);

		public static
			Func<T2, T3, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f)
		=> (b, c, e) => function(a, b, c, d, e, f);

		public static
			Func<T2, T3, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e)
		=> (b, c, f) => function(a, b, c, d, e, f);

		public static
			Func<T2, T3, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f)
		=> (b, c) => function(a, b, c, d, e, f);

		public static
			Func<T2, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, P pB, T3 c)
		=> (b, d, e, f) => function(a, b, c, d, e, f);

		public static
			Func<T2, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f)
		=> (b, d, e) => function(a, b, c, d, e, f);

		public static
			Func<T2, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e)
		=> (b, d, f) => function(a, b, c, d, e, f);

		public static
			Func<T2, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f)
		=> (b, d) => function(a, b, c, d, e, f);

		public static
			Func<T2, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, P pB, T3 c, T4 d)
		=> (b, e, f) => function(a, b, c, d, e, f);

		public static
			Func<T2, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f)
		=> (b, e) => function(a, b, c, d, e, f);

		public static
			Func<T2, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e)
		=> (b, f) => function(a, b, c, d, e, f);

		public static
			Func<T2, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f)
		=> (b) => function(a, b, c, d, e, f);

		public static
			Func<T3, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, T2 b)
		=> (c, d, e, f) => function(a, b, c, d, e, f);

		public static
			Func<T3, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f)
		=> (c, d, e) => function(a, b, c, d, e, f);

		public static
			Func<T3, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e)
		=> (c, d, f) => function(a, b, c, d, e, f);

		public static
			Func<T3, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f)
		=> (c, d) => function(a, b, c, d, e, f);

		public static
			Func<T3, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, T2 b, P pC, T4 d)
		=> (c, e, f) => function(a, b, c, d, e, f);

		public static
			Func<T3, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f)
		=> (c, e) => function(a, b, c, d, e, f);

		public static
			Func<T3, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e)
		=> (c, f) => function(a, b, c, d, e, f);

		public static
			Func<T3, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f)
		=> (c) => function(a, b, c, d, e, f);

		public static
			Func<T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, T2 b, T3 c)
		=> (d, e, f) => function(a, b, c, d, e, f);

		public static
			Func<T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f)
		=> (d, e) => function(a, b, c, d, e, f);

		public static
			Func<T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e)
		=> (d, f) => function(a, b, c, d, e, f);

		public static
			Func<T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f)
		=> (d) => function(a, b, c, d, e, f);

		public static
			Func<T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, T2 b, T3 c, T4 d)
		=> (e, f) => function(a, b, c, d, e, f);

		public static
			Func<T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f)
		=> (e) => function(a, b, c, d, e, f);

		public static
			Func<T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T1, T2, T3, T4, T5, T6, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e)
		=> (f) => function(a, b, c, d, e, f);

		#endregion

		#region Arity 7

		public static
			Func<T1, T2, T3, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, P pC, P pD, P pE, P pF, T7 g)
		=> (a, b, c, d, e, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, T3, T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f)
		=> (a, b, c, d, e, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, T3, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f, T7 g)
		=> (a, b, c, d, e) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, T3, T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, P pC, P pD, T5 e)
		=> (a, b, c, d, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, T3, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, P pF, T7 g)
		=> (a, b, c, d, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, T3, T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f)
		=> (a, b, c, d, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, T3, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f, T7 g)
		=> (a, b, c, d) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, T3, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, P pC, T4 d)
		=> (a, b, c, e, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, T3, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, P pF, T7 g)
		=> (a, b, c, e, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, T3, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f)
		=> (a, b, c, e, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, T3, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f, T7 g)
		=> (a, b, c, e) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, T3, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e)
		=> (a, b, c, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, T3, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, P pF, T7 g)
		=> (a, b, c, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, T3, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f)
		=> (a, b, c, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, T3, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f, T7 g)
		=> (a, b, c) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, T3 c)
		=> (a, b, d, e, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, P pF, T7 g)
		=> (a, b, d, e, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f)
		=> (a, b, d, e, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f, T7 g)
		=> (a, b, d, e) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e)
		=> (a, b, d, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, P pF, T7 g)
		=> (a, b, d, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f)
		=> (a, b, d, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f, T7 g)
		=> (a, b, d) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, T3 c, T4 d)
		=> (a, b, e, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, P pF, T7 g)
		=> (a, b, e, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f)
		=> (a, b, e, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f, T7 g)
		=> (a, b, e) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e)
		=> (a, b, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, P pF, T7 g)
		=> (a, b, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f)
		=> (a, b, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T2, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f, T7 g)
		=> (a, b) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T3, T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b)
		=> (a, c, d, e, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T3, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, P pF, T7 g)
		=> (a, c, d, e, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T3, T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f)
		=> (a, c, d, e, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T3, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f, T7 g)
		=> (a, c, d, e) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T3, T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e)
		=> (a, c, d, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T3, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, P pF, T7 g)
		=> (a, c, d, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T3, T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f)
		=> (a, c, d, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T3, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f, T7 g)
		=> (a, c, d) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T3, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, P pC, T4 d)
		=> (a, c, e, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T3, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, P pF, T7 g)
		=> (a, c, e, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T3, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f)
		=> (a, c, e, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T3, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f, T7 g)
		=> (a, c, e) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T3, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e)
		=> (a, c, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T3, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, P pF, T7 g)
		=> (a, c, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T3, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f)
		=> (a, c, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T3, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f, T7 g)
		=> (a, c) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, T3 c)
		=> (a, d, e, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, P pF, T7 g)
		=> (a, d, e, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f)
		=> (a, d, e, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f, T7 g)
		=> (a, d, e) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e)
		=> (a, d, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, P pF, T7 g)
		=> (a, d, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f)
		=> (a, d, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f, T7 g)
		=> (a, d) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, T3 c, T4 d)
		=> (a, e, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, P pF, T7 g)
		=> (a, e, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f)
		=> (a, e, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f, T7 g)
		=> (a, e) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e)
		=> (a, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, P pF, T7 g)
		=> (a, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f)
		=> (a, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T1, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
		=> (a) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T3, T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a)
		=> (b, c, d, e, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T3, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, P pF, T7 g)
		=> (b, c, d, e, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T3, T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f)
		=> (b, c, d, e, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T3, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f, T7 g)
		=> (b, c, d, e) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T3, T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e)
		=> (b, c, d, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T3, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, P pF, T7 g)
		=> (b, c, d, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T3, T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f)
		=> (b, c, d, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T3, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f, T7 g)
		=> (b, c, d) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T3, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, P pC, T4 d)
		=> (b, c, e, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T3, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, P pF, T7 g)
		=> (b, c, e, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T3, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f)
		=> (b, c, e, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T3, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f, T7 g)
		=> (b, c, e) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T3, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e)
		=> (b, c, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T3, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, P pF, T7 g)
		=> (b, c, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T3, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f)
		=> (b, c, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T3, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f, T7 g)
		=> (b, c) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, T3 c)
		=> (b, d, e, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, P pF, T7 g)
		=> (b, d, e, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f)
		=> (b, d, e, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f, T7 g)
		=> (b, d, e) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e)
		=> (b, d, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, P pF, T7 g)
		=> (b, d, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f)
		=> (b, d, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f, T7 g)
		=> (b, d) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, T3 c, T4 d)
		=> (b, e, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, P pF, T7 g)
		=> (b, e, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f)
		=> (b, e, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f, T7 g)
		=> (b, e) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e)
		=> (b, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, P pF, T7 g)
		=> (b, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f)
		=> (b, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T2, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f, T7 g)
		=> (b) => function(a, b, c, d, e, f, g);

		public static
			Func<T3, T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b)
		=> (c, d, e, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T3, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, P pF, T7 g)
		=> (c, d, e, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T3, T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f)
		=> (c, d, e, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T3, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f, T7 g)
		=> (c, d, e) => function(a, b, c, d, e, f, g);

		public static
			Func<T3, T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e)
		=> (c, d, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T3, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, P pF, T7 g)
		=> (c, d, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T3, T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f)
		=> (c, d, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T3, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f, T7 g)
		=> (c, d) => function(a, b, c, d, e, f, g);

		public static
			Func<T3, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, P pC, T4 d)
		=> (c, e, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T3, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, P pF, T7 g)
		=> (c, e, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T3, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f)
		=> (c, e, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T3, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f, T7 g)
		=> (c, e) => function(a, b, c, d, e, f, g);

		public static
			Func<T3, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e)
		=> (c, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T3, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, P pF, T7 g)
		=> (c, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T3, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f)
		=> (c, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T3, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f, T7 g)
		=> (c) => function(a, b, c, d, e, f, g);

		public static
			Func<T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, T3 c)
		=> (d, e, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, P pF, T7 g)
		=> (d, e, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f)
		=> (d, e, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f, T7 g)
		=> (d, e) => function(a, b, c, d, e, f, g);

		public static
			Func<T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e)
		=> (d, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, P pF, T7 g)
		=> (d, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f)
		=> (d, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f, T7 g)
		=> (d) => function(a, b, c, d, e, f, g);

		public static
			Func<T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, T3 c, T4 d)
		=> (e, f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, P pF, T7 g)
		=> (e, f) => function(a, b, c, d, e, f, g);

		public static
			Func<T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f)
		=> (e, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f, T7 g)
		=> (e) => function(a, b, c, d, e, f, g);

		public static
			Func<T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e)
		=> (f, g) => function(a, b, c, d, e, f, g);

		public static
			Func<T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, P pF, T7 g)
		=> (f) => function(a, b, c, d, e, f, g);

		public static
			Func<T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
		=> (g) => function(a, b, c, d, e, f, g);

		#endregion

		#region Arity 8

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, P pD, P pE, P pF, P pG, T8 h)
		=> (a, b, c, d, e, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, T4, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, P pD, P pE, P pF, T7 g)
		=> (a, b, c, d, e, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, P pD, P pE, P pF, T7 g, T8 h)
		=> (a, b, c, d, e, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, T4, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f)
		=> (a, b, c, d, e, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f, P pG, T8 h)
		=> (a, b, c, d, e, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, T4, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f, T7 g)
		=> (a, b, c, d, e, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f, T7 g, T8 h)
		=> (a, b, c, d, e) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, T4, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, P pD, T5 e)
		=> (a, b, c, d, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, P pF, P pG, T8 h)
		=> (a, b, c, d, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, T4, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, P pF, T7 g)
		=> (a, b, c, d, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, P pF, T7 g, T8 h)
		=> (a, b, c, d, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, T4, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f)
		=> (a, b, c, d, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f, P pG, T8 h)
		=> (a, b, c, d, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, T4, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f, T7 g)
		=> (a, b, c, d, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f, T7 g, T8 h)
		=> (a, b, c, d) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, T4 d)
		=> (a, b, c, e, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, P pF, P pG, T8 h)
		=> (a, b, c, e, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, P pF, T7 g)
		=> (a, b, c, e, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, P pF, T7 g, T8 h)
		=> (a, b, c, e, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f)
		=> (a, b, c, e, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f, P pG, T8 h)
		=> (a, b, c, e, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f, T7 g)
		=> (a, b, c, e, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f, T7 g, T8 h)
		=> (a, b, c, e) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e)
		=> (a, b, c, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, P pF, P pG, T8 h)
		=> (a, b, c, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, P pF, T7 g)
		=> (a, b, c, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, P pF, T7 g, T8 h)
		=> (a, b, c, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f)
		=> (a, b, c, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f, P pG, T8 h)
		=> (a, b, c, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f, T7 g)
		=> (a, b, c, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T3, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f, T7 g, T8 h)
		=> (a, b, c) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T4, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c)
		=> (a, b, d, e, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, P pF, P pG, T8 h)
		=> (a, b, d, e, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T4, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, P pF, T7 g)
		=> (a, b, d, e, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, P pF, T7 g, T8 h)
		=> (a, b, d, e, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T4, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f)
		=> (a, b, d, e, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f, P pG, T8 h)
		=> (a, b, d, e, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T4, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f, T7 g)
		=> (a, b, d, e, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f, T7 g, T8 h)
		=> (a, b, d, e) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T4, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e)
		=> (a, b, d, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, P pF, P pG, T8 h)
		=> (a, b, d, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T4, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, P pF, T7 g)
		=> (a, b, d, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, P pF, T7 g, T8 h)
		=> (a, b, d, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T4, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f)
		=> (a, b, d, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f, P pG, T8 h)
		=> (a, b, d, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T4, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f, T7 g)
		=> (a, b, d, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f, T7 g, T8 h)
		=> (a, b, d) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, T4 d)
		=> (a, b, e, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, P pF, P pG, T8 h)
		=> (a, b, e, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, P pF, T7 g)
		=> (a, b, e, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, P pF, T7 g, T8 h)
		=> (a, b, e, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f)
		=> (a, b, e, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f, P pG, T8 h)
		=> (a, b, e, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f, T7 g)
		=> (a, b, e, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f, T7 g, T8 h)
		=> (a, b, e) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e)
		=> (a, b, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, P pF, P pG, T8 h)
		=> (a, b, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, P pF, T7 g)
		=> (a, b, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, P pF, T7 g, T8 h)
		=> (a, b, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f)
		=> (a, b, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f, P pG, T8 h)
		=> (a, b, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f, T7 g)
		=> (a, b, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T2, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		=> (a, b) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T4, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b)
		=> (a, c, d, e, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, P pF, P pG, T8 h)
		=> (a, c, d, e, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T4, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, P pF, T7 g)
		=> (a, c, d, e, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, P pF, T7 g, T8 h)
		=> (a, c, d, e, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T4, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f)
		=> (a, c, d, e, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f, P pG, T8 h)
		=> (a, c, d, e, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T4, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f, T7 g)
		=> (a, c, d, e, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f, T7 g, T8 h)
		=> (a, c, d, e) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T4, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e)
		=> (a, c, d, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, P pF, P pG, T8 h)
		=> (a, c, d, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T4, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, P pF, T7 g)
		=> (a, c, d, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, P pF, T7 g, T8 h)
		=> (a, c, d, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T4, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f)
		=> (a, c, d, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f, P pG, T8 h)
		=> (a, c, d, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T4, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f, T7 g)
		=> (a, c, d, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f, T7 g, T8 h)
		=> (a, c, d) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, T4 d)
		=> (a, c, e, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, P pF, P pG, T8 h)
		=> (a, c, e, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, P pF, T7 g)
		=> (a, c, e, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, P pF, T7 g, T8 h)
		=> (a, c, e, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f)
		=> (a, c, e, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f, P pG, T8 h)
		=> (a, c, e, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f, T7 g)
		=> (a, c, e, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f, T7 g, T8 h)
		=> (a, c, e) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e)
		=> (a, c, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, P pF, P pG, T8 h)
		=> (a, c, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, P pF, T7 g)
		=> (a, c, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, P pF, T7 g, T8 h)
		=> (a, c, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f)
		=> (a, c, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f, P pG, T8 h)
		=> (a, c, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f, T7 g)
		=> (a, c, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T3, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f, T7 g, T8 h)
		=> (a, c) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T4, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c)
		=> (a, d, e, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, P pF, P pG, T8 h)
		=> (a, d, e, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T4, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, P pF, T7 g)
		=> (a, d, e, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, P pF, T7 g, T8 h)
		=> (a, d, e, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T4, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f)
		=> (a, d, e, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f, P pG, T8 h)
		=> (a, d, e, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T4, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f, T7 g)
		=> (a, d, e, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f, T7 g, T8 h)
		=> (a, d, e) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T4, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e)
		=> (a, d, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, P pF, P pG, T8 h)
		=> (a, d, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T4, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, P pF, T7 g)
		=> (a, d, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, P pF, T7 g, T8 h)
		=> (a, d, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T4, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f)
		=> (a, d, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f, P pG, T8 h)
		=> (a, d, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T4, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f, T7 g)
		=> (a, d, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f, T7 g, T8 h)
		=> (a, d) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, T4 d)
		=> (a, e, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, P pF, P pG, T8 h)
		=> (a, e, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, P pF, T7 g)
		=> (a, e, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, P pF, T7 g, T8 h)
		=> (a, e, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f)
		=> (a, e, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f, P pG, T8 h)
		=> (a, e, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f, T7 g)
		=> (a, e, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f, T7 g, T8 h)
		=> (a, e) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e)
		=> (a, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, P pF, P pG, T8 h)
		=> (a, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, P pF, T7 g)
		=> (a, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, P pF, T7 g, T8 h)
		=> (a, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f)
		=> (a, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f, P pG, T8 h)
		=> (a, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
		=> (a, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T1, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		=> (a) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T4, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a)
		=> (b, c, d, e, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, P pF, P pG, T8 h)
		=> (b, c, d, e, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T4, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, P pF, T7 g)
		=> (b, c, d, e, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, P pF, T7 g, T8 h)
		=> (b, c, d, e, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T4, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f)
		=> (b, c, d, e, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f, P pG, T8 h)
		=> (b, c, d, e, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T4, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f, T7 g)
		=> (b, c, d, e, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f, T7 g, T8 h)
		=> (b, c, d, e) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T4, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e)
		=> (b, c, d, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, P pF, P pG, T8 h)
		=> (b, c, d, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T4, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, P pF, T7 g)
		=> (b, c, d, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, P pF, T7 g, T8 h)
		=> (b, c, d, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T4, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f)
		=> (b, c, d, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f, P pG, T8 h)
		=> (b, c, d, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T4, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f, T7 g)
		=> (b, c, d, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f, T7 g, T8 h)
		=> (b, c, d) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, T4 d)
		=> (b, c, e, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, P pF, P pG, T8 h)
		=> (b, c, e, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, P pF, T7 g)
		=> (b, c, e, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, P pF, T7 g, T8 h)
		=> (b, c, e, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f)
		=> (b, c, e, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f, P pG, T8 h)
		=> (b, c, e, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f, T7 g)
		=> (b, c, e, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f, T7 g, T8 h)
		=> (b, c, e) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e)
		=> (b, c, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, P pF, P pG, T8 h)
		=> (b, c, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, P pF, T7 g)
		=> (b, c, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, P pF, T7 g, T8 h)
		=> (b, c, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f)
		=> (b, c, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f, P pG, T8 h)
		=> (b, c, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f, T7 g)
		=> (b, c, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T3, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f, T7 g, T8 h)
		=> (b, c) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T4, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c)
		=> (b, d, e, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, P pF, P pG, T8 h)
		=> (b, d, e, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T4, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, P pF, T7 g)
		=> (b, d, e, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, P pF, T7 g, T8 h)
		=> (b, d, e, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T4, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f)
		=> (b, d, e, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f, P pG, T8 h)
		=> (b, d, e, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T4, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f, T7 g)
		=> (b, d, e, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f, T7 g, T8 h)
		=> (b, d, e) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T4, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e)
		=> (b, d, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, P pF, P pG, T8 h)
		=> (b, d, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T4, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, P pF, T7 g)
		=> (b, d, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, P pF, T7 g, T8 h)
		=> (b, d, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T4, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f)
		=> (b, d, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f, P pG, T8 h)
		=> (b, d, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T4, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f, T7 g)
		=> (b, d, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f, T7 g, T8 h)
		=> (b, d) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, T4 d)
		=> (b, e, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, P pF, P pG, T8 h)
		=> (b, e, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, P pF, T7 g)
		=> (b, e, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, P pF, T7 g, T8 h)
		=> (b, e, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f)
		=> (b, e, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f, P pG, T8 h)
		=> (b, e, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f, T7 g)
		=> (b, e, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f, T7 g, T8 h)
		=> (b, e) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e)
		=> (b, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, P pF, P pG, T8 h)
		=> (b, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, P pF, T7 g)
		=> (b, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, P pF, T7 g, T8 h)
		=> (b, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f)
		=> (b, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f, P pG, T8 h)
		=> (b, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f, T7 g)
		=> (b, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T2, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		=> (b) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T4, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b)
		=> (c, d, e, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, P pF, P pG, T8 h)
		=> (c, d, e, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T4, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, P pF, T7 g)
		=> (c, d, e, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, P pF, T7 g, T8 h)
		=> (c, d, e, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T4, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f)
		=> (c, d, e, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f, P pG, T8 h)
		=> (c, d, e, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T4, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f, T7 g)
		=> (c, d, e, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f, T7 g, T8 h)
		=> (c, d, e) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T4, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e)
		=> (c, d, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, P pF, P pG, T8 h)
		=> (c, d, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T4, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, P pF, T7 g)
		=> (c, d, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, P pF, T7 g, T8 h)
		=> (c, d, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T4, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f)
		=> (c, d, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f, P pG, T8 h)
		=> (c, d, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T4, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f, T7 g)
		=> (c, d, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f, T7 g, T8 h)
		=> (c, d) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, T4 d)
		=> (c, e, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, P pF, P pG, T8 h)
		=> (c, e, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, P pF, T7 g)
		=> (c, e, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, P pF, T7 g, T8 h)
		=> (c, e, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f)
		=> (c, e, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f, P pG, T8 h)
		=> (c, e, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f, T7 g)
		=> (c, e, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f, T7 g, T8 h)
		=> (c, e) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e)
		=> (c, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, P pF, P pG, T8 h)
		=> (c, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, P pF, T7 g)
		=> (c, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, P pF, T7 g, T8 h)
		=> (c, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f)
		=> (c, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f, P pG, T8 h)
		=> (c, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f, T7 g)
		=> (c, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T3, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f, T7 g, T8 h)
		=> (c) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T4, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c)
		=> (d, e, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, P pF, P pG, T8 h)
		=> (d, e, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T4, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, P pF, T7 g)
		=> (d, e, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, P pF, T7 g, T8 h)
		=> (d, e, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T4, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f)
		=> (d, e, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f, P pG, T8 h)
		=> (d, e, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T4, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f, T7 g)
		=> (d, e, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f, T7 g, T8 h)
		=> (d, e) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T4, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e)
		=> (d, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, P pF, P pG, T8 h)
		=> (d, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T4, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, P pF, T7 g)
		=> (d, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, P pF, T7 g, T8 h)
		=> (d, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T4, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f)
		=> (d, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f, P pG, T8 h)
		=> (d, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T4, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f, T7 g)
		=> (d, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f, T7 g, T8 h)
		=> (d) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, T4 d)
		=> (e, f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, P pF, P pG, T8 h)
		=> (e, f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, P pF, T7 g)
		=> (e, f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, P pF, T7 g, T8 h)
		=> (e, f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f)
		=> (e, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f, P pG, T8 h)
		=> (e, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f, T7 g)
		=> (e, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f, T7 g, T8 h)
		=> (e) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e)
		=> (f, g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, P pF, P pG, T8 h)
		=> (f, g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, P pF, T7 g)
		=> (f, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, P pF, T7 g, T8 h)
		=> (f) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
		=> (g, h) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, P pG, T8 h)
		=> (g) => function(a, b, c, d, e, f, g, h);

		public static
			Func<T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
		=> (h) => function(a, b, c, d, e, f, g, h);

		#endregion

		#region Arity 9

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, P pE, P pF, P pG, P pH, T9 i)
		=> (a, b, c, d, e, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, P pE, P pF, P pG, T8 h)
		=> (a, b, c, d, e, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, P pE, P pF, P pG, T8 h, T9 i)
		=> (a, b, c, d, e, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, P pE, P pF, T7 g)
		=> (a, b, c, d, e, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, P pE, P pF, T7 g, P pH, T9 i)
		=> (a, b, c, d, e, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, P pE, P pF, T7 g, T8 h)
		=> (a, b, c, d, e, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, P pE, P pF, T7 g, T8 h, T9 i)
		=> (a, b, c, d, e, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f)
		=> (a, b, c, d, e, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f, P pG, P pH, T9 i)
		=> (a, b, c, d, e, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f, P pG, T8 h)
		=> (a, b, c, d, e, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f, P pG, T8 h, T9 i)
		=> (a, b, c, d, e, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f, T7 g)
		=> (a, b, c, d, e, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f, T7 g, P pH, T9 i)
		=> (a, b, c, d, e, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f, T7 g, T8 h)
		=> (a, b, c, d, e, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (a, b, c, d, e) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, T5 e)
		=> (a, b, c, d, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, P pF, P pG, P pH, T9 i)
		=> (a, b, c, d, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, P pF, P pG, T8 h)
		=> (a, b, c, d, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, P pF, P pG, T8 h, T9 i)
		=> (a, b, c, d, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, P pF, T7 g)
		=> (a, b, c, d, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, P pF, T7 g, P pH, T9 i)
		=> (a, b, c, d, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, P pF, T7 g, T8 h)
		=> (a, b, c, d, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (a, b, c, d, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f)
		=> (a, b, c, d, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f, P pG, P pH, T9 i)
		=> (a, b, c, d, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f, P pG, T8 h)
		=> (a, b, c, d, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (a, b, c, d, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f, T7 g)
		=> (a, b, c, d, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (a, b, c, d, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f, T7 g, T8 h)
		=> (a, b, c, d, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (a, b, c, d) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d)
		=> (a, b, c, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, P pF, P pG, P pH, T9 i)
		=> (a, b, c, e, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, P pF, P pG, T8 h)
		=> (a, b, c, e, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, P pF, P pG, T8 h, T9 i)
		=> (a, b, c, e, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, P pF, T7 g)
		=> (a, b, c, e, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, P pF, T7 g, P pH, T9 i)
		=> (a, b, c, e, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, P pF, T7 g, T8 h)
		=> (a, b, c, e, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, P pF, T7 g, T8 h, T9 i)
		=> (a, b, c, e, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f)
		=> (a, b, c, e, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f, P pG, P pH, T9 i)
		=> (a, b, c, e, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f, P pG, T8 h)
		=> (a, b, c, e, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f, P pG, T8 h, T9 i)
		=> (a, b, c, e, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f, T7 g)
		=> (a, b, c, e, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f, T7 g, P pH, T9 i)
		=> (a, b, c, e, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f, T7 g, T8 h)
		=> (a, b, c, e, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (a, b, c, e) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e)
		=> (a, b, c, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, P pF, P pG, P pH, T9 i)
		=> (a, b, c, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, P pF, P pG, T8 h)
		=> (a, b, c, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, P pF, P pG, T8 h, T9 i)
		=> (a, b, c, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, P pF, T7 g)
		=> (a, b, c, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, P pF, T7 g, P pH, T9 i)
		=> (a, b, c, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, P pF, T7 g, T8 h)
		=> (a, b, c, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (a, b, c, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f)
		=> (a, b, c, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f, P pG, P pH, T9 i)
		=> (a, b, c, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f, P pG, T8 h)
		=> (a, b, c, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (a, b, c, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f, T7 g)
		=> (a, b, c, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (a, b, c, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f, T7 g, T8 h)
		=> (a, b, c, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T3, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (a, b, c) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c)
		=> (a, b, d, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, P pF, P pG, P pH, T9 i)
		=> (a, b, d, e, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, P pF, P pG, T8 h)
		=> (a, b, d, e, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, P pF, P pG, T8 h, T9 i)
		=> (a, b, d, e, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, P pF, T7 g)
		=> (a, b, d, e, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, P pF, T7 g, P pH, T9 i)
		=> (a, b, d, e, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, P pF, T7 g, T8 h)
		=> (a, b, d, e, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, P pF, T7 g, T8 h, T9 i)
		=> (a, b, d, e, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f)
		=> (a, b, d, e, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f, P pG, P pH, T9 i)
		=> (a, b, d, e, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f, P pG, T8 h)
		=> (a, b, d, e, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f, P pG, T8 h, T9 i)
		=> (a, b, d, e, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f, T7 g)
		=> (a, b, d, e, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f, T7 g, P pH, T9 i)
		=> (a, b, d, e, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f, T7 g, T8 h)
		=> (a, b, d, e, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (a, b, d, e) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e)
		=> (a, b, d, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, P pF, P pG, P pH, T9 i)
		=> (a, b, d, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, P pF, P pG, T8 h)
		=> (a, b, d, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, P pF, P pG, T8 h, T9 i)
		=> (a, b, d, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, P pF, T7 g)
		=> (a, b, d, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, P pF, T7 g, P pH, T9 i)
		=> (a, b, d, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, P pF, T7 g, T8 h)
		=> (a, b, d, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (a, b, d, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f)
		=> (a, b, d, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f, P pG, P pH, T9 i)
		=> (a, b, d, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f, P pG, T8 h)
		=> (a, b, d, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (a, b, d, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f, T7 g)
		=> (a, b, d, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (a, b, d, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f, T7 g, T8 h)
		=> (a, b, d, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (a, b, d) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d)
		=> (a, b, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, P pF, P pG, P pH, T9 i)
		=> (a, b, e, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, P pF, P pG, T8 h)
		=> (a, b, e, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, P pF, P pG, T8 h, T9 i)
		=> (a, b, e, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, P pF, T7 g)
		=> (a, b, e, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, P pF, T7 g, P pH, T9 i)
		=> (a, b, e, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, P pF, T7 g, T8 h)
		=> (a, b, e, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, P pF, T7 g, T8 h, T9 i)
		=> (a, b, e, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f)
		=> (a, b, e, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f, P pG, P pH, T9 i)
		=> (a, b, e, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f, P pG, T8 h)
		=> (a, b, e, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f, P pG, T8 h, T9 i)
		=> (a, b, e, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f, T7 g)
		=> (a, b, e, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f, T7 g, P pH, T9 i)
		=> (a, b, e, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f, T7 g, T8 h)
		=> (a, b, e, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (a, b, e) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e)
		=> (a, b, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, P pF, P pG, P pH, T9 i)
		=> (a, b, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, P pF, P pG, T8 h)
		=> (a, b, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, P pF, P pG, T8 h, T9 i)
		=> (a, b, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, P pF, T7 g)
		=> (a, b, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, P pF, T7 g, P pH, T9 i)
		=> (a, b, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, P pF, T7 g, T8 h)
		=> (a, b, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (a, b, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f)
		=> (a, b, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f, P pG, P pH, T9 i)
		=> (a, b, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f, P pG, T8 h)
		=> (a, b, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (a, b, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f, T7 g)
		=> (a, b, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (a, b, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		=> (a, b, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T2, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (a, b) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b)
		=> (a, c, d, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, P pF, P pG, P pH, T9 i)
		=> (a, c, d, e, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, P pF, P pG, T8 h)
		=> (a, c, d, e, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, P pF, P pG, T8 h, T9 i)
		=> (a, c, d, e, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, P pF, T7 g)
		=> (a, c, d, e, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, P pF, T7 g, P pH, T9 i)
		=> (a, c, d, e, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, P pF, T7 g, T8 h)
		=> (a, c, d, e, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, P pF, T7 g, T8 h, T9 i)
		=> (a, c, d, e, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f)
		=> (a, c, d, e, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f, P pG, P pH, T9 i)
		=> (a, c, d, e, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f, P pG, T8 h)
		=> (a, c, d, e, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f, P pG, T8 h, T9 i)
		=> (a, c, d, e, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f, T7 g)
		=> (a, c, d, e, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f, T7 g, P pH, T9 i)
		=> (a, c, d, e, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f, T7 g, T8 h)
		=> (a, c, d, e, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (a, c, d, e) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e)
		=> (a, c, d, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, P pF, P pG, P pH, T9 i)
		=> (a, c, d, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, P pF, P pG, T8 h)
		=> (a, c, d, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, P pF, P pG, T8 h, T9 i)
		=> (a, c, d, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, P pF, T7 g)
		=> (a, c, d, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, P pF, T7 g, P pH, T9 i)
		=> (a, c, d, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, P pF, T7 g, T8 h)
		=> (a, c, d, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (a, c, d, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f)
		=> (a, c, d, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f, P pG, P pH, T9 i)
		=> (a, c, d, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f, P pG, T8 h)
		=> (a, c, d, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (a, c, d, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f, T7 g)
		=> (a, c, d, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (a, c, d, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f, T7 g, T8 h)
		=> (a, c, d, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (a, c, d) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d)
		=> (a, c, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, P pF, P pG, P pH, T9 i)
		=> (a, c, e, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, P pF, P pG, T8 h)
		=> (a, c, e, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, P pF, P pG, T8 h, T9 i)
		=> (a, c, e, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, P pF, T7 g)
		=> (a, c, e, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, P pF, T7 g, P pH, T9 i)
		=> (a, c, e, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, P pF, T7 g, T8 h)
		=> (a, c, e, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, P pF, T7 g, T8 h, T9 i)
		=> (a, c, e, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f)
		=> (a, c, e, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f, P pG, P pH, T9 i)
		=> (a, c, e, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f, P pG, T8 h)
		=> (a, c, e, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f, P pG, T8 h, T9 i)
		=> (a, c, e, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f, T7 g)
		=> (a, c, e, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f, T7 g, P pH, T9 i)
		=> (a, c, e, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f, T7 g, T8 h)
		=> (a, c, e, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (a, c, e) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e)
		=> (a, c, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, P pF, P pG, P pH, T9 i)
		=> (a, c, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, P pF, P pG, T8 h)
		=> (a, c, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, P pF, P pG, T8 h, T9 i)
		=> (a, c, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, P pF, T7 g)
		=> (a, c, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, P pF, T7 g, P pH, T9 i)
		=> (a, c, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, P pF, T7 g, T8 h)
		=> (a, c, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (a, c, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f)
		=> (a, c, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f, P pG, P pH, T9 i)
		=> (a, c, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f, P pG, T8 h)
		=> (a, c, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (a, c, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f, T7 g)
		=> (a, c, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (a, c, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f, T7 g, T8 h)
		=> (a, c, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T3, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (a, c) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c)
		=> (a, d, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, P pF, P pG, P pH, T9 i)
		=> (a, d, e, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, P pF, P pG, T8 h)
		=> (a, d, e, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, P pF, P pG, T8 h, T9 i)
		=> (a, d, e, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, P pF, T7 g)
		=> (a, d, e, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, P pF, T7 g, P pH, T9 i)
		=> (a, d, e, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, P pF, T7 g, T8 h)
		=> (a, d, e, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, P pF, T7 g, T8 h, T9 i)
		=> (a, d, e, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f)
		=> (a, d, e, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f, P pG, P pH, T9 i)
		=> (a, d, e, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f, P pG, T8 h)
		=> (a, d, e, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f, P pG, T8 h, T9 i)
		=> (a, d, e, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f, T7 g)
		=> (a, d, e, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f, T7 g, P pH, T9 i)
		=> (a, d, e, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f, T7 g, T8 h)
		=> (a, d, e, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (a, d, e) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e)
		=> (a, d, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, P pF, P pG, P pH, T9 i)
		=> (a, d, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, P pF, P pG, T8 h)
		=> (a, d, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, P pF, P pG, T8 h, T9 i)
		=> (a, d, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, P pF, T7 g)
		=> (a, d, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, P pF, T7 g, P pH, T9 i)
		=> (a, d, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, P pF, T7 g, T8 h)
		=> (a, d, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (a, d, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f)
		=> (a, d, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f, P pG, P pH, T9 i)
		=> (a, d, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f, P pG, T8 h)
		=> (a, d, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (a, d, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f, T7 g)
		=> (a, d, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (a, d, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f, T7 g, T8 h)
		=> (a, d, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (a, d) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d)
		=> (a, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, P pF, P pG, P pH, T9 i)
		=> (a, e, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, P pF, P pG, T8 h)
		=> (a, e, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, P pF, P pG, T8 h, T9 i)
		=> (a, e, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, P pF, T7 g)
		=> (a, e, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, P pF, T7 g, P pH, T9 i)
		=> (a, e, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, P pF, T7 g, T8 h)
		=> (a, e, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, P pF, T7 g, T8 h, T9 i)
		=> (a, e, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f)
		=> (a, e, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f, P pG, P pH, T9 i)
		=> (a, e, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f, P pG, T8 h)
		=> (a, e, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f, P pG, T8 h, T9 i)
		=> (a, e, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f, T7 g)
		=> (a, e, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f, T7 g, P pH, T9 i)
		=> (a, e, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f, T7 g, T8 h)
		=> (a, e, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (a, e) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e)
		=> (a, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, P pF, P pG, P pH, T9 i)
		=> (a, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, P pF, P pG, T8 h)
		=> (a, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, P pF, P pG, T8 h, T9 i)
		=> (a, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, P pF, T7 g)
		=> (a, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, P pF, T7 g, P pH, T9 i)
		=> (a, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, P pF, T7 g, T8 h)
		=> (a, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (a, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f)
		=> (a, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f, P pG, P pH, T9 i)
		=> (a, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f, P pG, T8 h)
		=> (a, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (a, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
		=> (a, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (a, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		=> (a, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T1, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (a) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a)
		=> (b, c, d, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, P pF, P pG, P pH, T9 i)
		=> (b, c, d, e, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, P pF, P pG, T8 h)
		=> (b, c, d, e, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, P pF, P pG, T8 h, T9 i)
		=> (b, c, d, e, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, P pF, T7 g)
		=> (b, c, d, e, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, P pF, T7 g, P pH, T9 i)
		=> (b, c, d, e, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, P pF, T7 g, T8 h)
		=> (b, c, d, e, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, P pF, T7 g, T8 h, T9 i)
		=> (b, c, d, e, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f)
		=> (b, c, d, e, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f, P pG, P pH, T9 i)
		=> (b, c, d, e, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f, P pG, T8 h)
		=> (b, c, d, e, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f, P pG, T8 h, T9 i)
		=> (b, c, d, e, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f, T7 g)
		=> (b, c, d, e, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f, T7 g, P pH, T9 i)
		=> (b, c, d, e, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f, T7 g, T8 h)
		=> (b, c, d, e, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (b, c, d, e) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e)
		=> (b, c, d, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, P pF, P pG, P pH, T9 i)
		=> (b, c, d, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, P pF, P pG, T8 h)
		=> (b, c, d, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, P pF, P pG, T8 h, T9 i)
		=> (b, c, d, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, P pF, T7 g)
		=> (b, c, d, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, P pF, T7 g, P pH, T9 i)
		=> (b, c, d, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, P pF, T7 g, T8 h)
		=> (b, c, d, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (b, c, d, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f)
		=> (b, c, d, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f, P pG, P pH, T9 i)
		=> (b, c, d, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f, P pG, T8 h)
		=> (b, c, d, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (b, c, d, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f, T7 g)
		=> (b, c, d, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (b, c, d, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f, T7 g, T8 h)
		=> (b, c, d, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (b, c, d) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d)
		=> (b, c, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, P pF, P pG, P pH, T9 i)
		=> (b, c, e, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, P pF, P pG, T8 h)
		=> (b, c, e, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, P pF, P pG, T8 h, T9 i)
		=> (b, c, e, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, P pF, T7 g)
		=> (b, c, e, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, P pF, T7 g, P pH, T9 i)
		=> (b, c, e, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, P pF, T7 g, T8 h)
		=> (b, c, e, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, P pF, T7 g, T8 h, T9 i)
		=> (b, c, e, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f)
		=> (b, c, e, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f, P pG, P pH, T9 i)
		=> (b, c, e, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f, P pG, T8 h)
		=> (b, c, e, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f, P pG, T8 h, T9 i)
		=> (b, c, e, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f, T7 g)
		=> (b, c, e, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f, T7 g, P pH, T9 i)
		=> (b, c, e, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f, T7 g, T8 h)
		=> (b, c, e, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (b, c, e) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e)
		=> (b, c, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, P pF, P pG, P pH, T9 i)
		=> (b, c, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, P pF, P pG, T8 h)
		=> (b, c, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, P pF, P pG, T8 h, T9 i)
		=> (b, c, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, P pF, T7 g)
		=> (b, c, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, P pF, T7 g, P pH, T9 i)
		=> (b, c, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, P pF, T7 g, T8 h)
		=> (b, c, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (b, c, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f)
		=> (b, c, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f, P pG, P pH, T9 i)
		=> (b, c, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f, P pG, T8 h)
		=> (b, c, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (b, c, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f, T7 g)
		=> (b, c, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (b, c, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f, T7 g, T8 h)
		=> (b, c, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T3, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (b, c) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c)
		=> (b, d, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, P pF, P pG, P pH, T9 i)
		=> (b, d, e, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, P pF, P pG, T8 h)
		=> (b, d, e, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, P pF, P pG, T8 h, T9 i)
		=> (b, d, e, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, P pF, T7 g)
		=> (b, d, e, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, P pF, T7 g, P pH, T9 i)
		=> (b, d, e, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, P pF, T7 g, T8 h)
		=> (b, d, e, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, P pF, T7 g, T8 h, T9 i)
		=> (b, d, e, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f)
		=> (b, d, e, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f, P pG, P pH, T9 i)
		=> (b, d, e, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f, P pG, T8 h)
		=> (b, d, e, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f, P pG, T8 h, T9 i)
		=> (b, d, e, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f, T7 g)
		=> (b, d, e, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f, T7 g, P pH, T9 i)
		=> (b, d, e, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f, T7 g, T8 h)
		=> (b, d, e, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (b, d, e) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e)
		=> (b, d, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, P pF, P pG, P pH, T9 i)
		=> (b, d, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, P pF, P pG, T8 h)
		=> (b, d, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, P pF, P pG, T8 h, T9 i)
		=> (b, d, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, P pF, T7 g)
		=> (b, d, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, P pF, T7 g, P pH, T9 i)
		=> (b, d, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, P pF, T7 g, T8 h)
		=> (b, d, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (b, d, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f)
		=> (b, d, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f, P pG, P pH, T9 i)
		=> (b, d, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f, P pG, T8 h)
		=> (b, d, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (b, d, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f, T7 g)
		=> (b, d, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (b, d, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f, T7 g, T8 h)
		=> (b, d, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (b, d) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d)
		=> (b, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, P pF, P pG, P pH, T9 i)
		=> (b, e, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, P pF, P pG, T8 h)
		=> (b, e, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, P pF, P pG, T8 h, T9 i)
		=> (b, e, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, P pF, T7 g)
		=> (b, e, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, P pF, T7 g, P pH, T9 i)
		=> (b, e, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, P pF, T7 g, T8 h)
		=> (b, e, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, P pF, T7 g, T8 h, T9 i)
		=> (b, e, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f)
		=> (b, e, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f, P pG, P pH, T9 i)
		=> (b, e, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f, P pG, T8 h)
		=> (b, e, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f, P pG, T8 h, T9 i)
		=> (b, e, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f, T7 g)
		=> (b, e, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f, T7 g, P pH, T9 i)
		=> (b, e, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f, T7 g, T8 h)
		=> (b, e, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (b, e) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e)
		=> (b, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, P pF, P pG, P pH, T9 i)
		=> (b, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, P pF, P pG, T8 h)
		=> (b, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, P pF, P pG, T8 h, T9 i)
		=> (b, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, P pF, T7 g)
		=> (b, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, P pF, T7 g, P pH, T9 i)
		=> (b, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, P pF, T7 g, T8 h)
		=> (b, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (b, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f)
		=> (b, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f, P pG, P pH, T9 i)
		=> (b, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f, P pG, T8 h)
		=> (b, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (b, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f, T7 g)
		=> (b, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (b, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		=> (b, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T2, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (b) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b)
		=> (c, d, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, P pF, P pG, P pH, T9 i)
		=> (c, d, e, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, P pF, P pG, T8 h)
		=> (c, d, e, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, P pF, P pG, T8 h, T9 i)
		=> (c, d, e, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, P pF, T7 g)
		=> (c, d, e, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, P pF, T7 g, P pH, T9 i)
		=> (c, d, e, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, P pF, T7 g, T8 h)
		=> (c, d, e, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, P pF, T7 g, T8 h, T9 i)
		=> (c, d, e, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f)
		=> (c, d, e, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f, P pG, P pH, T9 i)
		=> (c, d, e, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f, P pG, T8 h)
		=> (c, d, e, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f, P pG, T8 h, T9 i)
		=> (c, d, e, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f, T7 g)
		=> (c, d, e, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f, T7 g, P pH, T9 i)
		=> (c, d, e, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f, T7 g, T8 h)
		=> (c, d, e, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (c, d, e) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e)
		=> (c, d, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, P pF, P pG, P pH, T9 i)
		=> (c, d, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, P pF, P pG, T8 h)
		=> (c, d, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, P pF, P pG, T8 h, T9 i)
		=> (c, d, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, P pF, T7 g)
		=> (c, d, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, P pF, T7 g, P pH, T9 i)
		=> (c, d, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, P pF, T7 g, T8 h)
		=> (c, d, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (c, d, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f)
		=> (c, d, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f, P pG, P pH, T9 i)
		=> (c, d, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f, P pG, T8 h)
		=> (c, d, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (c, d, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f, T7 g)
		=> (c, d, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (c, d, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f, T7 g, T8 h)
		=> (c, d, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (c, d) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d)
		=> (c, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, P pF, P pG, P pH, T9 i)
		=> (c, e, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, P pF, P pG, T8 h)
		=> (c, e, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, P pF, P pG, T8 h, T9 i)
		=> (c, e, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, P pF, T7 g)
		=> (c, e, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, P pF, T7 g, P pH, T9 i)
		=> (c, e, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, P pF, T7 g, T8 h)
		=> (c, e, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, P pF, T7 g, T8 h, T9 i)
		=> (c, e, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f)
		=> (c, e, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f, P pG, P pH, T9 i)
		=> (c, e, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f, P pG, T8 h)
		=> (c, e, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f, P pG, T8 h, T9 i)
		=> (c, e, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f, T7 g)
		=> (c, e, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f, T7 g, P pH, T9 i)
		=> (c, e, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f, T7 g, T8 h)
		=> (c, e, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (c, e) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e)
		=> (c, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, P pF, P pG, P pH, T9 i)
		=> (c, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, P pF, P pG, T8 h)
		=> (c, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, P pF, P pG, T8 h, T9 i)
		=> (c, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, P pF, T7 g)
		=> (c, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, P pF, T7 g, P pH, T9 i)
		=> (c, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, P pF, T7 g, T8 h)
		=> (c, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (c, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f)
		=> (c, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f, P pG, P pH, T9 i)
		=> (c, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f, P pG, T8 h)
		=> (c, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (c, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f, T7 g)
		=> (c, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (c, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f, T7 g, T8 h)
		=> (c, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T3, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (c) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c)
		=> (d, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, P pF, P pG, P pH, T9 i)
		=> (d, e, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, P pF, P pG, T8 h)
		=> (d, e, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, P pF, P pG, T8 h, T9 i)
		=> (d, e, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, P pF, T7 g)
		=> (d, e, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, P pF, T7 g, P pH, T9 i)
		=> (d, e, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, P pF, T7 g, T8 h)
		=> (d, e, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, P pF, T7 g, T8 h, T9 i)
		=> (d, e, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f)
		=> (d, e, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f, P pG, P pH, T9 i)
		=> (d, e, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f, P pG, T8 h)
		=> (d, e, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f, P pG, T8 h, T9 i)
		=> (d, e, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f, T7 g)
		=> (d, e, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f, T7 g, P pH, T9 i)
		=> (d, e, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f, T7 g, T8 h)
		=> (d, e, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (d, e) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e)
		=> (d, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, P pF, P pG, P pH, T9 i)
		=> (d, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, P pF, P pG, T8 h)
		=> (d, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, P pF, P pG, T8 h, T9 i)
		=> (d, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, P pF, T7 g)
		=> (d, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, P pF, T7 g, P pH, T9 i)
		=> (d, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, P pF, T7 g, T8 h)
		=> (d, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (d, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f)
		=> (d, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f, P pG, P pH, T9 i)
		=> (d, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f, P pG, T8 h)
		=> (d, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (d, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f, T7 g)
		=> (d, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (d, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f, T7 g, T8 h)
		=> (d, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (d) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d)
		=> (e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, P pF, P pG, P pH, T9 i)
		=> (e, f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, P pF, P pG, T8 h)
		=> (e, f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, P pF, P pG, T8 h, T9 i)
		=> (e, f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, P pF, T7 g)
		=> (e, f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, P pF, T7 g, P pH, T9 i)
		=> (e, f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, P pF, T7 g, T8 h)
		=> (e, f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, P pF, T7 g, T8 h, T9 i)
		=> (e, f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f)
		=> (e, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f, P pG, P pH, T9 i)
		=> (e, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f, P pG, T8 h)
		=> (e, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f, P pG, T8 h, T9 i)
		=> (e, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f, T7 g)
		=> (e, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f, T7 g, P pH, T9 i)
		=> (e, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f, T7 g, T8 h)
		=> (e, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (e) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e)
		=> (f, g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, P pF, P pG, P pH, T9 i)
		=> (f, g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, P pF, P pG, T8 h)
		=> (f, g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, P pF, P pG, T8 h, T9 i)
		=> (f, g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, P pF, T7 g)
		=> (f, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, P pF, T7 g, P pH, T9 i)
		=> (f, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, P pF, T7 g, T8 h)
		=> (f, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (f) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
		=> (g, h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, P pG, P pH, T9 i)
		=> (g, h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, P pG, T8 h)
		=> (g, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (g) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
		=> (h, i) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (h) => function(a, b, c, d, e, f, g, h, i);

		public static
			Func<T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		=> (i) => function(a, b, c, d, e, f, g, h, i);

		#endregion

		#region Arity 10

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, P pF, P pG, P pH, P pI, T10 j)
		=> (a, b, c, d, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, P pF, P pG, P pH, T9 i)
		=> (a, b, c, d, e, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, P pF, P pG, P pH, T9 i, T10 j)
		=> (a, b, c, d, e, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, P pF, P pG, T8 h)
		=> (a, b, c, d, e, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, P pF, P pG, T8 h, P pI, T10 j)
		=> (a, b, c, d, e, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, P pF, P pG, T8 h, T9 i)
		=> (a, b, c, d, e, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, P pF, P pG, T8 h, T9 i, T10 j)
		=> (a, b, c, d, e, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, P pF, T7 g)
		=> (a, b, c, d, e, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, P pF, T7 g, P pH, P pI, T10 j)
		=> (a, b, c, d, e, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, P pF, T7 g, P pH, T9 i)
		=> (a, b, c, d, e, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, P pF, T7 g, P pH, T9 i, T10 j)
		=> (a, b, c, d, e, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, P pF, T7 g, T8 h)
		=> (a, b, c, d, e, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, P pF, T7 g, T8 h, P pI, T10 j)
		=> (a, b, c, d, e, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, P pF, T7 g, T8 h, T9 i)
		=> (a, b, c, d, e, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (a, b, c, d, e, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f)
		=> (a, b, c, d, e, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f, P pG, P pH, P pI, T10 j)
		=> (a, b, c, d, e, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f, P pG, P pH, T9 i)
		=> (a, b, c, d, e, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f, P pG, P pH, T9 i, T10 j)
		=> (a, b, c, d, e, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f, P pG, T8 h)
		=> (a, b, c, d, e, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f, P pG, T8 h, P pI, T10 j)
		=> (a, b, c, d, e, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f, P pG, T8 h, T9 i)
		=> (a, b, c, d, e, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (a, b, c, d, e, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f, T7 g)
		=> (a, b, c, d, e, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f, T7 g, P pH, P pI, T10 j)
		=> (a, b, c, d, e, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f, T7 g, P pH, T9 i)
		=> (a, b, c, d, e, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (a, b, c, d, e, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f, T7 g, T8 h)
		=> (a, b, c, d, e, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (a, b, c, d, e, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (a, b, c, d, e, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, P pE, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (a, b, c, d, e) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e)
		=> (a, b, c, d, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, P pF, P pG, P pH, P pI, T10 j)
		=> (a, b, c, d, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, P pF, P pG, P pH, T9 i)
		=> (a, b, c, d, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, P pF, P pG, P pH, T9 i, T10 j)
		=> (a, b, c, d, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, P pF, P pG, T8 h)
		=> (a, b, c, d, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, P pF, P pG, T8 h, P pI, T10 j)
		=> (a, b, c, d, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, P pF, P pG, T8 h, T9 i)
		=> (a, b, c, d, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, P pF, P pG, T8 h, T9 i, T10 j)
		=> (a, b, c, d, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, P pF, T7 g)
		=> (a, b, c, d, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, P pF, T7 g, P pH, P pI, T10 j)
		=> (a, b, c, d, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, P pF, T7 g, P pH, T9 i)
		=> (a, b, c, d, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, P pF, T7 g, P pH, T9 i, T10 j)
		=> (a, b, c, d, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, P pF, T7 g, T8 h)
		=> (a, b, c, d, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, P pF, T7 g, T8 h, P pI, T10 j)
		=> (a, b, c, d, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (a, b, c, d, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (a, b, c, d, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f)
		=> (a, b, c, d, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f, P pG, P pH, P pI, T10 j)
		=> (a, b, c, d, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f, P pG, P pH, T9 i)
		=> (a, b, c, d, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f, P pG, P pH, T9 i, T10 j)
		=> (a, b, c, d, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f, P pG, T8 h)
		=> (a, b, c, d, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f, P pG, T8 h, P pI, T10 j)
		=> (a, b, c, d, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (a, b, c, d, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (a, b, c, d, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f, T7 g)
		=> (a, b, c, d, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f, T7 g, P pH, P pI, T10 j)
		=> (a, b, c, d, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (a, b, c, d, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (a, b, c, d, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f, T7 g, T8 h)
		=> (a, b, c, d, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (a, b, c, d, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (a, b, c, d, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, P pD, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (a, b, c, d) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d)
		=> (a, b, c, e, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, P pF, P pG, P pH, P pI, T10 j)
		=> (a, b, c, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, P pF, P pG, P pH, T9 i)
		=> (a, b, c, e, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, P pF, P pG, P pH, T9 i, T10 j)
		=> (a, b, c, e, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, P pF, P pG, T8 h)
		=> (a, b, c, e, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, P pF, P pG, T8 h, P pI, T10 j)
		=> (a, b, c, e, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, P pF, P pG, T8 h, T9 i)
		=> (a, b, c, e, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, P pF, P pG, T8 h, T9 i, T10 j)
		=> (a, b, c, e, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, P pF, T7 g)
		=> (a, b, c, e, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, P pF, T7 g, P pH, P pI, T10 j)
		=> (a, b, c, e, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, P pF, T7 g, P pH, T9 i)
		=> (a, b, c, e, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, P pF, T7 g, P pH, T9 i, T10 j)
		=> (a, b, c, e, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, P pF, T7 g, T8 h)
		=> (a, b, c, e, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, P pF, T7 g, T8 h, P pI, T10 j)
		=> (a, b, c, e, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, P pF, T7 g, T8 h, T9 i)
		=> (a, b, c, e, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (a, b, c, e, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f)
		=> (a, b, c, e, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f, P pG, P pH, P pI, T10 j)
		=> (a, b, c, e, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f, P pG, P pH, T9 i)
		=> (a, b, c, e, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f, P pG, P pH, T9 i, T10 j)
		=> (a, b, c, e, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f, P pG, T8 h)
		=> (a, b, c, e, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f, P pG, T8 h, P pI, T10 j)
		=> (a, b, c, e, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f, P pG, T8 h, T9 i)
		=> (a, b, c, e, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (a, b, c, e, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f, T7 g)
		=> (a, b, c, e, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f, T7 g, P pH, P pI, T10 j)
		=> (a, b, c, e, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f, T7 g, P pH, T9 i)
		=> (a, b, c, e, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (a, b, c, e, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f, T7 g, T8 h)
		=> (a, b, c, e, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (a, b, c, e, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (a, b, c, e, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, P pE, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (a, b, c, e) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e)
		=> (a, b, c, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, P pF, P pG, P pH, P pI, T10 j)
		=> (a, b, c, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, P pF, P pG, P pH, T9 i)
		=> (a, b, c, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, P pF, P pG, P pH, T9 i, T10 j)
		=> (a, b, c, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, P pF, P pG, T8 h)
		=> (a, b, c, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, P pF, P pG, T8 h, P pI, T10 j)
		=> (a, b, c, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, P pF, P pG, T8 h, T9 i)
		=> (a, b, c, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, P pF, P pG, T8 h, T9 i, T10 j)
		=> (a, b, c, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, P pF, T7 g)
		=> (a, b, c, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, P pF, T7 g, P pH, P pI, T10 j)
		=> (a, b, c, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, P pF, T7 g, P pH, T9 i)
		=> (a, b, c, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, P pF, T7 g, P pH, T9 i, T10 j)
		=> (a, b, c, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, P pF, T7 g, T8 h)
		=> (a, b, c, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, P pF, T7 g, T8 h, P pI, T10 j)
		=> (a, b, c, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (a, b, c, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (a, b, c, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f)
		=> (a, b, c, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f, P pG, P pH, P pI, T10 j)
		=> (a, b, c, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f, P pG, P pH, T9 i)
		=> (a, b, c, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f, P pG, P pH, T9 i, T10 j)
		=> (a, b, c, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f, P pG, T8 h)
		=> (a, b, c, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f, P pG, T8 h, P pI, T10 j)
		=> (a, b, c, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (a, b, c, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (a, b, c, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f, T7 g)
		=> (a, b, c, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f, T7 g, P pH, P pI, T10 j)
		=> (a, b, c, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (a, b, c, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (a, b, c, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f, T7 g, T8 h)
		=> (a, b, c, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (a, b, c, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (a, b, c, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T3, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, P pC, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (a, b, c) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c)
		=> (a, b, d, e, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, P pF, P pG, P pH, P pI, T10 j)
		=> (a, b, d, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, P pF, P pG, P pH, T9 i)
		=> (a, b, d, e, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, P pF, P pG, P pH, T9 i, T10 j)
		=> (a, b, d, e, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, P pF, P pG, T8 h)
		=> (a, b, d, e, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, P pF, P pG, T8 h, P pI, T10 j)
		=> (a, b, d, e, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, P pF, P pG, T8 h, T9 i)
		=> (a, b, d, e, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, P pF, P pG, T8 h, T9 i, T10 j)
		=> (a, b, d, e, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, P pF, T7 g)
		=> (a, b, d, e, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, P pF, T7 g, P pH, P pI, T10 j)
		=> (a, b, d, e, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, P pF, T7 g, P pH, T9 i)
		=> (a, b, d, e, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, P pF, T7 g, P pH, T9 i, T10 j)
		=> (a, b, d, e, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, P pF, T7 g, T8 h)
		=> (a, b, d, e, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, P pF, T7 g, T8 h, P pI, T10 j)
		=> (a, b, d, e, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, P pF, T7 g, T8 h, T9 i)
		=> (a, b, d, e, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (a, b, d, e, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f)
		=> (a, b, d, e, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f, P pG, P pH, P pI, T10 j)
		=> (a, b, d, e, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f, P pG, P pH, T9 i)
		=> (a, b, d, e, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f, P pG, P pH, T9 i, T10 j)
		=> (a, b, d, e, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f, P pG, T8 h)
		=> (a, b, d, e, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f, P pG, T8 h, P pI, T10 j)
		=> (a, b, d, e, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f, P pG, T8 h, T9 i)
		=> (a, b, d, e, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (a, b, d, e, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f, T7 g)
		=> (a, b, d, e, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f, T7 g, P pH, P pI, T10 j)
		=> (a, b, d, e, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f, T7 g, P pH, T9 i)
		=> (a, b, d, e, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (a, b, d, e, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f, T7 g, T8 h)
		=> (a, b, d, e, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (a, b, d, e, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (a, b, d, e, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, P pE, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (a, b, d, e) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e)
		=> (a, b, d, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, P pF, P pG, P pH, P pI, T10 j)
		=> (a, b, d, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, P pF, P pG, P pH, T9 i)
		=> (a, b, d, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, P pF, P pG, P pH, T9 i, T10 j)
		=> (a, b, d, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, P pF, P pG, T8 h)
		=> (a, b, d, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, P pF, P pG, T8 h, P pI, T10 j)
		=> (a, b, d, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, P pF, P pG, T8 h, T9 i)
		=> (a, b, d, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, P pF, P pG, T8 h, T9 i, T10 j)
		=> (a, b, d, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, P pF, T7 g)
		=> (a, b, d, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, P pF, T7 g, P pH, P pI, T10 j)
		=> (a, b, d, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, P pF, T7 g, P pH, T9 i)
		=> (a, b, d, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, P pF, T7 g, P pH, T9 i, T10 j)
		=> (a, b, d, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, P pF, T7 g, T8 h)
		=> (a, b, d, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, P pF, T7 g, T8 h, P pI, T10 j)
		=> (a, b, d, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (a, b, d, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (a, b, d, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f)
		=> (a, b, d, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f, P pG, P pH, P pI, T10 j)
		=> (a, b, d, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f, P pG, P pH, T9 i)
		=> (a, b, d, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f, P pG, P pH, T9 i, T10 j)
		=> (a, b, d, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f, P pG, T8 h)
		=> (a, b, d, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f, P pG, T8 h, P pI, T10 j)
		=> (a, b, d, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (a, b, d, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (a, b, d, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f, T7 g)
		=> (a, b, d, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f, T7 g, P pH, P pI, T10 j)
		=> (a, b, d, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (a, b, d, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (a, b, d, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f, T7 g, T8 h)
		=> (a, b, d, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (a, b, d, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (a, b, d, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, P pD, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (a, b, d) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d)
		=> (a, b, e, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, P pF, P pG, P pH, P pI, T10 j)
		=> (a, b, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, P pF, P pG, P pH, T9 i)
		=> (a, b, e, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, P pF, P pG, P pH, T9 i, T10 j)
		=> (a, b, e, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, P pF, P pG, T8 h)
		=> (a, b, e, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, P pF, P pG, T8 h, P pI, T10 j)
		=> (a, b, e, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, P pF, P pG, T8 h, T9 i)
		=> (a, b, e, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, P pF, P pG, T8 h, T9 i, T10 j)
		=> (a, b, e, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, P pF, T7 g)
		=> (a, b, e, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, P pF, T7 g, P pH, P pI, T10 j)
		=> (a, b, e, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, P pF, T7 g, P pH, T9 i)
		=> (a, b, e, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, P pF, T7 g, P pH, T9 i, T10 j)
		=> (a, b, e, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, P pF, T7 g, T8 h)
		=> (a, b, e, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, P pF, T7 g, T8 h, P pI, T10 j)
		=> (a, b, e, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, P pF, T7 g, T8 h, T9 i)
		=> (a, b, e, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (a, b, e, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f)
		=> (a, b, e, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f, P pG, P pH, P pI, T10 j)
		=> (a, b, e, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f, P pG, P pH, T9 i)
		=> (a, b, e, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f, P pG, P pH, T9 i, T10 j)
		=> (a, b, e, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f, P pG, T8 h)
		=> (a, b, e, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f, P pG, T8 h, P pI, T10 j)
		=> (a, b, e, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f, P pG, T8 h, T9 i)
		=> (a, b, e, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (a, b, e, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f, T7 g)
		=> (a, b, e, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f, T7 g, P pH, P pI, T10 j)
		=> (a, b, e, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f, T7 g, P pH, T9 i)
		=> (a, b, e, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (a, b, e, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f, T7 g, T8 h)
		=> (a, b, e, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (a, b, e, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (a, b, e, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, P pE, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (a, b, e) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e)
		=> (a, b, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, P pF, P pG, P pH, P pI, T10 j)
		=> (a, b, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, P pF, P pG, P pH, T9 i)
		=> (a, b, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, P pF, P pG, P pH, T9 i, T10 j)
		=> (a, b, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, P pF, P pG, T8 h)
		=> (a, b, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, P pF, P pG, T8 h, P pI, T10 j)
		=> (a, b, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, P pF, P pG, T8 h, T9 i)
		=> (a, b, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, P pF, P pG, T8 h, T9 i, T10 j)
		=> (a, b, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, P pF, T7 g)
		=> (a, b, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, P pF, T7 g, P pH, P pI, T10 j)
		=> (a, b, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, P pF, T7 g, P pH, T9 i)
		=> (a, b, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, P pF, T7 g, P pH, T9 i, T10 j)
		=> (a, b, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, P pF, T7 g, T8 h)
		=> (a, b, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, P pF, T7 g, T8 h, P pI, T10 j)
		=> (a, b, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (a, b, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (a, b, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f)
		=> (a, b, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f, P pG, P pH, P pI, T10 j)
		=> (a, b, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f, P pG, P pH, T9 i)
		=> (a, b, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f, P pG, P pH, T9 i, T10 j)
		=> (a, b, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f, P pG, T8 h)
		=> (a, b, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f, P pG, T8 h, P pI, T10 j)
		=> (a, b, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (a, b, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (a, b, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f, T7 g)
		=> (a, b, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f, T7 g, P pH, P pI, T10 j)
		=> (a, b, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (a, b, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (a, b, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		=> (a, b, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (a, b, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (a, b, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T2, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, P pB, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (a, b) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b)
		=> (a, c, d, e, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, P pF, P pG, P pH, P pI, T10 j)
		=> (a, c, d, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, P pF, P pG, P pH, T9 i)
		=> (a, c, d, e, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, P pF, P pG, P pH, T9 i, T10 j)
		=> (a, c, d, e, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, P pF, P pG, T8 h)
		=> (a, c, d, e, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, P pF, P pG, T8 h, P pI, T10 j)
		=> (a, c, d, e, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, P pF, P pG, T8 h, T9 i)
		=> (a, c, d, e, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, P pF, P pG, T8 h, T9 i, T10 j)
		=> (a, c, d, e, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, P pF, T7 g)
		=> (a, c, d, e, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, P pF, T7 g, P pH, P pI, T10 j)
		=> (a, c, d, e, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, P pF, T7 g, P pH, T9 i)
		=> (a, c, d, e, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, P pF, T7 g, P pH, T9 i, T10 j)
		=> (a, c, d, e, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, P pF, T7 g, T8 h)
		=> (a, c, d, e, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, P pF, T7 g, T8 h, P pI, T10 j)
		=> (a, c, d, e, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, P pF, T7 g, T8 h, T9 i)
		=> (a, c, d, e, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (a, c, d, e, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f)
		=> (a, c, d, e, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f, P pG, P pH, P pI, T10 j)
		=> (a, c, d, e, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f, P pG, P pH, T9 i)
		=> (a, c, d, e, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f, P pG, P pH, T9 i, T10 j)
		=> (a, c, d, e, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f, P pG, T8 h)
		=> (a, c, d, e, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f, P pG, T8 h, P pI, T10 j)
		=> (a, c, d, e, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f, P pG, T8 h, T9 i)
		=> (a, c, d, e, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (a, c, d, e, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f, T7 g)
		=> (a, c, d, e, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f, T7 g, P pH, P pI, T10 j)
		=> (a, c, d, e, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f, T7 g, P pH, T9 i)
		=> (a, c, d, e, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (a, c, d, e, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f, T7 g, T8 h)
		=> (a, c, d, e, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (a, c, d, e, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (a, c, d, e, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, P pE, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (a, c, d, e) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e)
		=> (a, c, d, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, P pF, P pG, P pH, P pI, T10 j)
		=> (a, c, d, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, P pF, P pG, P pH, T9 i)
		=> (a, c, d, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, P pF, P pG, P pH, T9 i, T10 j)
		=> (a, c, d, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, P pF, P pG, T8 h)
		=> (a, c, d, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, P pF, P pG, T8 h, P pI, T10 j)
		=> (a, c, d, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, P pF, P pG, T8 h, T9 i)
		=> (a, c, d, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, P pF, P pG, T8 h, T9 i, T10 j)
		=> (a, c, d, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, P pF, T7 g)
		=> (a, c, d, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, P pF, T7 g, P pH, P pI, T10 j)
		=> (a, c, d, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, P pF, T7 g, P pH, T9 i)
		=> (a, c, d, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, P pF, T7 g, P pH, T9 i, T10 j)
		=> (a, c, d, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, P pF, T7 g, T8 h)
		=> (a, c, d, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, P pF, T7 g, T8 h, P pI, T10 j)
		=> (a, c, d, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (a, c, d, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (a, c, d, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f)
		=> (a, c, d, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f, P pG, P pH, P pI, T10 j)
		=> (a, c, d, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f, P pG, P pH, T9 i)
		=> (a, c, d, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f, P pG, P pH, T9 i, T10 j)
		=> (a, c, d, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f, P pG, T8 h)
		=> (a, c, d, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f, P pG, T8 h, P pI, T10 j)
		=> (a, c, d, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (a, c, d, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (a, c, d, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f, T7 g)
		=> (a, c, d, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f, T7 g, P pH, P pI, T10 j)
		=> (a, c, d, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (a, c, d, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (a, c, d, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f, T7 g, T8 h)
		=> (a, c, d, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (a, c, d, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (a, c, d, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, P pD, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (a, c, d) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d)
		=> (a, c, e, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, P pF, P pG, P pH, P pI, T10 j)
		=> (a, c, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, P pF, P pG, P pH, T9 i)
		=> (a, c, e, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, P pF, P pG, P pH, T9 i, T10 j)
		=> (a, c, e, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, P pF, P pG, T8 h)
		=> (a, c, e, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, P pF, P pG, T8 h, P pI, T10 j)
		=> (a, c, e, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, P pF, P pG, T8 h, T9 i)
		=> (a, c, e, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, P pF, P pG, T8 h, T9 i, T10 j)
		=> (a, c, e, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, P pF, T7 g)
		=> (a, c, e, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, P pF, T7 g, P pH, P pI, T10 j)
		=> (a, c, e, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, P pF, T7 g, P pH, T9 i)
		=> (a, c, e, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, P pF, T7 g, P pH, T9 i, T10 j)
		=> (a, c, e, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, P pF, T7 g, T8 h)
		=> (a, c, e, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, P pF, T7 g, T8 h, P pI, T10 j)
		=> (a, c, e, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, P pF, T7 g, T8 h, T9 i)
		=> (a, c, e, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (a, c, e, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f)
		=> (a, c, e, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f, P pG, P pH, P pI, T10 j)
		=> (a, c, e, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f, P pG, P pH, T9 i)
		=> (a, c, e, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f, P pG, P pH, T9 i, T10 j)
		=> (a, c, e, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f, P pG, T8 h)
		=> (a, c, e, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f, P pG, T8 h, P pI, T10 j)
		=> (a, c, e, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f, P pG, T8 h, T9 i)
		=> (a, c, e, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (a, c, e, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f, T7 g)
		=> (a, c, e, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f, T7 g, P pH, P pI, T10 j)
		=> (a, c, e, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f, T7 g, P pH, T9 i)
		=> (a, c, e, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (a, c, e, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f, T7 g, T8 h)
		=> (a, c, e, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (a, c, e, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (a, c, e, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, P pE, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (a, c, e) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e)
		=> (a, c, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, P pF, P pG, P pH, P pI, T10 j)
		=> (a, c, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, P pF, P pG, P pH, T9 i)
		=> (a, c, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, P pF, P pG, P pH, T9 i, T10 j)
		=> (a, c, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, P pF, P pG, T8 h)
		=> (a, c, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, P pF, P pG, T8 h, P pI, T10 j)
		=> (a, c, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, P pF, P pG, T8 h, T9 i)
		=> (a, c, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, P pF, P pG, T8 h, T9 i, T10 j)
		=> (a, c, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, P pF, T7 g)
		=> (a, c, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, P pF, T7 g, P pH, P pI, T10 j)
		=> (a, c, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, P pF, T7 g, P pH, T9 i)
		=> (a, c, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, P pF, T7 g, P pH, T9 i, T10 j)
		=> (a, c, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, P pF, T7 g, T8 h)
		=> (a, c, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, P pF, T7 g, T8 h, P pI, T10 j)
		=> (a, c, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (a, c, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (a, c, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f)
		=> (a, c, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f, P pG, P pH, P pI, T10 j)
		=> (a, c, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f, P pG, P pH, T9 i)
		=> (a, c, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f, P pG, P pH, T9 i, T10 j)
		=> (a, c, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f, P pG, T8 h)
		=> (a, c, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f, P pG, T8 h, P pI, T10 j)
		=> (a, c, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (a, c, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (a, c, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f, T7 g)
		=> (a, c, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f, T7 g, P pH, P pI, T10 j)
		=> (a, c, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (a, c, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (a, c, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f, T7 g, T8 h)
		=> (a, c, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (a, c, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (a, c, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T3, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, P pC, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (a, c) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c)
		=> (a, d, e, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, P pF, P pG, P pH, P pI, T10 j)
		=> (a, d, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, P pF, P pG, P pH, T9 i)
		=> (a, d, e, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, P pF, P pG, P pH, T9 i, T10 j)
		=> (a, d, e, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, P pF, P pG, T8 h)
		=> (a, d, e, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, P pF, P pG, T8 h, P pI, T10 j)
		=> (a, d, e, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, P pF, P pG, T8 h, T9 i)
		=> (a, d, e, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, P pF, P pG, T8 h, T9 i, T10 j)
		=> (a, d, e, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, P pF, T7 g)
		=> (a, d, e, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, P pF, T7 g, P pH, P pI, T10 j)
		=> (a, d, e, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, P pF, T7 g, P pH, T9 i)
		=> (a, d, e, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, P pF, T7 g, P pH, T9 i, T10 j)
		=> (a, d, e, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, P pF, T7 g, T8 h)
		=> (a, d, e, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, P pF, T7 g, T8 h, P pI, T10 j)
		=> (a, d, e, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, P pF, T7 g, T8 h, T9 i)
		=> (a, d, e, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (a, d, e, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f)
		=> (a, d, e, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f, P pG, P pH, P pI, T10 j)
		=> (a, d, e, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f, P pG, P pH, T9 i)
		=> (a, d, e, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f, P pG, P pH, T9 i, T10 j)
		=> (a, d, e, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f, P pG, T8 h)
		=> (a, d, e, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f, P pG, T8 h, P pI, T10 j)
		=> (a, d, e, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f, P pG, T8 h, T9 i)
		=> (a, d, e, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (a, d, e, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f, T7 g)
		=> (a, d, e, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f, T7 g, P pH, P pI, T10 j)
		=> (a, d, e, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f, T7 g, P pH, T9 i)
		=> (a, d, e, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (a, d, e, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f, T7 g, T8 h)
		=> (a, d, e, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (a, d, e, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (a, d, e, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, P pE, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (a, d, e) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e)
		=> (a, d, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, P pF, P pG, P pH, P pI, T10 j)
		=> (a, d, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, P pF, P pG, P pH, T9 i)
		=> (a, d, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, P pF, P pG, P pH, T9 i, T10 j)
		=> (a, d, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, P pF, P pG, T8 h)
		=> (a, d, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, P pF, P pG, T8 h, P pI, T10 j)
		=> (a, d, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, P pF, P pG, T8 h, T9 i)
		=> (a, d, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, P pF, P pG, T8 h, T9 i, T10 j)
		=> (a, d, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, P pF, T7 g)
		=> (a, d, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, P pF, T7 g, P pH, P pI, T10 j)
		=> (a, d, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, P pF, T7 g, P pH, T9 i)
		=> (a, d, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, P pF, T7 g, P pH, T9 i, T10 j)
		=> (a, d, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, P pF, T7 g, T8 h)
		=> (a, d, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, P pF, T7 g, T8 h, P pI, T10 j)
		=> (a, d, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (a, d, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (a, d, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f)
		=> (a, d, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f, P pG, P pH, P pI, T10 j)
		=> (a, d, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f, P pG, P pH, T9 i)
		=> (a, d, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f, P pG, P pH, T9 i, T10 j)
		=> (a, d, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f, P pG, T8 h)
		=> (a, d, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f, P pG, T8 h, P pI, T10 j)
		=> (a, d, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (a, d, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (a, d, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f, T7 g)
		=> (a, d, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f, T7 g, P pH, P pI, T10 j)
		=> (a, d, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (a, d, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (a, d, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f, T7 g, T8 h)
		=> (a, d, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (a, d, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (a, d, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, P pD, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (a, d) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d)
		=> (a, e, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, P pF, P pG, P pH, P pI, T10 j)
		=> (a, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, P pF, P pG, P pH, T9 i)
		=> (a, e, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, P pF, P pG, P pH, T9 i, T10 j)
		=> (a, e, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, P pF, P pG, T8 h)
		=> (a, e, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, P pF, P pG, T8 h, P pI, T10 j)
		=> (a, e, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, P pF, P pG, T8 h, T9 i)
		=> (a, e, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, P pF, P pG, T8 h, T9 i, T10 j)
		=> (a, e, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, P pF, T7 g)
		=> (a, e, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, P pF, T7 g, P pH, P pI, T10 j)
		=> (a, e, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, P pF, T7 g, P pH, T9 i)
		=> (a, e, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, P pF, T7 g, P pH, T9 i, T10 j)
		=> (a, e, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, P pF, T7 g, T8 h)
		=> (a, e, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, P pF, T7 g, T8 h, P pI, T10 j)
		=> (a, e, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, P pF, T7 g, T8 h, T9 i)
		=> (a, e, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (a, e, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f)
		=> (a, e, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f, P pG, P pH, P pI, T10 j)
		=> (a, e, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f, P pG, P pH, T9 i)
		=> (a, e, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f, P pG, P pH, T9 i, T10 j)
		=> (a, e, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f, P pG, T8 h)
		=> (a, e, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f, P pG, T8 h, P pI, T10 j)
		=> (a, e, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f, P pG, T8 h, T9 i)
		=> (a, e, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (a, e, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f, T7 g)
		=> (a, e, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f, T7 g, P pH, P pI, T10 j)
		=> (a, e, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f, T7 g, P pH, T9 i)
		=> (a, e, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (a, e, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f, T7 g, T8 h)
		=> (a, e, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (a, e, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (a, e, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, P pE, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (a, e) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e)
		=> (a, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, P pF, P pG, P pH, P pI, T10 j)
		=> (a, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, P pF, P pG, P pH, T9 i)
		=> (a, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, P pF, P pG, P pH, T9 i, T10 j)
		=> (a, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, P pF, P pG, T8 h)
		=> (a, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, P pF, P pG, T8 h, P pI, T10 j)
		=> (a, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, P pF, P pG, T8 h, T9 i)
		=> (a, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, P pF, P pG, T8 h, T9 i, T10 j)
		=> (a, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, P pF, T7 g)
		=> (a, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, P pF, T7 g, P pH, P pI, T10 j)
		=> (a, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, P pF, T7 g, P pH, T9 i)
		=> (a, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, P pF, T7 g, P pH, T9 i, T10 j)
		=> (a, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, P pF, T7 g, T8 h)
		=> (a, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, P pF, T7 g, T8 h, P pI, T10 j)
		=> (a, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (a, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (a, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f)
		=> (a, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f, P pG, P pH, P pI, T10 j)
		=> (a, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f, P pG, P pH, T9 i)
		=> (a, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f, P pG, P pH, T9 i, T10 j)
		=> (a, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f, P pG, T8 h)
		=> (a, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f, P pG, T8 h, P pI, T10 j)
		=> (a, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (a, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (a, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
		=> (a, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, P pH, P pI, T10 j)
		=> (a, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (a, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (a, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		=> (a, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (a, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (a, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T1, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				P pA, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (a) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a)
		=> (b, c, d, e, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, P pF, P pG, P pH, P pI, T10 j)
		=> (b, c, d, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, P pF, P pG, P pH, T9 i)
		=> (b, c, d, e, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, P pF, P pG, P pH, T9 i, T10 j)
		=> (b, c, d, e, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, P pF, P pG, T8 h)
		=> (b, c, d, e, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, P pF, P pG, T8 h, P pI, T10 j)
		=> (b, c, d, e, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, P pF, P pG, T8 h, T9 i)
		=> (b, c, d, e, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, P pF, P pG, T8 h, T9 i, T10 j)
		=> (b, c, d, e, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, P pF, T7 g)
		=> (b, c, d, e, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, P pF, T7 g, P pH, P pI, T10 j)
		=> (b, c, d, e, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, P pF, T7 g, P pH, T9 i)
		=> (b, c, d, e, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, P pF, T7 g, P pH, T9 i, T10 j)
		=> (b, c, d, e, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, P pF, T7 g, T8 h)
		=> (b, c, d, e, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, P pF, T7 g, T8 h, P pI, T10 j)
		=> (b, c, d, e, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, P pF, T7 g, T8 h, T9 i)
		=> (b, c, d, e, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (b, c, d, e, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f)
		=> (b, c, d, e, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f, P pG, P pH, P pI, T10 j)
		=> (b, c, d, e, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f, P pG, P pH, T9 i)
		=> (b, c, d, e, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f, P pG, P pH, T9 i, T10 j)
		=> (b, c, d, e, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f, P pG, T8 h)
		=> (b, c, d, e, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f, P pG, T8 h, P pI, T10 j)
		=> (b, c, d, e, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f, P pG, T8 h, T9 i)
		=> (b, c, d, e, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (b, c, d, e, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f, T7 g)
		=> (b, c, d, e, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f, T7 g, P pH, P pI, T10 j)
		=> (b, c, d, e, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f, T7 g, P pH, T9 i)
		=> (b, c, d, e, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (b, c, d, e, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f, T7 g, T8 h)
		=> (b, c, d, e, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (b, c, d, e, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (b, c, d, e, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, P pE, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (b, c, d, e) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e)
		=> (b, c, d, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, P pF, P pG, P pH, P pI, T10 j)
		=> (b, c, d, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, P pF, P pG, P pH, T9 i)
		=> (b, c, d, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, P pF, P pG, P pH, T9 i, T10 j)
		=> (b, c, d, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, P pF, P pG, T8 h)
		=> (b, c, d, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, P pF, P pG, T8 h, P pI, T10 j)
		=> (b, c, d, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, P pF, P pG, T8 h, T9 i)
		=> (b, c, d, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, P pF, P pG, T8 h, T9 i, T10 j)
		=> (b, c, d, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, P pF, T7 g)
		=> (b, c, d, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, P pF, T7 g, P pH, P pI, T10 j)
		=> (b, c, d, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, P pF, T7 g, P pH, T9 i)
		=> (b, c, d, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, P pF, T7 g, P pH, T9 i, T10 j)
		=> (b, c, d, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, P pF, T7 g, T8 h)
		=> (b, c, d, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, P pF, T7 g, T8 h, P pI, T10 j)
		=> (b, c, d, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (b, c, d, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (b, c, d, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f)
		=> (b, c, d, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f, P pG, P pH, P pI, T10 j)
		=> (b, c, d, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f, P pG, P pH, T9 i)
		=> (b, c, d, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f, P pG, P pH, T9 i, T10 j)
		=> (b, c, d, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f, P pG, T8 h)
		=> (b, c, d, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f, P pG, T8 h, P pI, T10 j)
		=> (b, c, d, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (b, c, d, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (b, c, d, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f, T7 g)
		=> (b, c, d, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f, T7 g, P pH, P pI, T10 j)
		=> (b, c, d, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (b, c, d, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (b, c, d, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f, T7 g, T8 h)
		=> (b, c, d, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (b, c, d, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (b, c, d, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, P pD, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (b, c, d) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d)
		=> (b, c, e, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, P pF, P pG, P pH, P pI, T10 j)
		=> (b, c, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, P pF, P pG, P pH, T9 i)
		=> (b, c, e, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, P pF, P pG, P pH, T9 i, T10 j)
		=> (b, c, e, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, P pF, P pG, T8 h)
		=> (b, c, e, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, P pF, P pG, T8 h, P pI, T10 j)
		=> (b, c, e, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, P pF, P pG, T8 h, T9 i)
		=> (b, c, e, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, P pF, P pG, T8 h, T9 i, T10 j)
		=> (b, c, e, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, P pF, T7 g)
		=> (b, c, e, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, P pF, T7 g, P pH, P pI, T10 j)
		=> (b, c, e, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, P pF, T7 g, P pH, T9 i)
		=> (b, c, e, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, P pF, T7 g, P pH, T9 i, T10 j)
		=> (b, c, e, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, P pF, T7 g, T8 h)
		=> (b, c, e, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, P pF, T7 g, T8 h, P pI, T10 j)
		=> (b, c, e, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, P pF, T7 g, T8 h, T9 i)
		=> (b, c, e, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (b, c, e, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f)
		=> (b, c, e, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f, P pG, P pH, P pI, T10 j)
		=> (b, c, e, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f, P pG, P pH, T9 i)
		=> (b, c, e, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f, P pG, P pH, T9 i, T10 j)
		=> (b, c, e, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f, P pG, T8 h)
		=> (b, c, e, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f, P pG, T8 h, P pI, T10 j)
		=> (b, c, e, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f, P pG, T8 h, T9 i)
		=> (b, c, e, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (b, c, e, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f, T7 g)
		=> (b, c, e, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f, T7 g, P pH, P pI, T10 j)
		=> (b, c, e, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f, T7 g, P pH, T9 i)
		=> (b, c, e, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (b, c, e, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f, T7 g, T8 h)
		=> (b, c, e, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (b, c, e, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (b, c, e, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, P pE, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (b, c, e) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e)
		=> (b, c, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, P pF, P pG, P pH, P pI, T10 j)
		=> (b, c, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, P pF, P pG, P pH, T9 i)
		=> (b, c, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, P pF, P pG, P pH, T9 i, T10 j)
		=> (b, c, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, P pF, P pG, T8 h)
		=> (b, c, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, P pF, P pG, T8 h, P pI, T10 j)
		=> (b, c, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, P pF, P pG, T8 h, T9 i)
		=> (b, c, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, P pF, P pG, T8 h, T9 i, T10 j)
		=> (b, c, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, P pF, T7 g)
		=> (b, c, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, P pF, T7 g, P pH, P pI, T10 j)
		=> (b, c, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, P pF, T7 g, P pH, T9 i)
		=> (b, c, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, P pF, T7 g, P pH, T9 i, T10 j)
		=> (b, c, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, P pF, T7 g, T8 h)
		=> (b, c, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, P pF, T7 g, T8 h, P pI, T10 j)
		=> (b, c, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (b, c, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (b, c, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f)
		=> (b, c, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f, P pG, P pH, P pI, T10 j)
		=> (b, c, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f, P pG, P pH, T9 i)
		=> (b, c, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f, P pG, P pH, T9 i, T10 j)
		=> (b, c, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f, P pG, T8 h)
		=> (b, c, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f, P pG, T8 h, P pI, T10 j)
		=> (b, c, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (b, c, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (b, c, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f, T7 g)
		=> (b, c, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f, T7 g, P pH, P pI, T10 j)
		=> (b, c, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (b, c, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (b, c, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f, T7 g, T8 h)
		=> (b, c, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (b, c, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (b, c, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T3, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, P pC, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (b, c) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c)
		=> (b, d, e, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, P pF, P pG, P pH, P pI, T10 j)
		=> (b, d, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, P pF, P pG, P pH, T9 i)
		=> (b, d, e, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, P pF, P pG, P pH, T9 i, T10 j)
		=> (b, d, e, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, P pF, P pG, T8 h)
		=> (b, d, e, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, P pF, P pG, T8 h, P pI, T10 j)
		=> (b, d, e, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, P pF, P pG, T8 h, T9 i)
		=> (b, d, e, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, P pF, P pG, T8 h, T9 i, T10 j)
		=> (b, d, e, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, P pF, T7 g)
		=> (b, d, e, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, P pF, T7 g, P pH, P pI, T10 j)
		=> (b, d, e, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, P pF, T7 g, P pH, T9 i)
		=> (b, d, e, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, P pF, T7 g, P pH, T9 i, T10 j)
		=> (b, d, e, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, P pF, T7 g, T8 h)
		=> (b, d, e, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, P pF, T7 g, T8 h, P pI, T10 j)
		=> (b, d, e, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, P pF, T7 g, T8 h, T9 i)
		=> (b, d, e, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (b, d, e, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f)
		=> (b, d, e, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f, P pG, P pH, P pI, T10 j)
		=> (b, d, e, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f, P pG, P pH, T9 i)
		=> (b, d, e, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f, P pG, P pH, T9 i, T10 j)
		=> (b, d, e, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f, P pG, T8 h)
		=> (b, d, e, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f, P pG, T8 h, P pI, T10 j)
		=> (b, d, e, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f, P pG, T8 h, T9 i)
		=> (b, d, e, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (b, d, e, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f, T7 g)
		=> (b, d, e, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f, T7 g, P pH, P pI, T10 j)
		=> (b, d, e, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f, T7 g, P pH, T9 i)
		=> (b, d, e, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (b, d, e, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f, T7 g, T8 h)
		=> (b, d, e, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (b, d, e, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (b, d, e, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, P pE, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (b, d, e) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e)
		=> (b, d, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, P pF, P pG, P pH, P pI, T10 j)
		=> (b, d, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, P pF, P pG, P pH, T9 i)
		=> (b, d, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, P pF, P pG, P pH, T9 i, T10 j)
		=> (b, d, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, P pF, P pG, T8 h)
		=> (b, d, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, P pF, P pG, T8 h, P pI, T10 j)
		=> (b, d, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, P pF, P pG, T8 h, T9 i)
		=> (b, d, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, P pF, P pG, T8 h, T9 i, T10 j)
		=> (b, d, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, P pF, T7 g)
		=> (b, d, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, P pF, T7 g, P pH, P pI, T10 j)
		=> (b, d, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, P pF, T7 g, P pH, T9 i)
		=> (b, d, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, P pF, T7 g, P pH, T9 i, T10 j)
		=> (b, d, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, P pF, T7 g, T8 h)
		=> (b, d, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, P pF, T7 g, T8 h, P pI, T10 j)
		=> (b, d, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (b, d, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (b, d, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f)
		=> (b, d, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f, P pG, P pH, P pI, T10 j)
		=> (b, d, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f, P pG, P pH, T9 i)
		=> (b, d, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f, P pG, P pH, T9 i, T10 j)
		=> (b, d, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f, P pG, T8 h)
		=> (b, d, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f, P pG, T8 h, P pI, T10 j)
		=> (b, d, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (b, d, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (b, d, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f, T7 g)
		=> (b, d, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f, T7 g, P pH, P pI, T10 j)
		=> (b, d, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (b, d, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (b, d, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f, T7 g, T8 h)
		=> (b, d, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (b, d, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (b, d, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, P pD, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (b, d) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d)
		=> (b, e, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, P pF, P pG, P pH, P pI, T10 j)
		=> (b, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, P pF, P pG, P pH, T9 i)
		=> (b, e, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, P pF, P pG, P pH, T9 i, T10 j)
		=> (b, e, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, P pF, P pG, T8 h)
		=> (b, e, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, P pF, P pG, T8 h, P pI, T10 j)
		=> (b, e, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, P pF, P pG, T8 h, T9 i)
		=> (b, e, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, P pF, P pG, T8 h, T9 i, T10 j)
		=> (b, e, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, P pF, T7 g)
		=> (b, e, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, P pF, T7 g, P pH, P pI, T10 j)
		=> (b, e, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, P pF, T7 g, P pH, T9 i)
		=> (b, e, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, P pF, T7 g, P pH, T9 i, T10 j)
		=> (b, e, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, P pF, T7 g, T8 h)
		=> (b, e, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, P pF, T7 g, T8 h, P pI, T10 j)
		=> (b, e, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, P pF, T7 g, T8 h, T9 i)
		=> (b, e, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (b, e, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f)
		=> (b, e, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f, P pG, P pH, P pI, T10 j)
		=> (b, e, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f, P pG, P pH, T9 i)
		=> (b, e, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f, P pG, P pH, T9 i, T10 j)
		=> (b, e, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f, P pG, T8 h)
		=> (b, e, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f, P pG, T8 h, P pI, T10 j)
		=> (b, e, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f, P pG, T8 h, T9 i)
		=> (b, e, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (b, e, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f, T7 g)
		=> (b, e, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f, T7 g, P pH, P pI, T10 j)
		=> (b, e, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f, T7 g, P pH, T9 i)
		=> (b, e, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (b, e, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f, T7 g, T8 h)
		=> (b, e, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (b, e, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (b, e, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, P pE, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (b, e) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e)
		=> (b, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, P pF, P pG, P pH, P pI, T10 j)
		=> (b, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, P pF, P pG, P pH, T9 i)
		=> (b, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, P pF, P pG, P pH, T9 i, T10 j)
		=> (b, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, P pF, P pG, T8 h)
		=> (b, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, P pF, P pG, T8 h, P pI, T10 j)
		=> (b, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, P pF, P pG, T8 h, T9 i)
		=> (b, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, P pF, P pG, T8 h, T9 i, T10 j)
		=> (b, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, P pF, T7 g)
		=> (b, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, P pF, T7 g, P pH, P pI, T10 j)
		=> (b, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, P pF, T7 g, P pH, T9 i)
		=> (b, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, P pF, T7 g, P pH, T9 i, T10 j)
		=> (b, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, P pF, T7 g, T8 h)
		=> (b, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, P pF, T7 g, T8 h, P pI, T10 j)
		=> (b, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (b, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (b, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f)
		=> (b, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f, P pG, P pH, P pI, T10 j)
		=> (b, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f, P pG, P pH, T9 i)
		=> (b, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f, P pG, P pH, T9 i, T10 j)
		=> (b, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f, P pG, T8 h)
		=> (b, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f, P pG, T8 h, P pI, T10 j)
		=> (b, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (b, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (b, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f, T7 g)
		=> (b, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f, T7 g, P pH, P pI, T10 j)
		=> (b, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (b, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (b, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		=> (b, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (b, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (b, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T2, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, P pB, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (b) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b)
		=> (c, d, e, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, P pF, P pG, P pH, P pI, T10 j)
		=> (c, d, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, P pF, P pG, P pH, T9 i)
		=> (c, d, e, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, P pF, P pG, P pH, T9 i, T10 j)
		=> (c, d, e, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, P pF, P pG, T8 h)
		=> (c, d, e, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, P pF, P pG, T8 h, P pI, T10 j)
		=> (c, d, e, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, P pF, P pG, T8 h, T9 i)
		=> (c, d, e, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, P pF, P pG, T8 h, T9 i, T10 j)
		=> (c, d, e, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, P pF, T7 g)
		=> (c, d, e, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, P pF, T7 g, P pH, P pI, T10 j)
		=> (c, d, e, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, P pF, T7 g, P pH, T9 i)
		=> (c, d, e, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, P pF, T7 g, P pH, T9 i, T10 j)
		=> (c, d, e, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, P pF, T7 g, T8 h)
		=> (c, d, e, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, P pF, T7 g, T8 h, P pI, T10 j)
		=> (c, d, e, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, P pF, T7 g, T8 h, T9 i)
		=> (c, d, e, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (c, d, e, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f)
		=> (c, d, e, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f, P pG, P pH, P pI, T10 j)
		=> (c, d, e, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f, P pG, P pH, T9 i)
		=> (c, d, e, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f, P pG, P pH, T9 i, T10 j)
		=> (c, d, e, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f, P pG, T8 h)
		=> (c, d, e, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f, P pG, T8 h, P pI, T10 j)
		=> (c, d, e, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f, P pG, T8 h, T9 i)
		=> (c, d, e, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (c, d, e, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f, T7 g)
		=> (c, d, e, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f, T7 g, P pH, P pI, T10 j)
		=> (c, d, e, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f, T7 g, P pH, T9 i)
		=> (c, d, e, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (c, d, e, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f, T7 g, T8 h)
		=> (c, d, e, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (c, d, e, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (c, d, e, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, P pE, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (c, d, e) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e)
		=> (c, d, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, P pF, P pG, P pH, P pI, T10 j)
		=> (c, d, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, P pF, P pG, P pH, T9 i)
		=> (c, d, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, P pF, P pG, P pH, T9 i, T10 j)
		=> (c, d, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, P pF, P pG, T8 h)
		=> (c, d, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, P pF, P pG, T8 h, P pI, T10 j)
		=> (c, d, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, P pF, P pG, T8 h, T9 i)
		=> (c, d, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, P pF, P pG, T8 h, T9 i, T10 j)
		=> (c, d, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, P pF, T7 g)
		=> (c, d, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, P pF, T7 g, P pH, P pI, T10 j)
		=> (c, d, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, P pF, T7 g, P pH, T9 i)
		=> (c, d, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, P pF, T7 g, P pH, T9 i, T10 j)
		=> (c, d, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, P pF, T7 g, T8 h)
		=> (c, d, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, P pF, T7 g, T8 h, P pI, T10 j)
		=> (c, d, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (c, d, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (c, d, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f)
		=> (c, d, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f, P pG, P pH, P pI, T10 j)
		=> (c, d, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f, P pG, P pH, T9 i)
		=> (c, d, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f, P pG, P pH, T9 i, T10 j)
		=> (c, d, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f, P pG, T8 h)
		=> (c, d, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f, P pG, T8 h, P pI, T10 j)
		=> (c, d, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (c, d, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (c, d, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f, T7 g)
		=> (c, d, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f, T7 g, P pH, P pI, T10 j)
		=> (c, d, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (c, d, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (c, d, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f, T7 g, T8 h)
		=> (c, d, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (c, d, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (c, d, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, P pD, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (c, d) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d)
		=> (c, e, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, P pF, P pG, P pH, P pI, T10 j)
		=> (c, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, P pF, P pG, P pH, T9 i)
		=> (c, e, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, P pF, P pG, P pH, T9 i, T10 j)
		=> (c, e, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, P pF, P pG, T8 h)
		=> (c, e, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, P pF, P pG, T8 h, P pI, T10 j)
		=> (c, e, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, P pF, P pG, T8 h, T9 i)
		=> (c, e, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, P pF, P pG, T8 h, T9 i, T10 j)
		=> (c, e, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, P pF, T7 g)
		=> (c, e, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, P pF, T7 g, P pH, P pI, T10 j)
		=> (c, e, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, P pF, T7 g, P pH, T9 i)
		=> (c, e, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, P pF, T7 g, P pH, T9 i, T10 j)
		=> (c, e, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, P pF, T7 g, T8 h)
		=> (c, e, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, P pF, T7 g, T8 h, P pI, T10 j)
		=> (c, e, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, P pF, T7 g, T8 h, T9 i)
		=> (c, e, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (c, e, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f)
		=> (c, e, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f, P pG, P pH, P pI, T10 j)
		=> (c, e, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f, P pG, P pH, T9 i)
		=> (c, e, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f, P pG, P pH, T9 i, T10 j)
		=> (c, e, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f, P pG, T8 h)
		=> (c, e, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f, P pG, T8 h, P pI, T10 j)
		=> (c, e, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f, P pG, T8 h, T9 i)
		=> (c, e, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (c, e, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f, T7 g)
		=> (c, e, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f, T7 g, P pH, P pI, T10 j)
		=> (c, e, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f, T7 g, P pH, T9 i)
		=> (c, e, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (c, e, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f, T7 g, T8 h)
		=> (c, e, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (c, e, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (c, e, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, P pE, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (c, e) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e)
		=> (c, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, P pF, P pG, P pH, P pI, T10 j)
		=> (c, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, P pF, P pG, P pH, T9 i)
		=> (c, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, P pF, P pG, P pH, T9 i, T10 j)
		=> (c, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, P pF, P pG, T8 h)
		=> (c, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, P pF, P pG, T8 h, P pI, T10 j)
		=> (c, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, P pF, P pG, T8 h, T9 i)
		=> (c, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, P pF, P pG, T8 h, T9 i, T10 j)
		=> (c, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, P pF, T7 g)
		=> (c, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, P pF, T7 g, P pH, P pI, T10 j)
		=> (c, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, P pF, T7 g, P pH, T9 i)
		=> (c, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, P pF, T7 g, P pH, T9 i, T10 j)
		=> (c, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, P pF, T7 g, T8 h)
		=> (c, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, P pF, T7 g, T8 h, P pI, T10 j)
		=> (c, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (c, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (c, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f)
		=> (c, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f, P pG, P pH, P pI, T10 j)
		=> (c, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f, P pG, P pH, T9 i)
		=> (c, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f, P pG, P pH, T9 i, T10 j)
		=> (c, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f, P pG, T8 h)
		=> (c, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f, P pG, T8 h, P pI, T10 j)
		=> (c, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (c, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (c, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f, T7 g)
		=> (c, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f, T7 g, P pH, P pI, T10 j)
		=> (c, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (c, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (c, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f, T7 g, T8 h)
		=> (c, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (c, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (c, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T3, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, P pC, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (c) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c)
		=> (d, e, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, P pF, P pG, P pH, P pI, T10 j)
		=> (d, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, P pF, P pG, P pH, T9 i)
		=> (d, e, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, P pF, P pG, P pH, T9 i, T10 j)
		=> (d, e, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, P pF, P pG, T8 h)
		=> (d, e, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, P pF, P pG, T8 h, P pI, T10 j)
		=> (d, e, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, P pF, P pG, T8 h, T9 i)
		=> (d, e, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, P pF, P pG, T8 h, T9 i, T10 j)
		=> (d, e, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, P pF, T7 g)
		=> (d, e, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, P pF, T7 g, P pH, P pI, T10 j)
		=> (d, e, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, P pF, T7 g, P pH, T9 i)
		=> (d, e, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, P pF, T7 g, P pH, T9 i, T10 j)
		=> (d, e, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, P pF, T7 g, T8 h)
		=> (d, e, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, P pF, T7 g, T8 h, P pI, T10 j)
		=> (d, e, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, P pF, T7 g, T8 h, T9 i)
		=> (d, e, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (d, e, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f)
		=> (d, e, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f, P pG, P pH, P pI, T10 j)
		=> (d, e, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f, P pG, P pH, T9 i)
		=> (d, e, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f, P pG, P pH, T9 i, T10 j)
		=> (d, e, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f, P pG, T8 h)
		=> (d, e, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f, P pG, T8 h, P pI, T10 j)
		=> (d, e, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f, P pG, T8 h, T9 i)
		=> (d, e, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (d, e, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f, T7 g)
		=> (d, e, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f, T7 g, P pH, P pI, T10 j)
		=> (d, e, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f, T7 g, P pH, T9 i)
		=> (d, e, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (d, e, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f, T7 g, T8 h)
		=> (d, e, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (d, e, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (d, e, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, P pE, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (d, e) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e)
		=> (d, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, P pF, P pG, P pH, P pI, T10 j)
		=> (d, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, P pF, P pG, P pH, T9 i)
		=> (d, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, P pF, P pG, P pH, T9 i, T10 j)
		=> (d, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, P pF, P pG, T8 h)
		=> (d, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, P pF, P pG, T8 h, P pI, T10 j)
		=> (d, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, P pF, P pG, T8 h, T9 i)
		=> (d, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, P pF, P pG, T8 h, T9 i, T10 j)
		=> (d, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, P pF, T7 g)
		=> (d, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, P pF, T7 g, P pH, P pI, T10 j)
		=> (d, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, P pF, T7 g, P pH, T9 i)
		=> (d, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, P pF, T7 g, P pH, T9 i, T10 j)
		=> (d, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, P pF, T7 g, T8 h)
		=> (d, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, P pF, T7 g, T8 h, P pI, T10 j)
		=> (d, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (d, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (d, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f)
		=> (d, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f, P pG, P pH, P pI, T10 j)
		=> (d, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f, P pG, P pH, T9 i)
		=> (d, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f, P pG, P pH, T9 i, T10 j)
		=> (d, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f, P pG, T8 h)
		=> (d, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f, P pG, T8 h, P pI, T10 j)
		=> (d, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (d, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (d, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f, T7 g)
		=> (d, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f, T7 g, P pH, P pI, T10 j)
		=> (d, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (d, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (d, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f, T7 g, T8 h)
		=> (d, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (d, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (d, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T4, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, P pD, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (d) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d)
		=> (e, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, P pF, P pG, P pH, P pI, T10 j)
		=> (e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, P pF, P pG, P pH, T9 i)
		=> (e, f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, P pF, P pG, P pH, T9 i, T10 j)
		=> (e, f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, P pF, P pG, T8 h)
		=> (e, f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, P pF, P pG, T8 h, P pI, T10 j)
		=> (e, f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, P pF, P pG, T8 h, T9 i)
		=> (e, f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, P pF, P pG, T8 h, T9 i, T10 j)
		=> (e, f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, P pF, T7 g)
		=> (e, f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, P pF, T7 g, P pH, P pI, T10 j)
		=> (e, f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, P pF, T7 g, P pH, T9 i)
		=> (e, f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, P pF, T7 g, P pH, T9 i, T10 j)
		=> (e, f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, P pF, T7 g, T8 h)
		=> (e, f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, P pF, T7 g, T8 h, P pI, T10 j)
		=> (e, f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, P pF, T7 g, T8 h, T9 i)
		=> (e, f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (e, f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f)
		=> (e, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f, P pG, P pH, P pI, T10 j)
		=> (e, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f, P pG, P pH, T9 i)
		=> (e, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f, P pG, P pH, T9 i, T10 j)
		=> (e, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f, P pG, T8 h)
		=> (e, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f, P pG, T8 h, P pI, T10 j)
		=> (e, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f, P pG, T8 h, T9 i)
		=> (e, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (e, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f, T7 g)
		=> (e, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f, T7 g, P pH, P pI, T10 j)
		=> (e, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f, T7 g, P pH, T9 i)
		=> (e, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (e, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f, T7 g, T8 h)
		=> (e, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (e, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f, T7 g, T8 h, T9 i)
		=> (e, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T5, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, P pE, T6 f, T7 g, T8 h, T9 i, T10 j)
		=> (e) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T6, T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e)
		=> (f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T6, T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, P pF, P pG, P pH, P pI, T10 j)
		=> (f, g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T6, T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, P pF, P pG, P pH, T9 i)
		=> (f, g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T6, T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, P pF, P pG, P pH, T9 i, T10 j)
		=> (f, g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T6, T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, P pF, P pG, T8 h)
		=> (f, g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T6, T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, P pF, P pG, T8 h, P pI, T10 j)
		=> (f, g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T6, T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, P pF, P pG, T8 h, T9 i)
		=> (f, g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T6, T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, P pF, P pG, T8 h, T9 i, T10 j)
		=> (f, g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T6, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, P pF, T7 g)
		=> (f, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T6, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, P pF, T7 g, P pH, P pI, T10 j)
		=> (f, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T6, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, P pF, T7 g, P pH, T9 i)
		=> (f, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T6, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, P pF, T7 g, P pH, T9 i, T10 j)
		=> (f, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T6, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, P pF, T7 g, T8 h)
		=> (f, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T6, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, P pF, T7 g, T8 h, P pI, T10 j)
		=> (f, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T6, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, P pF, T7 g, T8 h, T9 i)
		=> (f, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T6, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, P pF, T7 g, T8 h, T9 i, T10 j)
		=> (f) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T7, T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
		=> (g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T7, T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, P pG, P pH, P pI, T10 j)
		=> (g, h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T7, T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, P pG, P pH, T9 i)
		=> (g, h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T7, T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, P pG, P pH, T9 i, T10 j)
		=> (g, h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T7, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, P pG, T8 h)
		=> (g, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T7, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, P pG, T8 h, P pI, T10 j)
		=> (g, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T7, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, P pG, T8 h, T9 i)
		=> (g, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T7, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, P pG, T8 h, T9 i, T10 j)
		=> (g) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T8, T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
		=> (h, i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T8, T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, P pH, P pI, T10 j)
		=> (h, i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T8, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, P pH, T9 i)
		=> (h, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T8, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, P pH, T9 i, T10 j)
		=> (h) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T9, T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		=> (i, j) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T9, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, P pI, T10 j)
		=> (i) => function(a, b, c, d, e, f, g, h, i, j);

		public static
			Func<T10, TResult>
			Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function,
				T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		=> (j) => function(a, b, c, d, e, f, g, h, i, j);

		#endregion

	}
}
