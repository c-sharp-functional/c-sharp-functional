using System;

namespace Farity
{
    public static partial class F
    {
        /// <summary>
        /// Runs the given function with the supplied value, then returns the value.
        /// Functions that do not mutate the value provided are recommended.
        /// </summary>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <param name="function">The function to run on the value.</param>
        /// <param name="value">The value to be provided to the function.</param>
        /// <returns>The original value supplied.</returns>
        /// <remarks>Category: Function</remarks>
        public static T Tap<T>(Action<T> function, T value)
        {
            function(value);
            return value;
        }
    }
}