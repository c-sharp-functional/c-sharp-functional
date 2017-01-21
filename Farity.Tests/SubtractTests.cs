using System;
using Xunit;

namespace Farity.Tests
{
    public class SubtractTests
    {
        [Theory]
        [InlineData(1.22d, 2.11d)]
        [InlineData(-1.22d, 2.11d)]
        public void SubtractSubtractsTwoDoubles(double a, double b)
        {
            var expected = a - b;
            var actual = F.Subtract(a, b);
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(1.22f, 2.11f)]
        [InlineData(-1.22f, 2.11f)]
        public void SubtractSubtractsTwoFloats(float a, float b)
        {
            var expected = a - b;
            var actual = F.Subtract(a, b);
            Assert.Equal(expected, actual);
        }

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

        [Theory]
        [InlineData(1.22d, 2.11d)]
        [InlineData(-1.22d, 2.11d)]
        public void SubtractSubtractsTwoNullableDoubles(double? a, double? b)
        {
            var expected = a - b;
            var actual = F.Subtract(a, b);
            Assert.Equal(expected, actual);
            Assert.Equal(-b, F.Subtract(null, b));
            Assert.Equal(a, F.Subtract(a, null));
            Assert.Null(F.Subtract((double?) null, null));
        }


        [Theory]
        [InlineData(1.22f, 2.11f)]
        [InlineData(-1.22f, 2.11f)]
        public void SubtractSubtractsTwoNullableFloats(float? a, float? b)
        {
            var expected = a - b;
            var actual = F.Subtract(a, b);
            Assert.Equal(expected, actual);
            Assert.Equal(-b, F.Subtract(null, b));
            Assert.Equal(a, F.Subtract(a, null));
            Assert.Null(F.Subtract((float?) null, null));
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(-1, 2)]
        public void SubtractSubtractsTwoNullableIntegers(int a, int b)
        {
            var expected = a - b;
            var actual = F.Subtract(a, b);
            Assert.Equal(expected, actual);
            Assert.Equal(-b, F.Subtract(null, b));
            Assert.Equal(a, F.Subtract(a, null));
            Assert.Null(F.Subtract((int?) null, null));
        }

        [Theory]
        [InlineData(1L, 2L)]
        [InlineData(-1L, 2L)]
        public void SubtractSubtractsTwoNullableLongs(long? a, long? b)
        {
            var expected = a - b;
            var actual = F.Subtract(a, b);
            Assert.Equal(expected, actual);
            Assert.Equal(-b, F.Subtract(null, b));
            Assert.Equal(a, F.Subtract(a, null));
            Assert.Null(F.Subtract((long?) null, null));
        }

        [Theory]
        [InlineData(1U, 2U, 0U)]
        [InlineData(12U, 2U, 10U)]
        public void SubtractSubtractsTwoNullableUints(uint? a, uint? b, uint? expected)
        {
            var actual = F.Subtract(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1UL, 2UL, 0UL)]
        [InlineData(11UL, 2UL, 9UL)]
        public void SubtractSubtractsTwoNullableUlongs(ulong? a, ulong? b, ulong? expected)
        {
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

        [Fact]
        public void SubtractSubtractsTwoNullableDecimals()
        {
            var a = (decimal?) 2.33m;
            var b = (decimal?) 1.99m;
            var expected = a - b;
            var actual = F.Subtract(a, b);
            Assert.Equal(expected, actual);
            Assert.Equal(-b, F.Subtract(null, b));
            Assert.Equal(a, F.Subtract(a, null));
            Assert.Null(F.Subtract((decimal?) null, null));
        }

        [Fact]
        public void SubtractSubtractsTwoNullableTimeSpans()
        {
            var a = TimeSpan.FromMilliseconds(22);
            var b = TimeSpan.FromMinutes(2);
            var expected = a - b;
            var actual = F.Subtract(a, b);
            Assert.Equal(expected, actual);
            Assert.Equal(-b, F.Subtract(null, b));
            Assert.Equal(a, F.Subtract(a, null));
            Assert.Null(F.Subtract((TimeSpan?) null, null));
        }

        [Fact]
        public void SubtractSubtractsTwoTimeSpans()
        {
            var a = TimeSpan.FromMilliseconds(22);
            var b = TimeSpan.FromMinutes(2);
            var expected = a - b;
            var actual = F.Subtract(a, b);
            Assert.Equal(expected, actual);
        }
    }
}