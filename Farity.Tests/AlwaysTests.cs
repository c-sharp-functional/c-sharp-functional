using Xunit;

namespace Farity.Tests
{
    public class AlwaysTests
    {
        [Theory]
        [InlineData()]
        [InlineData(1)]
        [InlineData(null, null)]
        [InlineData(null, null, "string")]
        [InlineData(null, null, "string", 3)]
        [InlineData(null, null, "string", 3, 7)]
        [InlineData(null, null, "string", 3, 7, 9U)]
        [InlineData(null, null, "string", 3, 7, 9U, 7L)]
        [InlineData(null, null, "string", 3, 7, 9U, 7L, 9UL)]
        public void AlwaysReturnsAFunctionThatReturnsTheSameValueAlways(params object[] args)
        {
            const int expected = 42;
            var answerToLifeUniverseAndEverything = F.Always(expected);
            var actual = answerToLifeUniverseAndEverything(args);
            Assert.Equal(expected, actual);
        }
    }
}