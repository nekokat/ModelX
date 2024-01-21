using System;
using Newtonsoft.Json;

namespace ModelX.Units
{
    [JsonObject(MemberSerialization.OptIn)]
    public struct Temperature : IUnit
    {
        public Temperature(double value) : this(value, Type.Temperature.Celsius) { }
    
        public Temperature(double value, Type.Temperature type)
        {
            Celsius = ((int)type) switch
            {
                1 => value - 273.15d,
                2 => (value - 32d) * 5 / 9,
                3 => (value - 273.15d) * 5 / 9,
                4 => value / 0.33d,
                5 => (value - 7.5d) * 40 / 21,
                6 => value * 5d / 4,
                7 => 100 - value * 2 / 3,
                _ => value
            };
        }

        [JsonProperty]
        public double Celsius { get; set; }
        [JsonProperty]
        public double Kelvin { get => Celsius + 273.15d; }
        [JsonProperty]
        public double Fahrenheit { get => Celsius * (9d / 5) + 32d; }
        [JsonProperty]
        public double Rankine { get => Kelvin * (9d / 5); }
        [JsonProperty]
        public double Newton { get => 0.33d * Celsius; }
        [JsonProperty]
        public double Romer { get => Celsius * 21d / 40 + 7.5; }
        [JsonProperty]
        public double Reaumur { get => 0.8d * Celsius; }
        [JsonProperty]
        public double Delisle { get => (100 - Celsius) * 3d / 2; }
        //Aliases
        public double C { get => Celsius; }
        public double K { get => Kelvin; }
        public double F { get => Fahrenheit; }
        public double R { get => Rankine; }
        public double N { get => Newton; }
        public double Ro { get => Romer; }
        public double Re { get => Reaumur; }
        public double De { get => Delisle; }

        public double Result(Type.Temperature type)
        {
            return ((int)type) switch
            {
                0 => Celsius,
                1 => Kelvin,
                2 => Fahrenheit,
                3 => Rankine,
                4 => Newton,
                5 => Romer,
                6 => Reaumur,
                7 => Delisle,
                _ => 0
            };
        }

        public double Result()
        {
            return Result(Type.Temperature.Celsius);
        }
    }
}
