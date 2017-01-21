using System;

namespace Farity
{
    public static partial class F
    {
        public static decimal Subtract(decimal a, decimal b) => a - b;
        public static double Subtract(double a, double b) => a - b;
        public static float Subtract(float a, float b) => a - b;
        public static int Subtract(int a, int b) => a - b;
        public static long Subtract(long a, long b) => a - b;
        public static uint Subtract(uint a, uint b) => b > a ? 0 : a - b;
        public static ulong Subtract(ulong a, ulong b) => b > a ? 0 : a - b;
        public static TimeSpan Subtract(TimeSpan a, TimeSpan b) => a - b;

        public static decimal? Subtract(decimal? a, decimal? b)
            => a == null && b == null ? (decimal?) null : Subtract(a ?? 0,b ?? 0);

        public static double? Subtract(double? a, double? b)
            => a == null && b == null ? (double?) null : Subtract(a ?? 0,b ?? 0);

        public static float? Subtract(float? a, float? b)
            => a == null && b == null ? (float?) null : Subtract(a ?? 0, b ?? 0);

        public static int? Subtract(int? a, int? b)
            => a == null && b == null ? (int?) null : Subtract(a ?? 0,b ?? 0);

        public static long? Subtract(long? a, long? b)
            => a == null && b == null ? (long?) null : Subtract(a ?? 0, b ?? 0);

        public static uint? Subtract(uint? a, uint? b)
            => a == null && b == null ? (uint?) null : Subtract(a ?? 0, b ?? 0);

        public static ulong? Subtract(ulong? a, ulong? b)
            => a == null && b == null ? (ulong?) null : Subtract(a ?? 0, b ?? 0);

        public static TimeSpan? Subtract(TimeSpan? a, TimeSpan? b)
            => a == null && b == null ? (TimeSpan?) null : Subtract(a ?? TimeSpan.Zero, b ?? TimeSpan.Zero);
    }
}