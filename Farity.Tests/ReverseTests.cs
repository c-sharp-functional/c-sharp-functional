using Xunit;
using System.Linq;

namespace Farity.Tests
{
    public class ReverseTests
    {
        [Fact]
        public void ReverseInvertsASequence()
        {
            var data = new[] { 1, 2, 3, 4, 5 };
            var expected = new[] { 5, 4, 3, 2, 1 };
            var actual = F.Reverse(data);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseDoesNotMutateOriginalSequence()
        {
            var data = new[] { 1, 2, 3, 4, 5 };
            var expected = new[] { 1, 2, 3, 4, 5 };
            var result = F.Reverse(data).ToList();
            Assert.Equal(expected, data);
        }
    }
}
