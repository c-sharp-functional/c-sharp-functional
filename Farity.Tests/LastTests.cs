using Xunit;
using System.Linq;

namespace Farity.Tests
{
    public class LastTests
    {
        [Fact]
        public void LastReturnsLastElement()
        {
            var data = new[] { 1, 2, 3, 4, 5 };
            var expected = 5;
            var actual = F.Last(data);
            Assert.Equal(expected, actual);
        }
    }
}
