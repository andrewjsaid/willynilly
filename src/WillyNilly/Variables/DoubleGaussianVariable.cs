using System;

namespace WillyNilly.Variables
{
    /// <summary>
    /// Returns doubles following a gaussian distribution.
    /// </summary>
    internal sealed class DoubleGaussianVariable : IRandomVariable<double>
    {
        private readonly IRandomSource _source;
        private readonly double _mean;
        private readonly double _sigma;

        public DoubleGaussianVariable(IRandomSource source, double mean, double sigma)
        {
            _source = source;
            _mean = mean;
            _sigma = sigma;
        }

        public double Measure()
        {
            double u;
            double s;

            do
            {
                u = 2.0 * _source.NextDouble() - 1.0;
                var v = 2.0 * _source.NextDouble() - 1.0;
                s = u * u + v * v;
            }
            while (s >= 1.0);

            double fac = Math.Sqrt(-2.0 * Math.Log(s) / s);
            var result = u * fac;

            return _sigma * result + _mean;
        }
    }
}