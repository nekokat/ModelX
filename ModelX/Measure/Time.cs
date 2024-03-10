using System;
using Newtonsoft.Json;

namespace ModelX.Measure
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
                Unit.Time.Millisecond   => Millisecond,
                Unit.Time.Second        => Second,
                Unit.Time.Minute        => Minute,
                Unit.Time.Kilosecond    => Kilosecond,
                Unit.Time.Hour          => Hour,
                Unit.Time.Day           => Day,
                Unit.Time.Week          => Week,
                Unit.Time.Megasecond    => Megasecond,
                _ => throw new NotSupportedException()
            };
        }
    }
}