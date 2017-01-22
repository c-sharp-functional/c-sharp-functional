using Xunit;

namespace Farity.Tests
{
    public class AlwaysTests
    {
        [Fact]
        public void AlwaysReturnsAFunctionThatReturnsTheSameValueAlways()
        {
            var alwaysAnswerToTheUniverseLifeAndEverything = F.Always(42);
            var answer = alwaysAnswerToTheUniverseLifeAndEverything();
            Assert.Equal(answer, alwaysAnswerToTheUniverseLifeAndEverything());
            Assert.Equal(answer, alwaysAnswerToTheUniverseLifeAndEverything(1));
            Assert.Equal(answer, alwaysAnswerToTheUniverseLifeAndEverything("string", null));
            Assert.Equal(answer, alwaysAnswerToTheUniverseLifeAndEverything(null, "str", 3));
            Assert.Equal(answer, alwaysAnswerToTheUniverseLifeAndEverything(null, null, null, null));
        }
    }
}