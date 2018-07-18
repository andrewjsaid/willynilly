namespace WillyNilly
{
    public class CoVariables<T1, T2> : IRandomVariable<(T1, T2)>
    {
        private readonly IRandomVariable<T1> _a;
        private readonly IRandomVariable<T2> _b;

        public CoVariables(IRandomVariable<T1> a, IRandomVariable<T2> b)
        {
            _a = a;
            _b = b;
        }

        public (T1, T2) Sample() => (_a.Sample(), _b.Sample());
    }

    public class CoVariables<T1, T2, T3> : IRandomVariable<(T1, T2, T3)>
    {
        private readonly IRandomVariable<T1> _a;
        private readonly IRandomVariable<T2> _b;
        private readonly IRandomVariable<T3> _c;

        public CoVariables(IRandomVariable<T1> a, IRandomVariable<T2> b, IRandomVariable<T3> c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public (T1, T2, T3) Sample() => (_a.Sample(), _b.Sample(), _c.Sample());
    }
}
