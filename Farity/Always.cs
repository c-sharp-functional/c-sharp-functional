namespace Farity
{
    public static partial class F
    {
        public static FuncAny<T> Always<T>(T value) => args => value;
    }
}