using Newtonsoft.Json;
using System;
using ModelX.Units;

namespace ModelX
{
    class Converter
    {

        public Converter(double value, IUnit unit, double inputUnit, double outUnit)

        {
            Value = value;
            Unit = unit;
            Input = inputUnit;
            Output = outUnit;
        }

        public Converter(double value, Units.Type.Temperature inputUnit, Units.Type.Temperature outUnit)
        {
            Value = value;
            Unit = new Units.Temperature(Value, inputUnit);
            Input = Unit.Result(inputUnit);
            Output = Unit.Result(outUnit);
        }

        public double Value { get; set; }
        public IUnit Unit{ get; set; }
        public double Input { get; set; }
        public double Output { get; set; }

        public double Result()
        {
            if(Unit is Temperature)
                return Output;
            return Value * Input / Output;
        }

        public void SerializeUnit()
        {
            List<System.Type> types = new(){typeof(Volume), typeof(Area), typeof(Time), typeof(Weight), typeof(Length), typeof(Temperature)};
            TextWriter? writer = null;
            try
            {
                writer = new StreamWriter("Converter.json", true);
                foreach (var d in types)
                {
                    var data = Activator.CreateInstance(d);
                    var json = JsonConvert.SerializeObject(data, Formatting.Indented);
                    writer.Write(json+"\n");
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