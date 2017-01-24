using System;

namespace Farity
{
    public static partial class F
    {
        public static decimal Add(decimal a, decimal b) => a + b;
        public static double Add(double a, double b) => a + b;
        public static float Add(float a, float b) => a + b;
        public static int Add(int a, int b) => a + b;
        public static long Add(long a, long b) => a + b;
        public static uint Add(uint a, uint b) => a + b;
        public static ulong Add(ulong a, ulong b) => a + b;

        public static decimal? Add(decimal? a, decimal? b)
            => a == null && b == null ? (decimal?) null : Add(a ?? 0, b ?? 0);

        public static double? Add(double? a, double? b)
            => a == null && b == null ? (double?) null : Add(a ?? 0, b ?? 0);

        public static float? Add(float? a, float? b)
            => a == null && b == null ? (float?) null : Add(a ?? 0, b ?? 0);

        public static int? Add(int? a, int? b)
            => a == null && b == null ? (int?) null : Add(a ?? 0, b ?? 0);

        public static long? Add(long? a, long? b)
            => a == null && b == null ? (long?) null : Add(a ?? 0, b ?? 0);

        public static uint? Add(uint? a, uint? b)
            => a == null && b == null ? (uint?) null : Add(a ?? 0, b ?? 0);

        public static ulong? Add(ulong? a, ulong? b)
            => a == null && b == null ? (ulong?) null : Add(a ?? 0, b ?? 0);
    }
}