using Xunit;

namespace Farity.Tests
{
    public class AddTests
    {
        [Fact]
        public void AddSumsTwoDecimals()
        {
            var a = 2.33m;
            var b = 1.99m;
            var expected = a + b;
            var actual = F.Add(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1.22d, 2.11d)]
        [InlineData(-1.22d, 2.11d)]
        public void AddSumsTwoDoubles(double a, double b)
        {
            var expected = a + b;
            var actual = F.Add(a, b);
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(1.22f, 2.11f)]
        [InlineData(-1.22f, 2.11f)]
        public void AddSumsTwoFloats(float a, float b)
        {
            var expected = a + b;
            var actual = F.Add(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(-1, 2)]
        public void AddSumsTwoIntegers(int a, int b)
        {
            var expected = a + b;
            var actual = F.Add(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1L, 2L)]
        [InlineData(-1L, 2L)]
        public void AddSumsTwoLongs(long a, long b)
        {
            var expected = a + b;
            var actual = F.Add(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1U, 2U)]
        [InlineData(12U, 2U)]
        public void AddSumsTwoUints(uint a, uint b)
        {
            var expected = a + b;
            var actual = F.Add(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1UL, 2UL)]
        [InlineData(11UL, 2UL)]
        public void AddSumsTwoUlongs(ulong a, ulong b)
        {
            var expected = a + b;
            var actual = F.Add(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1U, 2U)]
        [InlineData(11U, 2U)]
        public void AddSumsTwoUshorts(ushort a, ushort b)
        {
            var expected = a + b;
            var actual = F.Add(a, b);
            Assert.Equal(expected, actual);
        }
    }
}