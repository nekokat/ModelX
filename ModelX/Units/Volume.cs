using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelX.Units
{
    [JsonObject(MemberSerialization.OptIn)]
    class Volume : IUnit
    {
        public Volume() { }

        public Volume(double value, Type.Volume type)
        {
            Scale = type switch
            {
                Type.Volume.Litre           => Litre,
                Type.Volume.CubicDecimetre  => CubicDecimetre,
                Type.Volume.CubicMetre      => CubicMetre,
                Type.Volume.CubicCentimetre => CubicCentimetre,
                Type.Volume.CubicInch       => CubicInch,
                Type.Volume.BarrelOil       => BarrelOil,
                Type.Volume.USGallon        => USGallon,
                Type.Volume.USPint          => USPint,
                Type.Volume.USFluidOunce    => USFluidOunce,
                Type.Volume.CubicFoot       => CubicFoot,
                _ => 1
            };

            CubicMetre = value / Scale;
        }

        double Scale { get; set; }
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
        public double Result<T>(T type) where T : Enum
        {
            return type switch
            {
                Type.Volume.Litre           => Litre,
                Type.Volume.CubicDecimetre  => CubicDecimetre,
                Type.Volume.CubicMetre      => CubicMetre,
                Type.Volume.CubicCentimetre => CubicCentimetre,
                Type.Volume.CubicInch       => CubicInch,
                Type.Volume.BarrelOil       => BarrelOil,
                Type.Volume.USGallon        => USGallon,
                Type.Volume.USPint          => USPint,
                Type.Volume.USFluidOunce    => USFluidOunce,
                Type.Volume.CubicFoot       => CubicFoot,
                _ => 1
            };
        }
    }

}