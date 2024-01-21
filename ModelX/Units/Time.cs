using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ModelX.Units
{
    [JsonObject(MemberSerialization.OptIn)]
    public readonly struct Time
    {
        [JsonProperty]
        public static readonly double Millisecond = 1e-3d;
        [JsonProperty]
        public static readonly double Second = 1d;
        [JsonProperty]
        public static readonly double Minute = 60d;
        [JsonProperty]
        public static readonly double Kilosecond = 1e3d;
        [JsonProperty]
        public static readonly double Hour = 60d * Minute;
        [JsonProperty]
        public static readonly double Day = 24d * Hour;
        [JsonProperty]
        public static readonly double Week = 7d * Day;
        [JsonProperty]
        public static readonly double Megasecond = 1e6d;
    }
}
