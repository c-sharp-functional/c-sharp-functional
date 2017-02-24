using Xunit;
using System.Linq;

namespace Farity.Tests
{
    public class TakeFromTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void TakeFromTakesElementsFromIndexN(int n)
        {
            Assert.True(n <= 5 && n >= 0);
            var data = new[] { 1, 2, 3, 4, 5 };
            var expected = data.Skip(n).ToList();
            var actual = F.TakeFrom(n, data).ToList();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TakeFromReturnsSameSequenceIfIndexIsZero()
        {
            var expected = new[] { 1, 2, 3, 4, 5 };
            var actual = F.TakeFrom(0, expected);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TakeFromReturnsEmptySequenceIfIndexIsGreaterThanOrEqualToLengthOfSequence()
        {
            var expected = new int[] { };
            var data = new[] { 1, 2, 3, 4, 5 };
            var actual = F.TakeFrom(5, expected);
            Assert.Equal(expected, actual);
            actual = F.TakeFrom(9, expected);
            Assert.Equal(expected, actual);
        }
    }
}
