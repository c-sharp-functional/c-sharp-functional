using System;
using Xunit;

namespace Farity.Tests
{
    public class UncurryTests
    {
        [Fact]
        public void UncurryingWorksForArity2()
        {
            FuncCurry<int, int, int> sum =
                a => b  => a + b;
            Assert.Equal(
                sum(1)(2),
                F.Uncurry(sum)(1, 2));
        }

        [Fact]
        public void UncurryingWorksForArity3()
        {
            FuncCurry<int, int, int, int> sum =
                a => b => c => a + b + c;
            Assert.Equal(
                sum(1)(2)(3),
                F.Uncurry(sum)(1, 2, 3));
        }

        [Fact]
        public void UncurryingWorksForArity4()
        {
            FuncCurry<int, int, int, int, int> sum =
                a => b => c => d => a + b + c + d;
            Assert.Equal(
                sum(1)(2)(3)(4),
                F.Uncurry(sum)(1, 2, 3, 4));
        }

        [Fact]
        public void UncurryingWorksForArity5()
        {
            FuncCurry<int, int, int, int, int, int> sum =
                a => b => c => d => e => a + b + c + d + e;
            Assert.Equal(
                sum(1)(2)(3)(4)(5),
                F.Uncurry(sum)(1, 2, 3, 4, 5));
        }
        [Fact]
        public void UncurryingWorksForArity6()
        {
            FuncCurry<int, int, int, int, int, int, int> sum =
                a => b => c => d => e => f => a + b + c + d + e + f;
            Assert.Equal(
                sum(1)(2)(3)(4)(5)(6),
                F.Uncurry(sum)(1, 2, 3, 4, 5, 6));
        }

        [Fact]
        public void UncurryingWorksForArity7()
        {
            FuncCurry<int, int, int, int, int, int, int, int> sum =
                a => b => c => d => e => f => g => a + b + c + d + e + f + g;
            Assert.Equal(
                sum(1)(2)(3)(4)(5)(6)(7),
                F.Uncurry(sum)(1, 2, 3, 4, 5, 6, 7));
        }

        [Fact]
        public void UncurryingWorksForArity8()
        {
            FuncCurry<int, int, int, int, int, int, int, int, int> sum =
                a => b => c => d => e => f => g => h => a + b + c + d + e + f + g + h;
            Assert.Equal(
                sum(1)(2)(3)(4)(5)(6)(7)(8),
                F.Uncurry(sum)(1, 2, 3, 4, 5, 6, 7, 8));
        }

        [Fact]
        public void UncurryingWorksForArity9()
        {
            FuncCurry<int, int, int, int, int, int, int, int, int, int> sum =
                a => b => c => d => e => f => g => h => i => a + b + c + d + e + f + g + h + i;
            Assert.Equal(
                sum(1)(2)(3)(4)(5)(6)(7)(8)(9),
                F.Uncurry(sum)(1, 2, 3, 4, 5, 6, 7, 8, 9));
        }

        [Fact]
        public void UncurryingWorksForArity10()
        {
            FuncCurry<int, int, int, int, int, int, int, int, int, int, int> sum =
                a => b => c => d => e => f => g => h => i => j => a + b + c + d + e + f + g + h + i + j;
            Assert.Equal(
                sum(1)(2)(3)(4)(5)(6)(7)(8)(9)(10),
                F.Uncurry(sum)(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
        }
    }
}