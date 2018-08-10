namespace WillyNilly
{
    /// <summary>
    /// Returns doubles in uniform distribution
    /// </summary>
    public class UniformFloatVariable : IRandomVariable<float>
    {
        private readonly float _min;
        private readonly float _max;

        public UniformFloatVariable(float inclusiveMin, float exclusiveMax)
        {
            _min = inclusiveMin;
            _max = exclusiveMax;
        }

        public float Measure() => (float)RandomPool.NextDouble(_min, _max);

    }
}