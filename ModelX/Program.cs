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
            Converter<Weight> res = new (1296, Units.Type.Weight.Kilogramm, Units.Type.Weight.Tonne);
            Console.WriteLine(res.Result());
            res.SerializeUnit();
        }
    }
}