using System;
using Newtonsoft.Json;

namespace Measure
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Length : IMeasure
    {
        public Length() { }

        public Length(decimal value, Enum unit)
        {
            Meter = value / Result(unit);
        }

        //Metric
        [JsonProperty]
        public decimal KiloMeter => Meter / 1000m;
        [JsonProperty]
        public decimal HectoMeter => Meter / 100m;
        [JsonProperty]
        public decimal DecaMeter => Meter / 10m;
        [JsonProperty]
        public decimal Meter { get; set; } = 1m;
        [JsonProperty]
        public decimal DeciMeter => Meter / 1e-1m;
        [JsonProperty]
        public decimal CentiMeter => Meter / 1e-2m;
        [JsonProperty]
        public decimal MilliMeter => Meter / 1e-3m;
        //Imperial
        [JsonProperty]
        public decimal Foot => Meter / 0.3048m; 
        [JsonProperty]
        public decimal Inch => 12m*Foot;
        [JsonProperty]
        public decimal Hand => 3m*Foot;
        [JsonProperty]
        public decimal Yard => Foot / 3 ;
        [JsonProperty]
        public decimal Chain => Foot / 66;
        [JsonProperty]
        public decimal Furlong => Yard / 220 ;
        [JsonProperty]
        public decimal Mile => Yard / 1760 ;
        [JsonProperty]
        public decimal League => Mile / 3;

        public decimal Result<T>(T unit) where T : Enum
        {
            return unit switch
            {
                UnitLength.KiloMeter   => KiloMeter,
                UnitLength.HectoMeter  => HectoMeter,
                UnitLength.DecaMeter   => DecaMeter,
                UnitLength.Meter       => Meter,
                UnitLength.DeciMeter   => DeciMeter,
                UnitLength.CentiMeter  => CentiMeter,
                UnitLength.MilliMeter  => MilliMeter,
                UnitLength.Foot        => Foot,
                UnitLength.Inch        => Inch,
                UnitLength.Hand        => Hand,
                UnitLength.Yard        => Yard,
                UnitLength.Chain       => Chain,
                UnitLength.Furlong     => Furlong,
                UnitLength.Mile        => Mile,
                UnitLength.League      => League,
                _ => throw new NotSupportedException()
            };
        }
    }
}