using System.Linq;
using Xunit;

namespace Farity.Tests
{
    public class ReduceWhileTests
    {
        [Fact]
        public void ReduceWhileExecutesFunctionsForAllElementsInTheList()
        {
            var expected = 15;
            var actual = F.ReduceWhile((r,c) => F.True(r,c), (r, c) => r + c, 0, new[] { 1, 2, 3, 4, 5 });
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReduceWhileExecutesFunctionsTillThePredicateReturnsTrue()
        {
            var expected = 10;
            var actual = F.ReduceWhile((r, c) => r < 9, (r, c) => r + c, 0, new[] { 1, 2, 3, 4, 5 });
            Assert.Equal(expected, actual);
        }
    }
}