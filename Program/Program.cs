using Converter;
using System;
using System.IO;
using Measure;
using Newtonsoft.Json;

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
            Converter<Temperature> res = new (100.0m, UnitTemperature.Celsius, UnitTemperature.Fahrenheit);
            res.ToJson();
        }
    }
}