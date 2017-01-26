using Xunit;

namespace Farity.Tests
{
    public class IncrementTests
    {
        [Theory]
        [InlineData(1.22d)]
        [InlineData(-1.22d)]
        public void IncrementIncrementsDoubleByOne(double a)
        {
            var expected = a + 1;
            var actual = F.Increment(a);
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(1.22f)]
        [InlineData(-1.22f)]
        public void IncrementIncrementsFloatByOne(float a)
        {
            var expected = a + 1;
            var actual = F.Increment(a);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(-1)]
        public void IncrementIncrementsIntegerByOne(int a)
        {
            var expected = a + 1;
            var actual = F.Increment(a);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1L)]
        [InlineData(-1L)]
        public void IncrementIncrementsLongByOne(long a)
        {
            var expected = a + 1;
            var actual = F.Increment(a);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1U)]
        [InlineData(12U)]
        public void IncrementIncrementsUintByOne(uint a)
        {
            var expected = a + 1;
            var actual = F.Increment(a);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1UL)]
        [InlineData(11UL)]
        public void IncrementIncrementsUlongByOne(ulong a)
        {
            var expected = a + 1;
            var actual = F.Increment(a);
            Assert.Equal(expected, actual);
        }
    }
}