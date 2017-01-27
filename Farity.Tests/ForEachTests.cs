using System;
using System.Diagnostics;
using System.Linq;
using Xunit;

namespace Farity.Tests
{
    public class ForEachTests
    {
        [Fact]
        public void ForEachExecutesFunctionsForAllElementsInTheList()
        {
            var expected = "12345";
            var collected = "";
            var source = new[] {1, 2, 3, 4, 5};
            Action<int> action = number => collected += number.ToString();
            F.ForEach(action, source).ToArray();
            Assert.Equal(expected, collected);
        }

        [Fact]
        public void ForEachReturnsAllElementsInTheSource()
        {
            var expected = new[] {1, 2, 3, 4, 5};
            Action<int> action = number => Debug.WriteLine(number);
            var actual = F.ForEach(action, expected);
            Assert.Equal(expected, actual);
        }
    }
}