namespace Farity
{
    public static partial class F
    {
        /// <summary>
        /// A function that takes any arguments and returns false.
        /// </summary>
        /// <param name="args">Any arguments passed to the function.</param>
        /// <returns>false</returns>
        public static bool False(params object[] args) => false;
    }
}