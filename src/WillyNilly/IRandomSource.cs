namespace WillyNilly
{
    public interface IRandomSource
    {
        int NextInt(int min, int max);
        double NextDouble();
        double NextDouble(double min, double max);
    }
}
