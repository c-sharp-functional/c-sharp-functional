using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CSharp.Functional.Tests
{
    public class RangeTests
    {
        [Theory]
        [InlineData(0, 1)]
        public void RangeProvidesAnIEnumerable(int start, int end)
        {
            var result = F.Range(start, end);
            Assert.IsAssignableFrom<IEnumerable>(result);
        }

        [Theory]
        [InlineData(0, 1)]
        public void RangeProvidesAnIEnumerableOfIntegers(int start, int end)
        {
            var result = F.Range(start, end);
            Assert.IsAssignableFrom<IEnumerable<int>>(result);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(0, 0)]
        public void RangeBeginssAtStartValue(int start, int end)
        {
            var result = F.Range(start, end).First();
            Assert.Equal(start, result);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(0, 0)]
        public void RangeTerminatesAtEndValue(int start, int end)
        {
            var result = F.Range(start, end).Last();
            Assert.Equal(end, result);
        }

        [Theory]
        [InlineData(0, -3)]
        [InlineData(5, 2)]
        public void RangeReturnsEmptyEnumerableOnInvalidRanges(int start, int end)
        {
            var result = F.Range(start, end).ToList();
            Assert.Equal(0, result.Count);
        }
    }
}