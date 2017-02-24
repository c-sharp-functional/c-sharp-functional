using Xunit;
using System.Linq;

namespace Farity.Tests
{
    public class DropTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void DropDropsNElements(int n)
        {
            Assert.True(n <= 5 && n >= 0);
            var data = new[] { 1, 2, 3, 4, 5 };
            var expected = data.Length - n;
            var dropped = F.Drop(n, data).ToList();
            var actual = dropped.Count;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void DropDropsFirstNElements(int n)
        {
            Assert.True(n <= 5 && n >= 0);
            var data = new[] { 1, 2, 3, 4, 5 };
            var expected = data.Skip(n).ToList();
            var actual = F.Drop(n, data).ToList();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DropReturnsSameSequenceIfCountIsZero()
        {
            var expected = new[] { 1, 2, 3, 4, 5 };
            var actual = F.Drop(0, expected);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DropReturnsEmptySequenceIfCountIsGreaterThanOrEqualToLengthOfSequence()
        {
            var expected = Enumerable.Empty<int>();
            var data = new[] { 1, 2, 3, 4, 5 };
            var actual = F.Drop(5, expected);
            Assert.Equal(expected, actual);
            actual = F.Drop(9, expected);
            Assert.Equal(expected, actual);
        }
    }
}
