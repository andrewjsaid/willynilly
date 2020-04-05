namespace WillyNilly.Variables
{
    /// <summary>
    /// Returns doubles in uniform distribution
    /// </summary>
    internal sealed class FloatUniformVariable : IRandomVariable<float>
    {
        private readonly IRandomSource _source;
        private readonly float _min;
        private readonly float _max;

        public FloatUniformVariable(IRandomSource source, float inclusiveMin, float exclusiveMax)
        {
            _source = source;
            _min = inclusiveMin;
            _max = exclusiveMax;
        }

        public float Measure() => (float)_source.NextDouble(_min, _max);

    }
}