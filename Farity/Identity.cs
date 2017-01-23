namespace Farity
{
    public static partial class F
    {
        /// <summary>
        /// A function that returns the same value that it was provided.
        /// </summary>
        /// <typeparam name="T">The type of value provided.</typeparam>
        /// <param name="x">The value provided.</param>
        /// <returns>The same value that was provided to the function.</returns>
        /// <remarks>Category: Function</remarks>
        public static T Identity<T>(T x) => x;
    }
}
