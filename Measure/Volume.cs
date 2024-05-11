using Newtonsoft.Json;
using System;

namespace Measure
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Volume : IMeasure
    {
        public Volume() { }

        public Volume(decimal value, Enum unit)
        {
            CubicMetre = value / Result(unit);
        }

        //Metric
        [JsonProperty]
        public decimal Litre { get => CubicMetre * 1e3m; }
        [JsonProperty]
        public decimal CubicDecimetre { get => Litre; }
        [JsonProperty]
        public decimal CubicMetre { get; set; } = 1m;
        [JsonProperty]
        public decimal CubicCentimetre { get => CubicMetre * 1e6m; }
        //Imperial
        [JsonProperty]
        public decimal CubicInch { get => CubicMetre / (decimal)Math.Pow(0.3048d/12, 3); }
        //public decimal CubicInch { get => CubicMetre / Math.Pow(Length.Inch, 3); }
        [JsonProperty]
        public decimal BarrelOil { get => CubicInch / 9702m; }
        [JsonProperty]
        public decimal USGallon { get => CubicInch / 231m ; }
        [JsonProperty]
        public decimal USPint { get => USGallon * 8m; }
        [JsonProperty]
        public decimal USFluidOunce { get => USGallon * 128m; }
        [JsonProperty]
        public decimal CubicFoot { get => CubicMetre / (decimal)Math.Pow(0.3048d, 3); }
        //public decimal CubicFoot { get => CubicMetre / Math.Pow(Length.Foot, 3); }
        public decimal Result<T>(T unit) where T : Enum
        {
            return unit switch
            {
                UnitVolume.Litre           => Litre,
                UnitVolume.CubicDecimetre  => CubicDecimetre,
                UnitVolume.CubicMetre      => CubicMetre,
                UnitVolume.CubicCentimetre => CubicCentimetre,
                UnitVolume.CubicInch       => CubicInch,
                UnitVolume.BarrelOil       => BarrelOil,
                UnitVolume.USGallon        => USGallon,
                UnitVolume.USPint          => USPint,
                UnitVolume.USFluidOunce    => USFluidOunce,
                UnitVolume.CubicFoot       => CubicFoot,
                _ => throw new NotSupportedException()
            };
        }
    }

}