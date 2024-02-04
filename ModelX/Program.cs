using ModelX.Measure;

namespace ModelX
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Converter<Area> res = new (2*3.141592653589793d, Measure.Type.Area.Acre, Measure.Type.Area.SquareKilometer);
            res.SerializeMeasure();
            res.SwapUnit();
            res.SerializeMeasure();
        }
    }
}