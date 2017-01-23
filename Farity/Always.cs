namespace Farity
{
    public static partial class F
    {
        /// <summary>
        /// Returns a function that takes any arguments but always returns the specified value.
        /// </summary>
        /// <typeparam name="T">The type of value to always return.</typeparam>
        /// <param name="value">The value that is to be always returned.</param>
        /// <returns>A function that takes any arguments but always return the specified value.</returns>
        /// <remarks>Category: Function</remarks>
        public static FuncAny<T> Always<T>(T value) => args => value;
    }
}