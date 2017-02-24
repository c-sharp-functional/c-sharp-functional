using System.Linq;
using Xunit;

namespace Farity.Tests
{
    public class SortTests
    {
        [Fact]
        public void SortSortsTheItemsInAscendingOrder()
        {
            var expected = new[] {1, 2, 3, 5, 9};
            var data = new[] {3, 2, 1, 9, 5};
            var actual = F.Sort(data);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SortDoesNotModifyOriginalSequence()
        {
            var expected = new[] { 1, 2, 3, 5, 9 };
            var data = new[] { 3, 2, 1, 9, 5 };
            var result = F.Sort(data).ToList();
            Assert.Equal(expected, new[] { 1, 2, 3, 5, 9 });
        }
    }
}