using Xunit;
using System.Linq;

namespace Farity.Tests
{
    public class FirstTests
    {
        [Fact]
        public void FirstReturnsFirstElement()
        {
            var data = new[] { 1, 2, 3, 4, 5 };
            var expected = 1;
            var actual = F.First(data);
            Assert.Equal(expected, actual);
        }
    }
}
