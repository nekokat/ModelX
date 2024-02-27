using Newtonsoft.Json;
using System;

namespace ModelX.Measure
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Volume : IMeasure
    {
        public Volume() { }

        public Volume(double value, Enum unit)
        {
            CubicMetre = value / Result(unit);
        }

        //Metric
        [JsonProperty]
        public double Litre { get => CubicMetre * 1e3d; }
        [JsonProperty]
        public double CubicDecimetre { get => Litre; }
        [JsonProperty]
        public double CubicMetre { get; set; } = 1d;
        [JsonProperty]
        public double CubicCentimetre { get => CubicMetre * 1e6d; }
        //Imperial
        [JsonProperty]
        public double CubicInch { get => CubicMetre / Math.Pow(0.3048d/12, 3); }
        //public double CubicInch { get => CubicMetre / Math.Pow(Length.Inch, 3); }
        [JsonProperty]
        public double BarrelOil { get => CubicInch / 9702d; }
        [JsonProperty]
        public double USGallon { get => CubicInch / 231 ; }
        [JsonProperty]
        public double USPint { get => USGallon * 8; }
        [JsonProperty]
        public double USFluidOunce { get => USGallon * 128; }
        [JsonProperty]
        public double CubicFoot { get => CubicMetre / Math.Pow(0.3048d, 3); }
        //public double CubicFoot { get => CubicMetre / Math.Pow(Length.Foot, 3); }
        public double Result<T>(T unit) where T : Enum
        {
            return unit switch
            {
                Unit.Volume.Litre           => Litre,
                Unit.Volume.CubicDecimetre  => CubicDecimetre,
                Unit.Volume.CubicMetre      => CubicMetre,
                Unit.Volume.CubicCentimetre => CubicCentimetre,
                Unit.Volume.CubicInch       => CubicInch,
                Unit.Volume.BarrelOil       => BarrelOil,
                Unit.Volume.USGallon        => USGallon,
                Unit.Volume.USPint          => USPint,
                Unit.Volume.USFluidOunce    => USFluidOunce,
                Unit.Volume.CubicFoot       => CubicFoot,
                _ => throw new NotSupportedException()
            };
        }
    }

}