using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ModelX.Units
{
    [JsonObject(MemberSerialization.OptIn)]
    class Length : IUnit
    {
        public Length() { }

        public Length(double value, Enum type)
        {
            Meter = value / Result(type);
        }

        //Metric
        [JsonProperty]
        public double KiloMeter => Meter / 1000d;
        [JsonProperty]
        public double HectoMeter => Meter / 100d;
        [JsonProperty]
        public double DecaMeter => Meter / 10d;
        [JsonProperty]
        public double Meter { get; set; } = 1d;
        [JsonProperty]
        public double DeciMeter => Meter / 1e-1d;
        [JsonProperty]
        public double CentiMeter => Meter / 1e-2d;
        [JsonProperty]
        public double MilliMeter => Meter / 1e-3d;
        //Imperial
        [JsonProperty]
        public double Foot => Meter / 0.3048d; 
        [JsonProperty]
        public double Inch => 12*Foot;
        [JsonProperty]
        public double Hand => 3*Foot;
        [JsonProperty]
        public double Yard => Foot / 3 ;
        [JsonProperty]
        public double Chain => Foot / 66;
        [JsonProperty]
        public double Furlong => Yard / 220 ;
        [JsonProperty]
        public double Mile => Yard / 1760 ;
        [JsonProperty]
        public double League => Mile / 3;

        public double Result<T>(T type) where T : Enum
        {
            return type switch
            {
                Type.Length.KiloMeter   => KiloMeter,
                Type.Length.HectoMeter  => HectoMeter,
                Type.Length.DecaMeter   => DecaMeter,
                Type.Length.Meter       => Meter,
                Type.Length.DeciMeter   => DeciMeter,
                Type.Length.CentiMeter  => CentiMeter,
                Type.Length.MilliMeter  => MilliMeter,
                Type.Length.Foot        => Foot,
                Type.Length.Inch        => Inch,
                Type.Length.Hand        => Hand,
                Type.Length.Yard        => Yard,
                Type.Length.Chain       => Chain,
                Type.Length.Furlong     => Furlong,
                Type.Length.Mile        => Mile,
                Type.Length.League      => League,
                _ => throw new NotSupportedException()
            };
        }
    }
}