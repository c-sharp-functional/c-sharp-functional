using System;
using Xunit;

namespace Farity.Tests
{
    public class CurryTests
    {
        [Fact]
        public void CurryingWorksForArity2()
        {
            Func<int, int, int> sum =
                (a, b) => a + b;
            Assert.Equal(
                sum(1, 2),
                F.Curry(sum)(1)(2));
        }

        [Fact]
        public void CurryingWorksForArity3()
        {
            Func<int, int, int, int> sum =
                (a, b, c) => a + b + c;
            Assert.Equal(
                sum(1, 2, 3),
                F.Curry(sum)(1)(2)(3));
        }

        [Fact]
        public void CurryingWorksForArity4()
        {
            Func<int, int, int, int, int> sum =
                (a, b, c, d) => a + b + c + d;
            Assert.Equal(
                sum(1, 2, 3, 4),
                F.Curry(sum)(1)(2)(3)(4));
        }

        [Fact]
        public void CurryingWorksForArity5()
        {
            Func<int, int, int, int, int, int> sum =
                (a, b, c, d, e) => a + b + c + d + e;
            Assert.Equal(
                sum(1, 2, 3, 4, 5),
                F.Curry(sum)(1)(2)(3)(4)(5));
        }
        [Fact]
        public void CurryingWorksForArity6()
        {
            Func<int, int, int, int, int, int, int> sum =
                (a, b, c, d, e, f) => a + b + c + d + e + f;
            Assert.Equal(
                sum(1, 2, 3, 4, 5, 6),
                F.Curry(sum)(1)(2)(3)(4)(5)(6));
        }

        [Fact]
        public void CurryingWorksForArity7()
        {
            Func<int, int, int, int, int, int, int, int> sum =
                (a, b, c, d, e, f, g) => a + b + c + d + e + f + g;
            Assert.Equal(
                sum(1, 2, 3, 4, 5, 6, 7),
                F.Curry(sum)(1)(2)(3)(4)(5)(6)(7));
        }

        [Fact]
        public void CurryingWorksForArity8()
        {
            Func<int, int, int, int, int, int, int, int, int> sum =
                (a, b, c, d, e, f, g, h) => a + b + c + d + e + f + g + h;
            Assert.Equal(
                sum(1, 2, 3, 4, 5, 6, 7, 8),
                F.Curry(sum)(1)(2)(3)(4)(5)(6)(7)(8));
        }

        [Fact]
        public void CurryingWorksForArity9()
        {
            Func<int, int, int, int, int, int, int, int, int, int> sum =
                (a, b, c, d, e, f, g, h, i) => a + b + c + d + e + f + g + h + i;
            Assert.Equal(
                sum(1, 2, 3, 4, 5, 6, 7, 8, 9),
                F.Curry(sum)(1)(2)(3)(4)(5)(6)(7)(8)(9));
        }

        [Fact]
        public void CurryingWorksForArity10()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int> sum =
                (a, b, c, d, e, f, g, h, i, j) => a + b + c + d + e + f + g + h + i + j;
            Assert.Equal(
                sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10),
                F.Curry(sum)(1)(2)(3)(4)(5)(6)(7)(8)(9)(10));
        }
    }
}