using System;
using System.Threading;

namespace WillyNilly
{
    internal static class RandomPool
    {
        private static readonly ThreadLocal<Random> Random = new ThreadLocal<Random>(() => new Random());

        private static Random GetCurrentRandom()
        {
            return Random.Value;
        }

        public static int NextInt(int min, int max) => GetCurrentRandom().Next(min, max);

        public static double NextDouble() => GetCurrentRandom().NextDouble();
        public static double NextDouble(double min, double max) => min + (max - min) * GetCurrentRandom().NextDouble();
    }
}