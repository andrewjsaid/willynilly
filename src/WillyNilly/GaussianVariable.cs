using System;

namespace WillyNilly
{
    public class GaussianVariable : IRandomVariable<double>
    {
        private readonly double _mean;
        private readonly double _sigma;

        public GaussianVariable(double mean, double sigma)
        {
            _mean = mean;
            _sigma = sigma;
        }

        public double Measure()
        {
            double u;
            double s;

            do
            {
                u = 2.0 * RandomPool.NextDouble() - 1.0;
                var v = 2.0 * RandomPool.NextDouble() - 1.0;
                s = u * u + v * v;
            }
            while (s >= 1.0);

            double fac = Math.Sqrt(-2.0 * Math.Log(s) / s);
            var result = u * fac;

            return _sigma * result + _mean;
        }
    }
}