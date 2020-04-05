namespace WillyNilly.Variables
{
    /// <summary>
    /// Groups variables to be measured together.
    /// </summary>
    internal sealed class GroupVariables<T1, T2> : IRandomVariable<(T1, T2)>
    {
        private readonly IRandomVariable<T1> _a;
        private readonly IRandomVariable<T2> _b;

        public GroupVariables(IRandomVariable<T1> a, IRandomVariable<T2> b)
        {
            _a = a;
            _b = b;
        }

        public (T1, T2) Measure() => (_a.Measure(), _b.Measure());
    }

    /// <summary>
    /// Groups variables to be measured together.
    /// </summary>
    internal sealed class GroupVariables<T1, T2, T3> : IRandomVariable<(T1, T2, T3)>
    {
        private readonly IRandomVariable<T1> _a;
        private readonly IRandomVariable<T2> _b;
        private readonly IRandomVariable<T3> _c;

        public GroupVariables(IRandomVariable<T1> a, IRandomVariable<T2> b, IRandomVariable<T3> c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public (T1, T2, T3) Measure() => (_a.Measure(), _b.Measure(), _c.Measure());
    }
}
