using Xunit;

namespace Farity.Tests
{
    public class AlwaysTests
    {
        [Fact]
        public void AlwaysReturnsAFunctionThatReturnsTheSameValueAlways()
        {
            const int expected = 42;
            var answerToLifeUniverseAndEverything = F.Always(expected);
            Assert.Equal(expected, answerToLifeUniverseAndEverything());
            Assert.Equal(expected, answerToLifeUniverseAndEverything(1));
            Assert.Equal(expected, answerToLifeUniverseAndEverything("string", null));
            Assert.Equal(expected, answerToLifeUniverseAndEverything(null, "str", 3));
            Assert.Equal(expected, answerToLifeUniverseAndEverything(null, null, null, null));
        }
    }
}