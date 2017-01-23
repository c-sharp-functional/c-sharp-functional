namespace Farity
{
    /// <summary>
    /// A delegate that represents a function that takes any number of arguments but always returns a specified type.
    /// </summary>
    /// <typeparam name="T">The type of value that the function returns.</typeparam>
    /// <param name="args">Any arguments passed into the function.</param>
    /// <returns>A value of type <seealso cref="T"/>.</returns>
    public delegate T FuncAny<out T>(params object[] args);
}