using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ModelX.Units
{
    [JsonObject(MemberSerialization.OptIn)]
    class Time : IUnit
    {
        public Time() { }

        public Time(double value, Enum type)
        {
            Second = value / Result(type);
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

        public double Result<T>(T type) where T : Enum
        {
            return type switch {
                Type.Time.Millisecond   => Millisecond,
                Type.Time.Second        => Second,
                Type.Time.Minute        => Minute,
                Type.Time.Kilosecond    => Kilosecond,
                Type.Time.Hour          => Hour,
                Type.Time.Day           => Day,
                Type.Time.Week          => Week,
                Type.Time.Megasecond    => Megasecond,
                _ => throw new NotSupportedException()
            };
        }
    }
}