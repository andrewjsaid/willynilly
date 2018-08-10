namespace WillyNilly
{
    /// <summary>
    /// Returns integers in uniform distribution
    /// </summary>
    public class UniformIntegerVariable : IRandomVariable<int>
    {
        private readonly int _min;
        private readonly int _max;

        public UniformIntegerVariable(int inclusiveMin, int exclusiveMax)
        {
            _min = inclusiveMin;
            _max = exclusiveMax;
        }

        public int Measure() => RandomPool.NextInt(_min, _max);

    }
}