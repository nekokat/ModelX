using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ModelX.Units
{
    [JsonObject(MemberSerialization.OptIn)]
    public readonly struct Length
    {
        //Metric
        [JsonProperty]
        public static readonly double KiloMeter = 1000d;
        [JsonProperty]
        public static readonly double HectoMeter = 100d;
        [JsonProperty]
        public static readonly double DecaMeter = 10d;
        [JsonProperty]
        public static readonly double Meter = 1d;
        [JsonProperty]
        public static readonly double DeciMeter = 1e-1d;
        [JsonProperty]
        public static readonly double CentiMeter = 1e-2d;
        [JsonProperty]
        public static readonly double MilliMeter = 1e-3d;
        [JsonProperty]
        public static readonly double Km = KiloMeter;
        [JsonProperty]
        public static readonly double Hm = HectoMeter;
        [JsonProperty]
        public static readonly double Dam = DecaMeter;
        [JsonProperty]
        public static readonly double M = Meter;
        [JsonProperty]
        public static readonly double Dm = DeciMeter;
        [JsonProperty]
        public static readonly double Cm = CentiMeter;
        [JsonProperty]
        public static readonly double Mm = MilliMeter;
        //Imperial
        [JsonProperty]
        public static readonly double Foot = 0.3048d;
        [JsonProperty]
        public static readonly double Inch = Foot / 12;
        [JsonProperty]
        public static readonly double Hand = Foot / 3;
        [JsonProperty]
        public static readonly double Yard = 3 * Foot;
        [JsonProperty]
        public static readonly double Chain = 66 * Foot;
        [JsonProperty]
        public static readonly double Furlong = 220 * Yard;
        [JsonProperty]
        public static readonly double Mile = 1760 * Yard;
        [JsonProperty]
        public static readonly double League = 3 * Mile;
        [JsonProperty]
        public static readonly double ft = Foot;
    }
}
