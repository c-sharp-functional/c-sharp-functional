using System.Linq;
using Xunit;

namespace Farity.Tests
{
    public class ReduceTests
    {
        [Fact]
        public void ReduceExecutesFunctionsForAllElementsInTheList()
        {
            var expected = 15;
            var actual = F.Reduce((sum, current) => sum + current, 0, new[] { 1, 2, 3, 4, 5 });
            Assert.Equal(expected, actual);
        }
    }
}