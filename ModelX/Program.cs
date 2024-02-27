using System;
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
            Converter<Temperature> res = new (90.0, Measure.Unit.Temperature.Celsius, Measure.Unit.Temperature.Fahrenheit);
            res.SerializeMeasure();
            Converter<Temperature> res1 = new(180.0, Measure.Unit.Temperature.Kelvin, Measure.Unit.Temperature.Newton);
            res1.SerializeMeasure();
            Converter<Temperature> res2 = new(360.0, Measure.Unit.Temperature.Delisle, Measure.Unit.Temperature.Reaumur);
            res2.SerializeMeasure();
        }
    }
}