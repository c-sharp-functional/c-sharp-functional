using System.Linq;
using Xunit;

namespace Farity.Tests
{
    public class MapTests
    {
        [Fact]
        public void MapExecutesFunctionsForAllElementsInTheList()
        {
            var expected = new[] {"1", "2", "3", "4", "5"};
            var source = new[] { 1, 2, 3, 4, 5 };
            var actual = F.Map(x => x.ToString(), source);
            Assert.Equal(expected, actual);
        }
    }
}