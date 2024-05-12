using Newtonsoft.Json;
using System;
using Measure;
using System.IO;

namespace Converter
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

        public void ToJson()
        {
            using (StreamWriter writer = new("./Converter.json", false))
            {
                string json = JsonConvert.SerializeObject(Measure, Formatting.Indented);
                writer.Write(json);
            }
        }
    }
}