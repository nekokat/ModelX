using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelX.Units
{
    [JsonObject(MemberSerialization.OptIn)]
    public readonly struct Volume
    {
        //Metric
        [JsonProperty]
        public static readonly double Litre = 0.001d;
        [JsonProperty]
        public static readonly double CubicDecimetre = Litre;
        [JsonProperty]
        public static readonly double CubicMetre = 1d;
        [JsonProperty]
        public static readonly double CubicCentimetre = 1e-6d;
        //Imperial
        [JsonProperty]
        public static readonly double CubicInch = Math.Pow(Length.Inch, 3);
        [JsonProperty]
        public static readonly double Barrel = 9.702d * CubicInch;
        [JsonProperty]
        public static readonly double USGallon = 231 * CubicInch;
        [JsonProperty]
        public static readonly double USPint = USGallon / 8;
        [JsonProperty]
        public static readonly double USFluidOunce = USGallon / 128;
        [JsonProperty]
        public static readonly double CubicFoot = Math.Pow(Length.Foot, 3);
    }

}
