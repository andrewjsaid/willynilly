namespace WillyNilly
{
    public interface IRandomVariable<out T>
    {
        T Measure();
    }
}
