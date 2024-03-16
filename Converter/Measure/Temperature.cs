using System;
using Newtonsoft.Json;

namespace Converter.Measure
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Temperature : IMeasure
    {
        public Temperature() { }
        public Temperature(decimal value) : this(value, Unit.Temperature.Celsius) { }
    
        public Temperature(decimal value, Enum unit)
        {
            Celsius = unit switch
            {
                Unit.Temperature.Celsius    => value,
                Unit.Temperature.Kelvin     => value - 273.15m,
                Unit.Temperature.Fahrenheit => (value - 32) * 5 / 9,
                Unit.Temperature.Rankine    => (value - 273.15m) * 5 / 9,
                Unit.Temperature.Newton     => value / 0.33m,
                Unit.Temperature.Romer      => (value - 7.5m) * 40m / 21m,
                Unit.Temperature.Reaumur    => value * 5 / 4,
                Unit.Temperature.Delisle    => 100 - value * 2 / 3,
                _ => throw new NotSupportedException()
            };
        }

        [JsonProperty]
        public decimal Celsius { get; set; } = 0;
        [JsonProperty]
        public decimal Kelvin { get => Celsius + 273.15m; }
        [JsonProperty]
        public decimal Fahrenheit { get => Celsius * (9 / 5) + 32; }
        [JsonProperty]
        public decimal Rankine { get => Kelvin * (9m / 5m); }
        [JsonProperty]
        public decimal Newton { get => 0.33m * Celsius; }
        [JsonProperty]
        public decimal Romer { get => Celsius * 21m / 40m + 7.5m; }
        [JsonProperty]
        public decimal Reaumur { get => 0.8m * Celsius; }
        [JsonProperty]
        public decimal Delisle { get => (100 - Celsius) * 3m / 2; }

        public decimal Result<T>(T unit) where T : Enum
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
