using System;

namespace Farity
{
	public static partial class F
	{
		#region Arity 1

		public static
			Func<T1, TResult>
			Compose<T1, T2, TResult>(
				Func<T2, TResult> function1,
				Func<T1, T2> function)
		=> (a) => 
			function1(function(a));

		public static
			Func<T1, TResult>
			Compose<T1, T2, T3, TResult>(
				Func<T3, TResult> function2,
				Func<T2, T3> function1,
				Func<T1, T2> function)
		=> (a) => 
			function2(function1(function(a)));

		public static
			Func<T1, TResult>
			Compose<T1, T2, T3, T4, TResult>(
				Func<T4, TResult> function3,
				Func<T3, T4> function2,
				Func<T2, T3> function1,
				Func<T1, T2> function)
		=> (a) => 
			function3(function2(function1(function(a))));

		public static
			Func<T1, TResult>
			Compose<T1, T2, T3, T4, T5, TResult>(
				Func<T5, TResult> function4,
				Func<T4, T5> function3,
				Func<T3, T4> function2,
				Func<T2, T3> function1,
				Func<T1, T2> function)
		=> (a) => 
			function4(function3(function2(function1(function(a)))));

		public static
			Func<T1, TResult>
			Compose<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T6, TResult> function5,
				Func<T5, T6> function4,
				Func<T4, T5> function3,
				Func<T3, T4> function2,
				Func<T2, T3> function1,
				Func<T1, T2> function)
		=> (a) => 
			function5(function4(function3(function2(function1(function(a))))));

