using System;
using System.Threading;

namespace WillyNilly
{
    internal sealed class DefaultUniformRandomSource : IRandomSource
    {
        private readonly ThreadLocal<Random> _random = new ThreadLocal<Random>(() => new Random());

        private Random GetCurrentRandom()
        {
            return _random.Value;
        }

        public int NextInt(int min, int max) => GetCurrentRandom().Next(min, max);

        public double NextDouble() => GetCurrentRandom().NextDouble();
        public double NextDouble(double min, double max) => min + (max - min) * GetCurrentRandom().NextDouble();
    }
}