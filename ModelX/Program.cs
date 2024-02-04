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
            Converter<Angle> res = new (180, Units.Type.Angle.Degree, Units.Type.Angle.Radian);
            Console.WriteLine(res.Result());
            res.SerializeUnit();
        }
    }
}