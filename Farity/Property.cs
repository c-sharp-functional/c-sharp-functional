using System;
using System.Linq.Expressions;

namespace Farity
{
    public static partial class F
    {
        /// <summary>
        /// Returns a function that when supplied an object returns the indicated property of that object.
        /// </summary>
        /// <typeparam name="T">The type of object on which to work.</typeparam>
        /// <typeparam name="TProperty">The type of the property.</typeparam>
        /// <param name="propertyExpression">The property expression.</param>
        /// <returns>A function that when supplied an object returns the indicated property of that object.</returns>
        public static Func<T, TProperty> Property<T, TProperty>(Expression<Func<T, TProperty>> propertyExpression)
        {
            return propertyExpression.Compile();
        }

        /// <summary>
        /// Returns a function that when supplied an object returns the indicated property of that object.
        /// </summary>
        /// <typeparam name="T">The type of object on which to work.</typeparam>
        /// <param name="propertyExpression">The property expression.</param>
        /// <returns>A function that when supplied an object returns the indicated property of that object.</returns>
        public static Func<T, object> Property<T>(Expression<Func<T, object>> propertyExpression)
        {
            return propertyExpression.Compile();
        }
    }
}