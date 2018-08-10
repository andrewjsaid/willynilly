namespace WillyNilly
{
    /// <summary>
    /// Returns doubles in uniform distribution
    /// </summary>
    public class UniformDoubleVariable : IRandomVariable<double>
    {
        private readonly double _min;
        private readonly double _max;

        public UniformDoubleVariable(double inclusiveMin, double exclusiveMax)
        {
            _min = inclusiveMin;
            _max = exclusiveMax;
        }

        public double Measure() => RandomPool.NextDouble(_min, _max);

    }
}