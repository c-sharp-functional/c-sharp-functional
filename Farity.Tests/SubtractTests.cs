using System;
using Xunit;

namespace Farity.Tests
{
    public class SubtractTests
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(-1, 2)]
        public void SubtractSubtractsTwoIntegers(int a, int b)
        {
            var expected = a - b;
            var actual = F.Subtract(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1L, 2L)]
        [InlineData(-1L, 2L)]
        public void SubtractSubtractsTwoLongs(long a, long b)
        {
            var expected = a - b;
            var actual = F.Subtract(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1U, 2U)]
        [InlineData(12U, 2U)]
        public void SubtractSubtractsTwoUints(uint a, uint b)
        {
            var expected = a > b ? a - b : 0;
            var actual = F.Subtract(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1UL, 2UL)]
        [InlineData(11UL, 2UL)]
        public void SubtractSubtractsTwoUlongs(ulong a, ulong b)
        {
            var expected = a > b ? a - b : 0;
            var actual = F.Subtract(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubtractSubtractsTwoDecimals()
        {
            var a = 2.33m;
            var b = 1.99m;
            var expected = a - b;
            var actual = F.Subtract(a, b);
            Assert.Equal(expected, actual);
        }
    }
}