using System;
using Newtonsoft.Json;

namespace ModelX.Measure
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Temperature : IMeasure
    {
        public Temperature() { }
        public Temperature(double value) : this(value, Unit.Temperature.Celsius) { }
    
        public Temperature(double value, Enum unit)
        {
            Celsius = unit switch
            {
                Unit.Temperature.Celsius    => value,
                Unit.Temperature.Kelvin     => value - 273.15d,
                Unit.Temperature.Fahrenheit => (value - 32d) * 5 / 9,
                Unit.Temperature.Rankine    => (value - 273.15d) * 5 / 9,
                Unit.Temperature.Newton     => value / 0.33d,
                Unit.Temperature.Romer      => (value - 7.5d) * 40 / 21,
                Unit.Temperature.Reaumur    => value * 5d / 4,
                Unit.Temperature.Delisle    => 100 - value * 2 / 3,
                _ => throw new NotSupportedException()
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

        public double Result<T>(T unit) where T : Enum
        {
            return unit switch
            {
                Unit.Temperature.Celsius    => Celsius,
                Unit.Temperature.Kelvin     => Kelvin,
                Unit.Temperature.Fahrenheit => Fahrenheit,
                Unit.Temperature.Rankine    => Rankine,
                Unit.Temperature.Newton     => Newton,
                Unit.Temperature.Romer      => Romer,
                Unit.Temperature.Reaumur    => Reaumur,
                Unit.Temperature.Delisle    => Delisle,
                _ => throw new NotSupportedException()
            };

        }
    }
}
