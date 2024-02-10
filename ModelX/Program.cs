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
            Converter<Area> res = new (180.0, Measure.Unit.Area.SquareCentimeter, Measure.Unit.Area.SquareInch);
            res.SerializeMeasure();
            res.SwapUnit();
            res.SerializeMeasure();
        }
    }
}