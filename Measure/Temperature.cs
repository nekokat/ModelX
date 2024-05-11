using System;
using Newtonsoft.Json;

namespace Measure
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Temperature : IMeasure
    {
        public Temperature() { }
        public Temperature(decimal value) : this(value, UnitTemperature.Celsius) { }
    
        public Temperature(decimal value, Enum unit)
        {
            Celsius = unit switch
            {
                UnitTemperature.Celsius    => value,
                UnitTemperature.Kelvin     => value - 273.15m,
                UnitTemperature.Fahrenheit => (value - 32) * 5 / 9,
                UnitTemperature.Rankine    => (value - 273.15m) * 5 / 9,
                UnitTemperature.Newton     => value / 0.33m,
                UnitTemperature.Romer      => (value - 7.5m) * 40m / 21m,
                UnitTemperature.Reaumur    => value * 5 / 4,
                UnitTemperature.Delisle    => 100 - value * 2 / 3,
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
                UnitTemperature.Celsius    => Celsius,
                UnitTemperature.Kelvin     => Kelvin,
                UnitTemperature.Fahrenheit => Fahrenheit,
                UnitTemperature.Rankine    => Rankine,
                UnitTemperature.Newton     => Newton,
                UnitTemperature.Romer      => Romer,
                UnitTemperature.Reaumur    => Reaumur,
                UnitTemperature.Delisle    => Delisle,
                _ => throw new NotSupportedException()
            };

        }
    }
}