		public static
			Func<T1, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T7, TResult> function6,
				Func<T6, T7> function5,
				Func<T5, T6> function4,
				Func<T4, T5> function3,
				Func<T3, T4> function2,
				Func<T2, T3> function1,
				Func<T1, T2> function)
		=> (a) => 
			function6(function5(function4(function3(function2(function1(function(a)))))));

		public static
			Func<T1, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T8, TResult> function7,
				Func<T7, T8> function6,
				Func<T6, T7> function5,
				Func<T5, T6> function4,
				Func<T4, T5> function3,
				Func<T3, T4> function2,
				Func<T2, T3> function1,
				Func<T1, T2> function)
		=> (a) => 
			function7(function6(function5(function4(function3(function2(function1(function(a))))))));

		public static
			Func<T1, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T9, TResult> function8,
				Func<T8, T9> function7,
				Func<T7, T8> function6,
				Func<T6, T7> function5,
				Func<T5, T6> function4,
				Func<T4, T5> function3,
				Func<T3, T4> function2,
				Func<T2, T3> function1,
				Func<T1, T2> function)
		=> (a) => 
			function8(function7(function6(function5(function4(function3(function2(function1(function(a)))))))));

		public static
			Func<T1, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T10, TResult> function9,
				Func<T9, T10> function8,
				Func<T8, T9> function7,
				Func<T7, T8> function6,
				Func<T6, T7> function5,
				Func<T5, T6> function4,
				Func<T4, T5> function3,
				Func<T3, T4> function2,
				Func<T2, T3> function1,
				Func<T1, T2> function)
		=> (a) => 
			function9(function8(function7(function6(function5(function4(function3(function2(function1(function(a))))))))));

		public static
			Func<T1, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
				Func<T11, TResult> function10,
				Func<T10, T11> function9,
				Func<T9, T10> function8,
				Func<T8, T9> function7,
				Func<T7, T8> function6,
				Func<T6, T7> function5,
				Func<T5, T6> function4,
				Func<T4, T5> function3,
				Func<T3, T4> function2,
				Func<T2, T3> function1,
				Func<T1, T2> function)
		=> (a) => 
			function10(function9(function8(function7(function6(function5(function4(function3(function2(function1(function(a)))))))))));

		#endregion

		#region Arity 2

		public static
			Func<T1, T2, TResult>
			Compose<T1, T2, T3, TResult>(
				Func<T3, TResult> function1,
				Func<T1, T2, T3> function)
		=> (a, b) => 
			function1(function(a, b));

		public static
			Func<T1, T2, TResult>
			Compose<T1, T2, T3, T4, TResult>(
				Func<T4, TResult> function2,
				Func<T3, T4> function1,
				Func<T1, T2, T3> function)
		=> (a, b) => 
			function2(function1(function(a, b)));

		public static
			Func<T1, T2, TResult>
			Compose<T1, T2, T3, T4, T5, TResult>(
				Func<T5, TResult> function3,
				Func<T4, T5> function2,
				Func<T3, T4> function1,
				Func<T1, T2, T3> function)
		=> (a, b) => 
			function3(function2(function1(function(a, b))));

		public static
			Func<T1, T2, TResult>
			Compose<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T6, TResult> function4,
				Func<T5, T6> function3,
				Func<T4, T5> function2,
				Func<T3, T4> function1,
				Func<T1, T2, T3> function)
		=> (a, b) => 
			function4(function3(function2(function1(function(a, b)))));

		public static
			Func<T1, T2, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T7, TResult> function5,
				Func<T6, T7> function4,
				Func<T5, T6> function3,
				Func<T4, T5> function2,
				Func<T3, T4> function1,
				Func<T1, T2, T3> function)
		=> (a, b) => 
			function5(function4(function3(function2(function1(function(a, b))))));

		public static
			Func<T1, T2, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T8, TResult> function6,
				Func<T7, T8> function5,
				Func<T6, T7> function4,
				Func<T5, T6> function3,
				Func<T4, T5> function2,
				Func<T3, T4> function1,
				Func<T1, T2, T3> function)
		=> (a, b) => 
			function6(function5(function4(function3(function2(function1(function(a, b)))))));

		public static
			Func<T1, T2, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T9, TResult> function7,
				Func<T8, T9> function6,
				Func<T7, T8> function5,
				Func<T6, T7> function4,
				Func<T5, T6> function3,
				Func<T4, T5> function2,
				Func<T3, T4> function1,
				Func<T1, T2, T3> function)
		=> (a, b) => 
			function7(function6(function5(function4(function3(function2(function1(function(a, b))))))));

		public static
			Func<T1, T2, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T10, TResult> function8,
				Func<T9, T10> function7,
				Func<T8, T9> function6,
				Func<T7, T8> function5,
				Func<T6, T7> function4,
				Func<T5, T6> function3,
				Func<T4, T5> function2,
				Func<T3, T4> function1,
				Func<T1, T2, T3> function)
		=> (a, b) => 
			function8(function7(function6(function5(function4(function3(function2(function1(function(a, b)))))))));

		public static
			Func<T1, T2, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
				Func<T11, TResult> function9,
				Func<T10, T11> function8,
				Func<T9, T10> function7,
				Func<T8, T9> function6,
				Func<T7, T8> function5,
				Func<T6, T7> function4,
				Func<T5, T6> function3,
				Func<T4, T5> function2,
				Func<T3, T4> function1,
				Func<T1, T2, T3> function)
		=> (a, b) => 
			function9(function8(function7(function6(function5(function4(function3(function2(function1(function(a, b))))))))));

		public static
			Func<T1, T2, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
				Func<T12, TResult> function10,
				Func<T11, T12> function9,
				Func<T10, T11> function8,
				Func<T9, T10> function7,
				Func<T8, T9> function6,
				Func<T7, T8> function5,
				Func<T6, T7> function4,
				Func<T5, T6> function3,
				Func<T4, T5> function2,
				Func<T3, T4> function1,
				Func<T1, T2, T3> function)
		=> (a, b) => 
			function10(function9(function8(function7(function6(function5(function4(function3(function2(function1(function(a, b)))))))))));

		#endregion

		#region Arity 3

		public static
			Func<T1, T2, T3, TResult>
			Compose<T1, T2, T3, T4, TResult>(
				Func<T4, TResult> function1,
				Func<T1, T2, T3, T4> function)
		=> (a, b, c) => 
			function1(function(a, b, c));

		public static
			Func<T1, T2, T3, TResult>
			Compose<T1, T2, T3, T4, T5, TResult>(
				Func<T5, TResult> function2,
				Func<T4, T5> function1,
				Func<T1, T2, T3, T4> function)
		=> (a, b, c) => 
			function2(function1(function(a, b, c)));

		public static
			Func<T1, T2, T3, TResult>
			Compose<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T6, TResult> function3,
				Func<T5, T6> function2,
				Func<T4, T5> function1,
				Func<T1, T2, T3, T4> function)
		=> (a, b, c) => 
			function3(function2(function1(function(a, b, c))));

		public static
			Func<T1, T2, T3, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T7, TResult> function4,
				Func<T6, T7> function3,
				Func<T5, T6> function2,
				Func<T4, T5> function1,
				Func<T1, T2, T3, T4> function)
		=> (a, b, c) => 
			function4(function3(function2(function1(function(a, b, c)))));

		public static
			Func<T1, T2, T3, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T8, TResult> function5,
				Func<T7, T8> function4,
				Func<T6, T7> function3,
				Func<T5, T6> function2,
				Func<T4, T5> function1,
				Func<T1, T2, T3, T4> function)
		=> (a, b, c) => 
			function5(function4(function3(function2(function1(function(a, b, c))))));

		public static
			Func<T1, T2, T3, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T9, TResult> function6,
				Func<T8, T9> function5,
				Func<T7, T8> function4,
				Func<T6, T7> function3,
				Func<T5, T6> function2,
				Func<T4, T5> function1,
				Func<T1, T2, T3, T4> function)
		=> (a, b, c) => 
			function6(function5(function4(function3(function2(function1(function(a, b, c)))))));

		public static
			Func<T1, T2, T3, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T10, TResult> function7,
				Func<T9, T10> function6,
				Func<T8, T9> function5,
				Func<T7, T8> function4,
				Func<T6, T7> function3,
				Func<T5, T6> function2,
				Func<T4, T5> function1,
				Func<T1, T2, T3, T4> function)
		=> (a, b, c) => 
			function7(function6(function5(function4(function3(function2(function1(function(a, b, c))))))));

		public static
			Func<T1, T2, T3, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
				Func<T11, TResult> function8,
				Func<T10, T11> function7,
				Func<T9, T10> function6,
				Func<T8, T9> function5,
				Func<T7, T8> function4,
				Func<T6, T7> function3,
				Func<T5, T6> function2,
				Func<T4, T5> function1,
				Func<T1, T2, T3, T4> function)
		=> (a, b, c) => 
			function8(function7(function6(function5(function4(function3(function2(function1(function(a, b, c)))))))));

		public static
			Func<T1, T2, T3, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
				Func<T12, TResult> function9,
				Func<T11, T12> function8,
				Func<T10, T11> function7,
				Func<T9, T10> function6,
				Func<T8, T9> function5,
				Func<T7, T8> function4,
				Func<T6, T7> function3,
				Func<T5, T6> function2,
				Func<T4, T5> function1,
				Func<T1, T2, T3, T4> function)
		=> (a, b, c) => 
			function9(function8(function7(function6(function5(function4(function3(function2(function1(function(a, b, c))))))))));

		public static
			Func<T1, T2, T3, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
				Func<T13, TResult> function10,
				Func<T12, T13> function9,
				Func<T11, T12> function8,
				Func<T10, T11> function7,
				Func<T9, T10> function6,
				Func<T8, T9> function5,
				Func<T7, T8> function4,
				Func<T6, T7> function3,
				Func<T5, T6> function2,
				Func<T4, T5> function1,
				Func<T1, T2, T3, T4> function)
		=> (a, b, c) => 
			function10(function9(function8(function7(function6(function5(function4(function3(function2(function1(function(a, b, c)))))))))));

		#endregion

		#region Arity 4

		public static
			Func<T1, T2, T3, T4, TResult>
			Compose<T1, T2, T3, T4, T5, TResult>(
				Func<T5, TResult> function1,
				Func<T1, T2, T3, T4, T5> function)
		=> (a, b, c, d) => 
			function1(function(a, b, c, d));

		public static
			Func<T1, T2, T3, T4, TResult>
			Compose<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T6, TResult> function2,
				Func<T5, T6> function1,
				Func<T1, T2, T3, T4, T5> function)
		=> (a, b, c, d) => 
			function2(function1(function(a, b, c, d)));

		public static
			Func<T1, T2, T3, T4, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T7, TResult> function3,
				Func<T6, T7> function2,
				Func<T5, T6> function1,
				Func<T1, T2, T3, T4, T5> function)
		=> (a, b, c, d) => 
			function3(function2(function1(function(a, b, c, d))));

		public static
			Func<T1, T2, T3, T4, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T8, TResult> function4,
				Func<T7, T8> function3,
				Func<T6, T7> function2,
				Func<T5, T6> function1,
				Func<T1, T2, T3, T4, T5> function)
		=> (a, b, c, d) => 
			function4(function3(function2(function1(function(a, b, c, d)))));

		public static
			Func<T1, T2, T3, T4, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T9, TResult> function5,
				Func<T8, T9> function4,
				Func<T7, T8> function3,
				Func<T6, T7> function2,
				Func<T5, T6> function1,
				Func<T1, T2, T3, T4, T5> function)
		=> (a, b, c, d) => 
			function5(function4(function3(function2(function1(function(a, b, c, d))))));

		public static
			Func<T1, T2, T3, T4, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T10, TResult> function6,
				Func<T9, T10> function5,
				Func<T8, T9> function4,
				Func<T7, T8> function3,
				Func<T6, T7> function2,
				Func<T5, T6> function1,
				Func<T1, T2, T3, T4, T5> function)
		=> (a, b, c, d) => 
			function6(function5(function4(function3(function2(function1(function(a, b, c, d)))))));

		public static
			Func<T1, T2, T3, T4, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
				Func<T11, TResult> function7,
				Func<T10, T11> function6,
				Func<T9, T10> function5,
				Func<T8, T9> function4,
				Func<T7, T8> function3,
				Func<T6, T7> function2,
				Func<T5, T6> function1,
				Func<T1, T2, T3, T4, T5> function)
		=> (a, b, c, d) => 
			function7(function6(function5(function4(function3(function2(function1(function(a, b, c, d))))))));

		public static
			Func<T1, T2, T3, T4, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
				Func<T12, TResult> function8,
				Func<T11, T12> function7,
				Func<T10, T11> function6,
				Func<T9, T10> function5,
				Func<T8, T9> function4,
				Func<T7, T8> function3,
				Func<T6, T7> function2,
				Func<T5, T6> function1,
				Func<T1, T2, T3, T4, T5> function)
		=> (a, b, c, d) => 
			function8(function7(function6(function5(function4(function3(function2(function1(function(a, b, c, d)))))))));

		public static
			Func<T1, T2, T3, T4, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
				Func<T13, TResult> function9,
				Func<T12, T13> function8,
				Func<T11, T12> function7,
				Func<T10, T11> function6,
				Func<T9, T10> function5,
				Func<T8, T9> function4,
				Func<T7, T8> function3,
				Func<T6, T7> function2,
				Func<T5, T6> function1,
				Func<T1, T2, T3, T4, T5> function)
		=> (a, b, c, d) => 
			function9(function8(function7(function6(function5(function4(function3(function2(function1(function(a, b, c, d))))))))));

		public static
			Func<T1, T2, T3, T4, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
				Func<T14, TResult> function10,
				Func<T13, T14> function9,
				Func<T12, T13> function8,
				Func<T11, T12> function7,
				Func<T10, T11> function6,
				Func<T9, T10> function5,
				Func<T8, T9> function4,
				Func<T7, T8> function3,
				Func<T6, T7> function2,
				Func<T5, T6> function1,
				Func<T1, T2, T3, T4, T5> function)
		=> (a, b, c, d) => 
			function10(function9(function8(function7(function6(function5(function4(function3(function2(function1(function(a, b, c, d)))))))))));

		#endregion

		#region Arity 5

		public static
			Func<T1, T2, T3, T4, T5, TResult>
			Compose<T1, T2, T3, T4, T5, T6, TResult>(
				Func<T6, TResult> function1,
				Func<T1, T2, T3, T4, T5, T6> function)
		=> (a, b, c, d, e) => 
			function1(function(a, b, c, d, e));

		public static
			Func<T1, T2, T3, T4, T5, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T7, TResult> function2,
				Func<T6, T7> function1,
				Func<T1, T2, T3, T4, T5, T6> function)
		=> (a, b, c, d, e) => 
			function2(function1(function(a, b, c, d, e)));

		public static
			Func<T1, T2, T3, T4, T5, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T8, TResult> function3,
				Func<T7, T8> function2,
				Func<T6, T7> function1,
				Func<T1, T2, T3, T4, T5, T6> function)
		=> (a, b, c, d, e) => 
			function3(function2(function1(function(a, b, c, d, e))));

		public static
			Func<T1, T2, T3, T4, T5, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T9, TResult> function4,
				Func<T8, T9> function3,
				Func<T7, T8> function2,
				Func<T6, T7> function1,
				Func<T1, T2, T3, T4, T5, T6> function)
		=> (a, b, c, d, e) => 
			function4(function3(function2(function1(function(a, b, c, d, e)))));

		public static
			Func<T1, T2, T3, T4, T5, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T10, TResult> function5,
				Func<T9, T10> function4,
				Func<T8, T9> function3,
				Func<T7, T8> function2,
				Func<T6, T7> function1,
				Func<T1, T2, T3, T4, T5, T6> function)
		=> (a, b, c, d, e) => 
			function5(function4(function3(function2(function1(function(a, b, c, d, e))))));

		public static
			Func<T1, T2, T3, T4, T5, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
				Func<T11, TResult> function6,
				Func<T10, T11> function5,
				Func<T9, T10> function4,
				Func<T8, T9> function3,
				Func<T7, T8> function2,
				Func<T6, T7> function1,
				Func<T1, T2, T3, T4, T5, T6> function)
		=> (a, b, c, d, e) => 
			function6(function5(function4(function3(function2(function1(function(a, b, c, d, e)))))));

		public static
			Func<T1, T2, T3, T4, T5, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
				Func<T12, TResult> function7,
				Func<T11, T12> function6,
				Func<T10, T11> function5,
				Func<T9, T10> function4,
				Func<T8, T9> function3,
				Func<T7, T8> function2,
				Func<T6, T7> function1,
				Func<T1, T2, T3, T4, T5, T6> function)
		=> (a, b, c, d, e) => 
			function7(function6(function5(function4(function3(function2(function1(function(a, b, c, d, e))))))));

		public static
			Func<T1, T2, T3, T4, T5, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
				Func<T13, TResult> function8,
				Func<T12, T13> function7,
				Func<T11, T12> function6,
				Func<T10, T11> function5,
				Func<T9, T10> function4,
				Func<T8, T9> function3,
				Func<T7, T8> function2,
				Func<T6, T7> function1,
				Func<T1, T2, T3, T4, T5, T6> function)
		=> (a, b, c, d, e) => 
			function8(function7(function6(function5(function4(function3(function2(function1(function(a, b, c, d, e)))))))));

		public static
			Func<T1, T2, T3, T4, T5, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
				Func<T14, TResult> function9,
				Func<T13, T14> function8,
				Func<T12, T13> function7,
				Func<T11, T12> function6,
				Func<T10, T11> function5,
				Func<T9, T10> function4,
				Func<T8, T9> function3,
				Func<T7, T8> function2,
				Func<T6, T7> function1,
				Func<T1, T2, T3, T4, T5, T6> function)
		=> (a, b, c, d, e) => 
			function9(function8(function7(function6(function5(function4(function3(function2(function1(function(a, b, c, d, e))))))))));

		public static
			Func<T1, T2, T3, T4, T5, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
				Func<T15, TResult> function10,
				Func<T14, T15> function9,
				Func<T13, T14> function8,
				Func<T12, T13> function7,
				Func<T11, T12> function6,
				Func<T10, T11> function5,
				Func<T9, T10> function4,
				Func<T8, T9> function3,
				Func<T7, T8> function2,
				Func<T6, T7> function1,
				Func<T1, T2, T3, T4, T5, T6> function)
		=> (a, b, c, d, e) => 
			function10(function9(function8(function7(function6(function5(function4(function3(function2(function1(function(a, b, c, d, e)))))))))));

		#endregion

		#region Arity 6

		public static
			Func<T1, T2, T3, T4, T5, T6, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, TResult>(
				Func<T7, TResult> function1,
				Func<T1, T2, T3, T4, T5, T6, T7> function)
		=> (a, b, c, d, e, f) => 
			function1(function(a, b, c, d, e, f));

		public static
			Func<T1, T2, T3, T4, T5, T6, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T8, TResult> function2,
				Func<T7, T8> function1,
				Func<T1, T2, T3, T4, T5, T6, T7> function)
		=> (a, b, c, d, e, f) => 
			function2(function1(function(a, b, c, d, e, f)));

		public static
			Func<T1, T2, T3, T4, T5, T6, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T9, TResult> function3,
				Func<T8, T9> function2,
				Func<T7, T8> function1,
				Func<T1, T2, T3, T4, T5, T6, T7> function)
		=> (a, b, c, d, e, f) => 
			function3(function2(function1(function(a, b, c, d, e, f))));

		public static
			Func<T1, T2, T3, T4, T5, T6, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T10, TResult> function4,
				Func<T9, T10> function3,
				Func<T8, T9> function2,
				Func<T7, T8> function1,
				Func<T1, T2, T3, T4, T5, T6, T7> function)
		=> (a, b, c, d, e, f) => 
			function4(function3(function2(function1(function(a, b, c, d, e, f)))));

		public static
			Func<T1, T2, T3, T4, T5, T6, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
				Func<T11, TResult> function5,
				Func<T10, T11> function4,
				Func<T9, T10> function3,
				Func<T8, T9> function2,
				Func<T7, T8> function1,
				Func<T1, T2, T3, T4, T5, T6, T7> function)
		=> (a, b, c, d, e, f) => 
			function5(function4(function3(function2(function1(function(a, b, c, d, e, f))))));

		public static
			Func<T1, T2, T3, T4, T5, T6, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
				Func<T12, TResult> function6,
				Func<T11, T12> function5,
				Func<T10, T11> function4,
				Func<T9, T10> function3,
				Func<T8, T9> function2,
				Func<T7, T8> function1,
				Func<T1, T2, T3, T4, T5, T6, T7> function)
		=> (a, b, c, d, e, f) => 
			function6(function5(function4(function3(function2(function1(function(a, b, c, d, e, f)))))));

		public static
			Func<T1, T2, T3, T4, T5, T6, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
				Func<T13, TResult> function7,
				Func<T12, T13> function6,
				Func<T11, T12> function5,
				Func<T10, T11> function4,
				Func<T9, T10> function3,
				Func<T8, T9> function2,
				Func<T7, T8> function1,
				Func<T1, T2, T3, T4, T5, T6, T7> function)
		=> (a, b, c, d, e, f) => 
			function7(function6(function5(function4(function3(function2(function1(function(a, b, c, d, e, f))))))));

		public static
			Func<T1, T2, T3, T4, T5, T6, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
				Func<T14, TResult> function8,
				Func<T13, T14> function7,
				Func<T12, T13> function6,
				Func<T11, T12> function5,
				Func<T10, T11> function4,
				Func<T9, T10> function3,
				Func<T8, T9> function2,
				Func<T7, T8> function1,
				Func<T1, T2, T3, T4, T5, T6, T7> function)
		=> (a, b, c, d, e, f) => 
			function8(function7(function6(function5(function4(function3(function2(function1(function(a, b, c, d, e, f)))))))));

		public static
			Func<T1, T2, T3, T4, T5, T6, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
				Func<T15, TResult> function9,
				Func<T14, T15> function8,
				Func<T13, T14> function7,
				Func<T12, T13> function6,
				Func<T11, T12> function5,
				Func<T10, T11> function4,
				Func<T9, T10> function3,
				Func<T8, T9> function2,
				Func<T7, T8> function1,
				Func<T1, T2, T3, T4, T5, T6, T7> function)
		=> (a, b, c, d, e, f) => 
			function9(function8(function7(function6(function5(function4(function3(function2(function1(function(a, b, c, d, e, f))))))))));

		public static
			Func<T1, T2, T3, T4, T5, T6, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
				Func<T16, TResult> function10,
				Func<T15, T16> function9,
				Func<T14, T15> function8,
				Func<T13, T14> function7,
				Func<T12, T13> function6,
				Func<T11, T12> function5,
				Func<T10, T11> function4,
				Func<T9, T10> function3,
				Func<T8, T9> function2,
				Func<T7, T8> function1,
				Func<T1, T2, T3, T4, T5, T6, T7> function)
		=> (a, b, c, d, e, f) => 
			function10(function9(function8(function7(function6(function5(function4(function3(function2(function1(function(a, b, c, d, e, f)))))))))));

		#endregion

		#region Arity 7

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
				Func<T8, TResult> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8> function)
		=> (a, b, c, d, e, f, g) => 
			function1(function(a, b, c, d, e, f, g));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T9, TResult> function2,
				Func<T8, T9> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8> function)
		=> (a, b, c, d, e, f, g) => 
			function2(function1(function(a, b, c, d, e, f, g)));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T10, TResult> function3,
				Func<T9, T10> function2,
				Func<T8, T9> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8> function)
		=> (a, b, c, d, e, f, g) => 
			function3(function2(function1(function(a, b, c, d, e, f, g))));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
				Func<T11, TResult> function4,
				Func<T10, T11> function3,
				Func<T9, T10> function2,
				Func<T8, T9> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8> function)
		=> (a, b, c, d, e, f, g) => 
			function4(function3(function2(function1(function(a, b, c, d, e, f, g)))));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
				Func<T12, TResult> function5,
				Func<T11, T12> function4,
				Func<T10, T11> function3,
				Func<T9, T10> function2,
				Func<T8, T9> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8> function)
		=> (a, b, c, d, e, f, g) => 
			function5(function4(function3(function2(function1(function(a, b, c, d, e, f, g))))));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
				Func<T13, TResult> function6,
				Func<T12, T13> function5,
				Func<T11, T12> function4,
				Func<T10, T11> function3,
				Func<T9, T10> function2,
				Func<T8, T9> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8> function)
		=> (a, b, c, d, e, f, g) => 
			function6(function5(function4(function3(function2(function1(function(a, b, c, d, e, f, g)))))));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
				Func<T14, TResult> function7,
				Func<T13, T14> function6,
				Func<T12, T13> function5,
				Func<T11, T12> function4,
				Func<T10, T11> function3,
				Func<T9, T10> function2,
				Func<T8, T9> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8> function)
		=> (a, b, c, d, e, f, g) => 
			function7(function6(function5(function4(function3(function2(function1(function(a, b, c, d, e, f, g))))))));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
				Func<T15, TResult> function8,
				Func<T14, T15> function7,
				Func<T13, T14> function6,
				Func<T12, T13> function5,
				Func<T11, T12> function4,
				Func<T10, T11> function3,
				Func<T9, T10> function2,
				Func<T8, T9> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8> function)
		=> (a, b, c, d, e, f, g) => 
			function8(function7(function6(function5(function4(function3(function2(function1(function(a, b, c, d, e, f, g)))))))));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
				Func<T16, TResult> function9,
				Func<T15, T16> function8,
				Func<T14, T15> function7,
				Func<T13, T14> function6,
				Func<T12, T13> function5,
				Func<T11, T12> function4,
				Func<T10, T11> function3,
				Func<T9, T10> function2,
				Func<T8, T9> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8> function)
		=> (a, b, c, d, e, f, g) => 
			function9(function8(function7(function6(function5(function4(function3(function2(function1(function(a, b, c, d, e, f, g))))))))));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TResult>(
				Func<T17, TResult> function10,
				Func<T16, T17> function9,
				Func<T15, T16> function8,
				Func<T14, T15> function7,
				Func<T13, T14> function6,
				Func<T12, T13> function5,
				Func<T11, T12> function4,
				Func<T10, T11> function3,
				Func<T9, T10> function2,
				Func<T8, T9> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8> function)
		=> (a, b, c, d, e, f, g) => 
			function10(function9(function8(function7(function6(function5(function4(function3(function2(function1(function(a, b, c, d, e, f, g)))))))))));

		#endregion

		#region Arity 8

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
				Func<T9, TResult> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9> function)
		=> (a, b, c, d, e, f, g, h) => 
			function1(function(a, b, c, d, e, f, g, h));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T10, TResult> function2,
				Func<T9, T10> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9> function)
		=> (a, b, c, d, e, f, g, h) => 
			function2(function1(function(a, b, c, d, e, f, g, h)));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
				Func<T11, TResult> function3,
				Func<T10, T11> function2,
				Func<T9, T10> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9> function)
		=> (a, b, c, d, e, f, g, h) => 
			function3(function2(function1(function(a, b, c, d, e, f, g, h))));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
				Func<T12, TResult> function4,
				Func<T11, T12> function3,
				Func<T10, T11> function2,
				Func<T9, T10> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9> function)
		=> (a, b, c, d, e, f, g, h) => 
			function4(function3(function2(function1(function(a, b, c, d, e, f, g, h)))));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
				Func<T13, TResult> function5,
				Func<T12, T13> function4,
				Func<T11, T12> function3,
				Func<T10, T11> function2,
				Func<T9, T10> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9> function)
		=> (a, b, c, d, e, f, g, h) => 
			function5(function4(function3(function2(function1(function(a, b, c, d, e, f, g, h))))));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
				Func<T14, TResult> function6,
				Func<T13, T14> function5,
				Func<T12, T13> function4,
				Func<T11, T12> function3,
				Func<T10, T11> function2,
				Func<T9, T10> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9> function)
		=> (a, b, c, d, e, f, g, h) => 
			function6(function5(function4(function3(function2(function1(function(a, b, c, d, e, f, g, h)))))));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
				Func<T15, TResult> function7,
				Func<T14, T15> function6,
				Func<T13, T14> function5,
				Func<T12, T13> function4,
				Func<T11, T12> function3,
				Func<T10, T11> function2,
				Func<T9, T10> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9> function)
		=> (a, b, c, d, e, f, g, h) => 
			function7(function6(function5(function4(function3(function2(function1(function(a, b, c, d, e, f, g, h))))))));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
				Func<T16, TResult> function8,
				Func<T15, T16> function7,
				Func<T14, T15> function6,
				Func<T13, T14> function5,
				Func<T12, T13> function4,
				Func<T11, T12> function3,
				Func<T10, T11> function2,
				Func<T9, T10> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9> function)
		=> (a, b, c, d, e, f, g, h) => 
			function8(function7(function6(function5(function4(function3(function2(function1(function(a, b, c, d, e, f, g, h)))))))));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TResult>(
				Func<T17, TResult> function9,
				Func<T16, T17> function8,
				Func<T15, T16> function7,
				Func<T14, T15> function6,
				Func<T13, T14> function5,
				Func<T12, T13> function4,
				Func<T11, T12> function3,
				Func<T10, T11> function2,
				Func<T9, T10> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9> function)
		=> (a, b, c, d, e, f, g, h) => 
			function9(function8(function7(function6(function5(function4(function3(function2(function1(function(a, b, c, d, e, f, g, h))))))))));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TResult>(
				Func<T18, TResult> function10,
				Func<T17, T18> function9,
				Func<T16, T17> function8,
				Func<T15, T16> function7,
				Func<T14, T15> function6,
				Func<T13, T14> function5,
				Func<T12, T13> function4,
				Func<T11, T12> function3,
				Func<T10, T11> function2,
				Func<T9, T10> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9> function)
		=> (a, b, c, d, e, f, g, h) => 
			function10(function9(function8(function7(function6(function5(function4(function3(function2(function1(function(a, b, c, d, e, f, g, h)))))))))));

		#endregion

		#region Arity 9

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
				Func<T10, TResult> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> function)
		=> (a, b, c, d, e, f, g, h, i) => 
			function1(function(a, b, c, d, e, f, g, h, i));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
				Func<T11, TResult> function2,
				Func<T10, T11> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> function)
		=> (a, b, c, d, e, f, g, h, i) => 
			function2(function1(function(a, b, c, d, e, f, g, h, i)));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
				Func<T12, TResult> function3,
				Func<T11, T12> function2,
				Func<T10, T11> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> function)
		=> (a, b, c, d, e, f, g, h, i) => 
			function3(function2(function1(function(a, b, c, d, e, f, g, h, i))));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
				Func<T13, TResult> function4,
				Func<T12, T13> function3,
				Func<T11, T12> function2,
				Func<T10, T11> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> function)
		=> (a, b, c, d, e, f, g, h, i) => 
			function4(function3(function2(function1(function(a, b, c, d, e, f, g, h, i)))));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
				Func<T14, TResult> function5,
				Func<T13, T14> function4,
				Func<T12, T13> function3,
				Func<T11, T12> function2,
				Func<T10, T11> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> function)
		=> (a, b, c, d, e, f, g, h, i) => 
			function5(function4(function3(function2(function1(function(a, b, c, d, e, f, g, h, i))))));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
				Func<T15, TResult> function6,
				Func<T14, T15> function5,
				Func<T13, T14> function4,
				Func<T12, T13> function3,
				Func<T11, T12> function2,
				Func<T10, T11> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> function)
		=> (a, b, c, d, e, f, g, h, i) => 
			function6(function5(function4(function3(function2(function1(function(a, b, c, d, e, f, g, h, i)))))));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
				Func<T16, TResult> function7,
				Func<T15, T16> function6,
				Func<T14, T15> function5,
				Func<T13, T14> function4,
				Func<T12, T13> function3,
				Func<T11, T12> function2,
				Func<T10, T11> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> function)
		=> (a, b, c, d, e, f, g, h, i) => 
			function7(function6(function5(function4(function3(function2(function1(function(a, b, c, d, e, f, g, h, i))))))));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TResult>(
				Func<T17, TResult> function8,
				Func<T16, T17> function7,
				Func<T15, T16> function6,
				Func<T14, T15> function5,
				Func<T13, T14> function4,
				Func<T12, T13> function3,
				Func<T11, T12> function2,
				Func<T10, T11> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> function)
		=> (a, b, c, d, e, f, g, h, i) => 
			function8(function7(function6(function5(function4(function3(function2(function1(function(a, b, c, d, e, f, g, h, i)))))))));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TResult>(
				Func<T18, TResult> function9,
				Func<T17, T18> function8,
				Func<T16, T17> function7,
				Func<T15, T16> function6,
				Func<T14, T15> function5,
				Func<T13, T14> function4,
				Func<T12, T13> function3,
				Func<T11, T12> function2,
				Func<T10, T11> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> function)
		=> (a, b, c, d, e, f, g, h, i) => 
			function9(function8(function7(function6(function5(function4(function3(function2(function1(function(a, b, c, d, e, f, g, h, i))))))))));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TResult>(
				Func<T19, TResult> function10,
				Func<T18, T19> function9,
				Func<T17, T18> function8,
				Func<T16, T17> function7,
				Func<T15, T16> function6,
				Func<T14, T15> function5,
				Func<T13, T14> function4,
				Func<T12, T13> function3,
				Func<T11, T12> function2,
				Func<T10, T11> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> function)
		=> (a, b, c, d, e, f, g, h, i) => 
			function10(function9(function8(function7(function6(function5(function4(function3(function2(function1(function(a, b, c, d, e, f, g, h, i)))))))))));

		#endregion

		#region Arity 10

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
				Func<T11, TResult> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> function)
		=> (a, b, c, d, e, f, g, h, i, j) => 
			function1(function(a, b, c, d, e, f, g, h, i, j));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
				Func<T12, TResult> function2,
				Func<T11, T12> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> function)
		=> (a, b, c, d, e, f, g, h, i, j) => 
			function2(function1(function(a, b, c, d, e, f, g, h, i, j)));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
				Func<T13, TResult> function3,
				Func<T12, T13> function2,
				Func<T11, T12> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> function)
		=> (a, b, c, d, e, f, g, h, i, j) => 
			function3(function2(function1(function(a, b, c, d, e, f, g, h, i, j))));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
				Func<T14, TResult> function4,
				Func<T13, T14> function3,
				Func<T12, T13> function2,
				Func<T11, T12> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> function)
		=> (a, b, c, d, e, f, g, h, i, j) => 
			function4(function3(function2(function1(function(a, b, c, d, e, f, g, h, i, j)))));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
				Func<T15, TResult> function5,
				Func<T14, T15> function4,
				Func<T13, T14> function3,
				Func<T12, T13> function2,
				Func<T11, T12> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> function)
		=> (a, b, c, d, e, f, g, h, i, j) => 
			function5(function4(function3(function2(function1(function(a, b, c, d, e, f, g, h, i, j))))));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
				Func<T16, TResult> function6,
				Func<T15, T16> function5,
				Func<T14, T15> function4,
				Func<T13, T14> function3,
				Func<T12, T13> function2,
				Func<T11, T12> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> function)
		=> (a, b, c, d, e, f, g, h, i, j) => 
			function6(function5(function4(function3(function2(function1(function(a, b, c, d, e, f, g, h, i, j)))))));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TResult>(
				Func<T17, TResult> function7,
				Func<T16, T17> function6,
				Func<T15, T16> function5,
				Func<T14, T15> function4,
				Func<T13, T14> function3,
				Func<T12, T13> function2,
				Func<T11, T12> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> function)
		=> (a, b, c, d, e, f, g, h, i, j) => 
			function7(function6(function5(function4(function3(function2(function1(function(a, b, c, d, e, f, g, h, i, j))))))));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TResult>(
				Func<T18, TResult> function8,
				Func<T17, T18> function7,
				Func<T16, T17> function6,
				Func<T15, T16> function5,
				Func<T14, T15> function4,
				Func<T13, T14> function3,
				Func<T12, T13> function2,
				Func<T11, T12> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> function)
		=> (a, b, c, d, e, f, g, h, i, j) => 
			function8(function7(function6(function5(function4(function3(function2(function1(function(a, b, c, d, e, f, g, h, i, j)))))))));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TResult>(
				Func<T19, TResult> function9,
				Func<T18, T19> function8,
				Func<T17, T18> function7,
				Func<T16, T17> function6,
				Func<T15, T16> function5,
				Func<T14, T15> function4,
				Func<T13, T14> function3,
				Func<T12, T13> function2,
				Func<T11, T12> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> function)
		=> (a, b, c, d, e, f, g, h, i, j) => 
			function9(function8(function7(function6(function5(function4(function3(function2(function1(function(a, b, c, d, e, f, g, h, i, j))))))))));

		public static
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>
			Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TResult>(
				Func<T20, TResult> function10,
				Func<T19, T20> function9,
				Func<T18, T19> function8,
				Func<T17, T18> function7,
				Func<T16, T17> function6,
				Func<T15, T16> function5,
				Func<T14, T15> function4,
				Func<T13, T14> function3,
				Func<T12, T13> function2,
				Func<T11, T12> function1,
				Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> function)
		=> (a, b, c, d, e, f, g, h, i, j) => 
			function10(function9(function8(function7(function6(function5(function4(function3(function2(function1(function(a, b, c, d, e, f, g, h, i, j)))))))))));

		#endregion

	}
}
