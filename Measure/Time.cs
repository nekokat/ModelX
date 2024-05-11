using System;
using Newtonsoft.Json;

namespace Measure
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Time : IMeasure
    {
        public Time() { }

        public Time(decimal value, Enum unit)
        {
            Second = value / Result(unit);
        }

        [JsonProperty]
        public decimal Millisecond { get => Second * 1e3m; }
        [JsonProperty]
        public decimal Second { get; set; } = 1m;
        [JsonProperty]
        public decimal Minute { get => Second / 60m; }
        [JsonProperty]
        public decimal Kilosecond { get => Second / 1e3m; }
        [JsonProperty]
        public decimal Hour { get => Minute / 60m; }
        [JsonProperty]
        public decimal Day { get => Hour / 24; }
        [JsonProperty]
        public decimal Week { get => Day / 7; }
        [JsonProperty]
        public decimal Megasecond { get => Second / 1e6m; }

        public decimal Result<T>(T unit) where T : Enum
        {
            return unit switch {
                UnitTime.Millisecond   => Millisecond,
                UnitTime.Second        => Second,
                UnitTime.Minute        => Minute,
                UnitTime.Kilosecond    => Kilosecond,
                UnitTime.Hour          => Hour,
                UnitTime.Day           => Day,
                UnitTime.Week          => Week,
                UnitTime.Megasecond    => Megasecond,
                _ => throw new NotSupportedException()
            };
        }
    }
}