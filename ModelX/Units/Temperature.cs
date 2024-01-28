using System;
using Newtonsoft.Json;

namespace ModelX.Units
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Temperature : IUnit
    {
        public Temperature() { }
        public Temperature(double value) : this(value, Type.Temperature.Celsius) { }
    
        public Temperature(double value, Enum type)
        {
            Celsius = type switch
            {
                Type.Temperature.Kelvin => value - 273.15d,
                Type.Temperature.Fahrenheit => (value - 32d) * 5 / 9,
                Type.Temperature.Rankine => (value - 273.15d) * 5 / 9,
                Type.Temperature.Newton => value / 0.33d,
                Type.Temperature.Romer => (value - 7.5d) * 40 / 21,
                Type.Temperature.Reaumur => value * 5d / 4,
                Type.Temperature.Delisle => 100 - value * 2 / 3,
                _ => value
            };
        }

        [JsonProperty]
        public double Celsius { get; set; } = 0d;
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


        public double Result<T>(T type) where T : Enum
        {
            return type switch
            {
                Type.Temperature.Celsius    => Celsius,
                Type.Temperature.Kelvin     => Kelvin,
                Type.Temperature.Fahrenheit => Fahrenheit,
                Type.Temperature.Rankine    => Rankine,
                Type.Temperature.Newton     => Newton,
                Type.Temperature.Romer      => Romer,
                Type.Temperature.Reaumur    => Reaumur,
                Type.Temperature.Delisle    => Delisle,
                _ => 0
            };

        }
    }
}
