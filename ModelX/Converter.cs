using Newtonsoft.Json;
using System;
using ModelX.Measure;
using System.IO;

namespace ModelX
{
    class Converter<TMeasure> where TMeasure : IMeasure, new()
    {
        public Converter(decimal value, Enum inputUnit, Enum outputUnit)
        {
            InputMeasure = inputUnit;
            OutputMeasure = outputUnit;
            Measure = (TMeasure)Activator.CreateInstance(typeof(TMeasure), value, inputUnit);
            InputValue = value;
            OutputValue = Measure?.Result(outputUnit);
        }

        public Enum InputMeasure { get; set; }
        public Enum OutputMeasure { get; set; }
        public TMeasure Measure { get; set; }
        public decimal? InputValue { get; set; }
        public decimal? OutputValue { get; set; }

        public decimal? Result()
        {
            return OutputValue;
        }

        //TODO: Create Converter's Swap
        public void SwapUnit()
        {
            Measure = (TMeasure)Activator.CreateInstance(typeof(TMeasure), InputValue, OutputMeasure);
            OutputValue = Measure?.Result(InputMeasure);
            (InputMeasure, OutputMeasure) = (OutputMeasure, InputMeasure);
        }

        public override string ToString()
        {
            return $"{InputValue} {InputMeasure} = {OutputValue} {OutputMeasure}";
        }

        public void SerializeMeasure()
        {
            TextWriter writer = null;

            try
            {
                writer = new StreamWriter("./Converter.json", true);
                var json = JsonConvert.SerializeObject(Measure, Formatting.Indented);
                writer.Write(json + "\n");
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
    }
}