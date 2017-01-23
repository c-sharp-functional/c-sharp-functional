namespace Farity
{
    public static partial class F
    {
        /// <summary>
        /// A function that takes any arguments and returns true.
        /// </summary>
        /// <param name="args">Any arguments passed to the function.</param>
        /// <returns>true</returns>
        public static bool True(params object[] args) => true;
    }
}