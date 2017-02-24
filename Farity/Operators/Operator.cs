using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Farity.Operators
{
    /// <summary>
    /// Provides standard operators (such as addition) over a single type
    /// </summary>
    public static class Operator<T>
    {
        static readonly INullOp<T> nullOp;
        internal static INullOp<T> NullOp { get { return nullOp; } }

        static readonly T zero;
        /// <summary>
        /// Returns the zero value for value-types (even full Nullable&lt;TInner&gt;) - or null for reference types
        /// </summary>
        public static T Zero { get { return zero; } }

        static readonly Func<T, T> negate, not;
        static readonly Func<T, T, T> or, and, xor;
        /// <summary>
        /// Returns a delegate to evaluate unary negation (-) for the given type; this delegate will throw
        /// an InvalidOperationException if the type T does not provide this operator, or for
        /// Nullable&lt;TInner&gt; if TInner does not provide this operator.
        /// </summary>
        public static Func<T, T> Negate { get { return negate; } }
        /// <summary>
        /// Returns a delegate to evaluate bitwise not (~) for the given type; this delegate will throw
        /// an InvalidOperationException if the type T does not provide this operator, or for
        /// Nullable&lt;TInner&gt; if TInner does not provide this operator.
        /// </summary>
        public static Func<T, T> Not { get { return not; } }
        /// <summary>
        /// Returns a delegate to evaluate bitwise or (|) for the given type; this delegate will throw
        /// an InvalidOperationException if the type T does not provide this operator, or for
        /// Nullable&lt;TInner&gt; if TInner does not provide this operator.
        /// </summary>
        public static Func<T, T, T> Or { get { return or; } }
        /// <summary>
        /// Returns a delegate to evaluate bitwise and (&amp;) for the given type; this delegate will throw
        /// an InvalidOperationException if the type T does not provide this operator, or for
        /// Nullable&lt;TInner&gt; if TInner does not provide this operator.
        /// </summary>
        public static Func<T, T, T> And { get { return and; } }
        /// <summary>
        /// Returns a delegate to evaluate bitwise xor (^) for the given type; this delegate will throw
        /// an InvalidOperationException if the type T does not provide this operator, or for
        /// Nullable&lt;TInner&gt; if TInner does not provide this operator.
        /// </summary>
        public static Func<T, T, T> Xor { get { return xor; } }

        static readonly Func<T, T, T> add, subtract, multiply, divide;
        /// <summary>
        /// Returns a delegate to evaluate binary addition (+) for the given type; this delegate will throw
        /// an InvalidOperationException if the type T does not provide this operator, or for
        /// Nullable&lt;TInner&gt; if TInner does not provide this operator.
        /// </summary>
        public static Func<T, T, T> Add { get { return add; } }
        /// <summary>
        /// Returns a delegate to evaluate binary subtraction (-) for the given type; this delegate will throw
        /// an InvalidOperationException if the type T does not provide this operator, or for
        /// Nullable&lt;TInner&gt; if TInner does not provide this operator.
        /// </summary>
        public static Func<T, T, T> Subtract { get { return subtract; } }
        /// <summary>
        /// Returns a delegate to evaluate binary multiplication (*) for the given type; this delegate will throw
        /// an InvalidOperationException if the type T does not provide this operator, or for
        /// Nullable&lt;TInner&gt; if TInner does not provide this operator.
        /// </summary>
        public static Func<T, T, T> Multiply { get { return multiply; } }
        /// <summary>
        /// Returns a delegate to evaluate binary division (/) for the given type; this delegate will throw
        /// an InvalidOperationException if the type T does not provide this operator, or for
        /// Nullable&lt;TInner&gt; if TInner does not provide this operator.
        /// </summary>
        public static Func<T, T, T> Divide { get { return divide; } }


        static readonly Func<T, T, bool> equal, notEqual, greaterThan, lessThan, greaterThanOrEqual, lessThanOrEqual;
        /// <summary>
        /// Returns a delegate to evaluate binary equality (==) for the given type; this delegate will throw
        /// an InvalidOperationException if the type T does not provide this operator, or for
        /// Nullable&lt;TInner&gt; if TInner does not provide this operator.
        /// </summary>
        public static Func<T, T, bool> Equal { get { return equal; } }
        /// <summary>
        /// Returns a delegate to evaluate binary inequality (!=) for the given type; this delegate will throw
        /// an InvalidOperationException if the type T does not provide this operator, or for
        /// Nullable&lt;TInner&gt; if TInner does not provide this operator.
        /// </summary>
        public static Func<T, T, bool> NotEqual { get { return notEqual; } }
        /// <summary>
        /// Returns a delegate to evaluate binary greater-then (&gt;) for the given type; this delegate will throw
        /// an InvalidOperationException if the type T does not provide this operator, or for
        /// Nullable&lt;TInner&gt; if TInner does not provide this operator.
        /// </summary>
        public static Func<T, T, bool> GreaterThan { get { return greaterThan; } }
        /// <summary>
        /// Returns a delegate to evaluate binary less-than (&lt;) for the given type; this delegate will throw
        /// an InvalidOperationException if the type T does not provide this operator, or for
        /// Nullable&lt;TInner&gt; if TInner does not provide this operator.
        /// </summary>
        public static Func<T, T, bool> LessThan { get { return lessThan; } }
        /// <summary>
        /// Returns a delegate to evaluate binary greater-than-or-equal (&gt;=) for the given type; this delegate will throw
        /// an InvalidOperationException if the type T does not provide this operator, or for
        /// Nullable&lt;TInner&gt; if TInner does not provide this operator.
        /// </summary>
        public static Func<T, T, bool> GreaterThanOrEqual { get { return greaterThanOrEqual; } }
        /// <summary>
        /// Returns a delegate to evaluate binary less-than-or-equal (&lt;=) for the given type; this delegate will throw
        /// an InvalidOperationException if the type T does not provide this operator, or for
        /// Nullable&lt;TInner&gt; if TInner does not provide this operator.
        /// </summary>
        public static Func<T, T, bool> LessThanOrEqual { get { return lessThanOrEqual; } }

        static Operator()
        {
            add = ExpressionUtil.CreateExpression<T, T, T>(Expression.Add);
            subtract = ExpressionUtil.CreateExpression<T, T, T>(Expression.Subtract);
            divide = ExpressionUtil.CreateExpression<T, T, T>(Expression.Divide);
            multiply = ExpressionUtil.CreateExpression<T, T, T>(Expression.Multiply);

            greaterThan = ExpressionUtil.CreateExpression<T, T, bool>(Expression.GreaterThan);
            greaterThanOrEqual = ExpressionUtil.CreateExpression<T, T, bool>(Expression.GreaterThanOrEqual);
            lessThan = ExpressionUtil.CreateExpression<T, T, bool>(Expression.LessThan);
            lessThanOrEqual = ExpressionUtil.CreateExpression<T, T, bool>(Expression.LessThanOrEqual);
            equal = ExpressionUtil.CreateExpression<T, T, bool>(Expression.Equal);
            notEqual = ExpressionUtil.CreateExpression<T, T, bool>(Expression.NotEqual);

            negate = ExpressionUtil.CreateExpression<T, T>(Expression.Negate);
            and = ExpressionUtil.CreateExpression<T, T, T>(Expression.And);
            or = ExpressionUtil.CreateExpression<T, T, T>(Expression.Or);
            not = ExpressionUtil.CreateExpression<T, T>(Expression.Not);
            xor = ExpressionUtil.CreateExpression<T, T, T>(Expression.ExclusiveOr);

            Type typeT = typeof(T);
            if (typeT.GetTypeInfo().IsValueType && typeT.GetTypeInfo().IsGenericType && (typeT.GetGenericTypeDefinition() == typeof(Nullable<>)))
            {
                // get the *inner* zero (not a null Nullable<TValue>, but default(TValue))
                Type nullType = typeT.GetGenericArguments()[0];
                zero = (T)Activator.CreateInstance(nullType);
                nullOp = (INullOp<T>)Activator.CreateInstance(
                        typeof(StructNullOp<>).MakeGenericType(nullType));
            }
            else
            {
                zero = default(T);
                if (typeT.GetTypeInfo().IsValueType)
                {
                    nullOp = (INullOp<T>)Activator.CreateInstance(
                        typeof(StructNullOp<>).MakeGenericType(typeT));
                }
                else
                {
                    nullOp = (INullOp<T>)Activator.CreateInstance(
                        typeof(ClassNullOp<>).MakeGenericType(typeT));
                }
            }
        }
    }
}