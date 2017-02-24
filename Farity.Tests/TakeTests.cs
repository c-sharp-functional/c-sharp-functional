using Xunit;
using System.Linq;

namespace Farity.Tests
{
    public class TakeTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void TakeTakesNElements(int n)
        {
            Assert.True(n <= 5 && n >= 0);
            var data = new[] { 1, 2, 3, 4, 5 };
            var expected = n;
            var dropped = F.Take(n, data).ToList();
            var actual = dropped.Count;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void DTakeTakesFirstNElements(int n)
        {
            Assert.True(n <= 5 && n >= 0);
            var data = new[] { 1, 2, 3, 4, 5 };
            var expected = data.Take(n).ToList();
            var actual = F.Take(n, data).ToList();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TakeReturnsEmptySequenceIfCountIsZero()
        {
            var expected = Enumerable.Empty<int>();
            var actual = F.Take(0, expected);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TakeReturnsSameSequenceIfCountIsGreaterThanOrEqualToLengthOfSequence()
        {
            var expected = new[] { 1, 2, 3, 4, 5 };
            var data = new[] { 1, 2, 3, 4, 5 };
            var actual = F.Take(5, expected);
            Assert.Equal(expected, actual);
            actual = F.Take(9, expected);
            Assert.Equal(expected, actual);
        }
    }
}
