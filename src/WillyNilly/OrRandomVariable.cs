namespace WillyNilly
{
    public class OrRandomVariable<T> : IRandomVariable<T>
    {
        private readonly IRandomVariable<T>[] _inputs;

        public OrRandomVariable(IRandomVariable<T>[] inputs)
        {
            _inputs = inputs;
        }

        public T Measure()
        {
            var source = _inputs[RandomPool.NextInt(0, _inputs.Length)];
            return source.Measure();
        }

    }
}
