namespace WillyNilly.Variables
{
    /// <summary>
    /// Returns doubles in uniform distribution.
    /// </summary>
    internal sealed class DoubleUniformVariable : IRandomVariable<double>
    {
        private readonly IRandomSource _source;
        private readonly double _min;
        private readonly double _max;

        public DoubleUniformVariable(IRandomSource source, double inclusiveMin, double exclusiveMax)
        {
            _source = source;
            _min = inclusiveMin;
            _max = exclusiveMax;
        }

        public double Measure() => _source.NextDouble(_min, _max);

    }
}