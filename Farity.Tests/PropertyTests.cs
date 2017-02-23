using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Farity.Tests
{
    public class PropertyTests
    {
        [Fact]
        public void PropertyReturnsPropertyOfObject()
        {
            const int expected = 2;
            var data = new List<int> {1, 2};
            var countProperty = F.Property<List<int>, int>(list => list.Count);
            var actual = countProperty(data);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PropertyReturnsReturnValueOfMethodOfObject()
        {
            const int expected = 2;
            var data = new List<int> { 1, 2 };
            var countProperty = F.Property<IEnumerable<int>, int>(list => list.Count());
            var actual = countProperty(data);
            Assert.Equal(expected, actual);
        }
    }
}