using Xunit;

namespace Farity.Tests
{
    public class TrueTests
    {
        [Fact]
        public void TrueProvidesTrueGiven0Arguments()
        {
            var result = F.True();
            Assert.Equal(true, result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData("acs")]
        [InlineData(true)]
        public void TrueProvidesTrueGiven1Argument(object arg1)
        {
            var result = F.True(arg1);
            Assert.Equal(true, result);
        }

        [Theory]
        [InlineData(1, "acs", true)]
        public void TrueProvidesTrueGivenAnyNumberOfArguments(params object[] args)
        {
            var result = F.True(args);
            Assert.Equal(true, result);
        }

        [Fact]
        public void TrueProvidesTrueEveryTime()
        {
            var result = F.True();
            Assert.Equal(true, result);
            var result2 = F.True();
            Assert.Equal(true, result2);
        }
    }
}