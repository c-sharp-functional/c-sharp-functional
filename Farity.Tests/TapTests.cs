using System;
using System.Diagnostics;
using Xunit;

namespace Farity.Tests
{
    public class TapTests
    {
        [Fact]
        public void TapRunsFunctionOverValue()
        {
            var value = "";
            Action<int> function = number => value = number.ToString();
            F.Tap(function, 42);
            Assert.Equal("42", value);
        }

        [Fact]
        public void TapReturnsOriginalValue()
        {
            const int expected = 42;
            Action<int> function = number => Debug.WriteLine(number);
            var result = F.Tap(function, expected);
            Assert.Equal(expected, result);
        }
    }
}