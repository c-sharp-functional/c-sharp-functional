using Xunit;

namespace Farity.Tests
{
    public class UniqueTests
    {
        [Fact]
        public void UniqueReturnsUniqueElementsOfList()
        {
            var data = new[] { 1, 2, 1, 4, 2 };
            var expected = new[] { 1, 2, 4 };
            var actual = F.Unique(data);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UniqueDoesNotMutateOriginalSequence()
        {
            var data = new[] { 1, 2, 1, 4, 2 };
            var expected = new[] { 1, 2, 1, 4, 2 };
            var result = F.Unique(data);
            Assert.Equal(expected, data);
        } 
    }
}
