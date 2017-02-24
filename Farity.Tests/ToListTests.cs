using System.Collections.Immutable;
using Xunit;

namespace Farity.Tests
{
    public class ToListTests
    {
        [Fact]
        public void ToListReturnsImmutableList()
        {
            var data = new[] { 1, 2, 3, 4, 5 };
            var actual = F.ToList(data);
            Assert.IsType<ImmutableList<int>>(actual);
        }


        [Fact]
        public void ToListContainsSameItemsAsProvidedSequence()
        {
            var expected = new[] { 1, 2, 3, 4, 5 };
            var actual = F.ToList(expected);
            Assert.Equal(expected, actual);
        }
    }
}
