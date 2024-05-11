namespace Measure
{
    public interface IMeasure
    {
        public decimal Result<T>(T unit) where T : Enum;
    }
}
