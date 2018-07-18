namespace WillyNilly
{
    public class UniformVariable : IRandomVariable<int>
    {
        private readonly int _min;
        private readonly int _max;

        public UniformVariable(int min, int max)
        {
            _min = min;
            _max = max;
        }

        public int Sample() => RandomPool.NextInt(_min, _max);

    }
}