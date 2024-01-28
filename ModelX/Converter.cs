using Newtonsoft.Json;
using System;
using ModelX.Units;

namespace ModelX
{
    class Converter<TUnit> where TUnit : IUnit, new()
    {
        public Converter(double value, Enum inputUnit, Enum outUnit)
        {
            Value = value;
            Unit = (TUnit)Activator.CreateInstance(typeof(TUnit), value, inputUnit);
            Input = Unit.Result(inputUnit);
            Output = Unit.Result(outUnit);
        }

        public double Value { get; set; }
        public TUnit Unit { get; set; }
        public double Input { get; set; }
        public double Output { get; set; }

        public double Result()
        {
            if (Unit is Temperature)
                return Output;
            return Value * Input / Output;
        }

        public void SerializeUnit()
        {
            //List<System.Type> types = new() { typeof(Volume), typeof(Area), typeof(Time), typeof(Weight), typeof(Length), typeof(Temperature), typeof(Angle) };
            List<System.Type> types = new() { typeof(Angle) };

            TextWriter? writer = null;
            try
            {
                writer = new StreamWriter("Converter.json", true);
                foreach (var d in types)
                {
                    var data = this.Unit;
                    var json = JsonConvert.SerializeObject(data, Formatting.Indented);
                    writer.Write(json + "\n");
                }
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
    }
}