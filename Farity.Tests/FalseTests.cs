using Xunit;

namespace Farity.Tests
{
    public class FalseTests
    {
        [Fact]
        public void FalseProvidesFalseGiven0Arguments()
        {
            var result = F.False();
            Assert.Equal(false, result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData("acs")]
        [InlineData(true)]
        public void FalseProvidesFalseGiven1Argument(object arg1)
        {
            var result = F.False(arg1);
            Assert.Equal(false, result);
        }

        [Theory]
        [InlineData(1, "acs", true)]
        public void FalseProvidesFalseGivenAnyNumberOfArguments(params object[] args)
        {
            var result = F.False(args);
            Assert.Equal(false, result);
        }

        [Fact]
        public void FalseProvidesFalseEveryTime()
        {
            var result = F.False();
            Assert.Equal(false, result);
            var result2 = F.False();
            Assert.Equal(false, result2);
        }
    }
}