using System;
using Xunit;

namespace Farity.Tests
{
    public class MapTests
    {
        [Fact]
        public void MapExecutesFunctionsForAllElementsInTheList()
        {
            var expected = new[] {"1", "2", "3", "4", "5"};
            var data = new[] {1, 2, 3, 4, 5};
            Func<int, string> map = x => x.ToString();
            var actual = F.Map(map, data);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MapWorksWithAlways()
        {
            var expected = new[] { 1, 1, 1, 1, 1 };
            var data = new[] {1, 2, 3, 4, 5};
            var alwaysOne = F.Always(1);
            var actual = F.Map(alwaysOne, data);
            Assert.Equal(expected, actual);
        }
    }
}