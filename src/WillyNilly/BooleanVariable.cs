namespace WillyNilly
{
    public class BooleanVariable : IRandomVariable<bool>
    {
        private readonly double _prob;

        public BooleanVariable() : this(0.5) { }

        public BooleanVariable(double prob)
        {
            _prob = prob;
        }

        public bool Measure() => RandomPool.NextDouble() < _prob;
    }
}
