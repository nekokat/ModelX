using Newtonsoft.Json;
using System;
using ModelX.Units;

namespace ModelX
{
    class Converter<TUnit> where TUnit : IUnit, new()
    {
        public Converter(double value, Enum inputMeasure, Enum outputMeasure)
        {
            Value = value;
            InputMeasure = inputMeasure;
            OutputMeasure = outputMeasure;
            Unit = (TUnit)Activator.CreateInstance(typeof(TUnit), value, inputMeasure);
            InputValue = Unit.Result(inputMeasure);
            OutputValue = Unit.Result(outputMeasure);
        }

        public Enum InputMeasure { get; set; }
        public Enum OutputMeasure { get; set; }
        public double Value { get; set; }
        public TUnit Unit { get; set; }
        public double InputValue { get; set; }
        public double OutputValue { get; set; }

        public double Result()
        {
            return OutputValue;
        }

        public override string ToString()
        {
            return $"{InputValue} {InputMeasure} = {OutputValue} {OutputMeasure}";
        }

        public void SerializeUnit()
        {
            TextWriter? writer = null;

            try
            {
                writer = new StreamWriter("Converter.json", true);
                var json = JsonConvert.SerializeObject(Unit, Formatting.Indented);
                writer.Write(this.ToString() + "\n");
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