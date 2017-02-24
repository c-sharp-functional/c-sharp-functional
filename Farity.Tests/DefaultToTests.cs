using Xunit;

namespace Farity.Tests
{
    public class DefaultToTests
    {
        [Fact]
        public void DefaultToDefaultsToProvidedValueIfSequenceIsEmpty()
        {
            const int defaultValue = 42;
            var expected = new int[] { defaultValue };
            var sequence = new int[] { };
            var actual = F.DefaultTo(defaultValue, sequence);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DefaultToDefaultsToProvidedValueIfSequenceIsNull()
        {
            const int defaultValue = 42;
            var expected = new int[] { defaultValue };
            int[] sequence = null;
            var actual = F.DefaultTo(defaultValue, sequence);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DefaultToDefaultsToProvidedValueIfSequenceIsNotEmpty()
        {
            const int defaultValue = 42;
            var expected = new[] { 1,2,3 };
            var sequence = new[] { 1, 2, 3 };
            var actual = F.DefaultTo(defaultValue, sequence);
            Assert.Equal(expected, actual);
        }
    }
}
