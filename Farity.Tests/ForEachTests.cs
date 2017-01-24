using System;
using System.Collections.Generic;
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
            var source = new List<int>() {1, 2, 3, 4, 5};
            Action<int> action = number => collected += number.ToString();
            F.ForEach(action, source);
            Assert.Equal(expected, collected);
        }
    }
}
