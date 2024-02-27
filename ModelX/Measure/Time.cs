using System;
using Newtonsoft.Json;

namespace ModelX.Measure
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Time : IMeasure
    {
        public Time() { }

        public Time(double value, Enum unit)
        {
            Second = value / Result(unit);
        }

        [JsonProperty]
        public double Millisecond { get => Second * 1e3d; }
        [JsonProperty]
        public double Second { get; set; } = 1d;
        [JsonProperty]
        public double Minute { get => Second / 60d; }
        [JsonProperty]
        public double Kilosecond { get => Second / 1e3d; }
        [JsonProperty]
        public double Hour { get => Minute / 60; }
        [JsonProperty]
        public double Day { get => Hour / 24; }
        [JsonProperty]
        public double Week { get => Day / 7; }
        [JsonProperty]
        public double Megasecond { get => Second / 1e6d; }

        public double Result<T>(T unit) where T : Enum
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