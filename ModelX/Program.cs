using ModelX.Units;

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
            Converter<Volume> res = new (1, Units.Type.Volume.Litre, Units.Type.Volume.CubicFoot);
            res.SerializeUnit();
        }
    }
}