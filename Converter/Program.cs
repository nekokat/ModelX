using System;
using Converter.Measure;
using Settings;
using Characteristics;
using System.IO;
using Newtonsoft.Json;

namespace Converter
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
            //Converter<Temperature> res = new (90.0m, Measure.Unit.Temperature.Celsius, Measure.Unit.Temperature.Fahrenheit);
            //res.SerializeMeasure();
            Secondary res = new();
            BasicLift.Generate();
        }
    }
}