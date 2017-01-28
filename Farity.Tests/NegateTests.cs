using Xunit;

namespace Farity.Tests
{
    public class NegateTests
    {
        [Theory]
        [InlineData(1.22d)]
        [InlineData(-1.22d)]
        public void NegateNegatesDouble(double a)
        {
            var expected = -a;
            var actual = F.Negate(a);
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(1.22f)]
        [InlineData(-1.22f)]
        public void NegateNegatesFloat(float a)
        {
            var expected = -a;
            var actual = F.Negate(a);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(-1)]
        public void NegateNegatesInteger(int a)
        {
            var expected = -a;
            var actual = F.Negate(a);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1L)]
        [InlineData(-1L)]
        public void NegateNegatesLong(long a)
        {
            var expected = -a;
            var actual = F.Negate(a);
            Assert.Equal(expected, actual);
        }
    }
}