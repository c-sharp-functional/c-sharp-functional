using Xunit;

namespace Farity.Tests
{
    public class DecrementTests
    {
        [Theory]
        [InlineData(1.22d)]
        [InlineData(-1.22d)]
        public void DecrementDecrementsDoubleByOne(double a)
        {
            var expected = a - 1;
            var actual = F.Decrement(a);
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(1.22f)]
        [InlineData(-1.22f)]
        public void DecrementDecrementsFloatByOne(float a)
        {
            var expected = a - 1;
            var actual = F.Decrement(a);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(-1)]
        public void DecrementDecrementsIntegerByOne(int a)
        {
            var expected = a - 1;
            var actual = F.Decrement(a);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1L)]
        [InlineData(-1L)]
        public void DecrementDecrementsLongByOne(long a)
        {
            var expected = a - 1;
            var actual = F.Decrement(a);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1U)]
        [InlineData(12U)]
        public void DecrementDecrementsUintByOne(uint a)
        {
            var expected = a - 1;
            var actual = F.Decrement(a);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1UL)]
        [InlineData(11UL)]
        public void DecrementDecrementsUlongByOne(ulong a)
        {
            var expected = a - 1;
            var actual = F.Decrement(a);
            Assert.Equal(expected, actual);
        }
    }
}