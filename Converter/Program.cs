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

            Setting.Load("/run/media/neko/files/ModelX/Tests/bin/Debug/net8.0/Setting.json");
            using (StreamWriter w = new("./Setting.json", false))
            {
                w.Write(
                    JsonConvert.SerializeObject(new Setting(), Formatting.Indented)
                );
            }
        }
    }
}