using Xunit;

namespace Farity.Tests
{
    public class AlwaysTests
    {
        [Fact]
        public void AlwaysReturnsAFunctionThatReturnsTheSameValueAlways()
        {
            var answerToLifeUniverseAndEverything = F.Always(42);
            var answer = answerToLifeUniverseAndEverything();
            Assert.Equal(answer, answerToLifeUniverseAndEverything());
            Assert.Equal(answer, answerToLifeUniverseAndEverything(1));
            Assert.Equal(answer, answerToLifeUniverseAndEverything("string", null));
            Assert.Equal(answer, answerToLifeUniverseAndEverything(null, "str", 3));
            Assert.Equal(answer, answerToLifeUniverseAndEverything(null, null, null, null));
        }
    }
}