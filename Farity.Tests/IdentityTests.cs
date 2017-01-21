using System;
using Xunit;

namespace Farity.Tests
{
    public class IdentityTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(2.333d)]
        [InlineData("sx")]
        [InlineData(false)]
        public void IdentityReturnsInput(dynamic x)
        {
            var result = F.Identity(x);
            Assert.Equal(x, result);
        }

        [Fact]
        public void IdentityReturnsInputForDateTime()
        {
            var input = DateTimeOffset.UtcNow;
            var result = F.Identity(input);
            Assert.Equal(input, result);
        }

        [Fact]
        public void IdentityReturnsInputForTimeSpan()
        {
            var input = TimeSpan.FromTicks(2223333);
            var result = F.Identity(input);
            Assert.Equal(input, result);
        }

        [Fact]
        public void IdentityReturnsInputForObjects()
        {
            var input = new object();
            var result = F.Identity(input);
            Assert.Equal(input, result);
        }
    }
}