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
            Scale = type switch
            {
                Type.Length.KiloMeter => KiloMeter,
                Type.Length.HectoMeter => HectoMeter,
                Type.Length.DecaMeter => DecaMeter,
                Type.Length.Meter => Meter,
                Type.Length.DeciMeter => DeciMeter,
                Type.Length.CentiMeter => CentiMeter,
                Type.Length.MilliMeter => MilliMeter,
                Type.Length.Foot => Foot,
                Type.Length.Inch => Inch,
                Type.Length.Hand => Hand,
                Type.Length.Yard => Yard,
                Type.Length.Chain => Chain,
                Type.Length.Furlong => Furlong,
                Type.Length.Mile => Mile,
                Type.Length.League => League,
                _ => 1
            };

            Meter = value / Scale;
        }

        double Scale { get; set; }
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
        public double Inch => Foot / 12;
        [JsonProperty]
        public double Hand => Foot / 3;
        [JsonProperty]
        public double Yard => 3 * Foot;
        [JsonProperty]
        public double Chain => 66 * Foot;
        [JsonProperty]
        public double Furlong => 220 * Yard;
        [JsonProperty]
        public double Mile => 1760 * Yard;
        [JsonProperty]
        public double League => (3 * Mile);

        public double Result<T>(T type) where T : Enum
        {
            return type switch
            {
                Type.Length.KiloMeter => KiloMeter,
                Type.Length.HectoMeter => HectoMeter,
                Type.Length.DecaMeter => DecaMeter,
                Type.Length.Meter => Meter,
                Type.Length.DeciMeter => DeciMeter,
                Type.Length.CentiMeter => CentiMeter,
                Type.Length.MilliMeter => MilliMeter,
                Type.Length.Foot => Foot,
                Type.Length.Inch => Inch,
                Type.Length.Hand => Hand,
                Type.Length.Yard => Yard,
                Type.Length.Chain => Chain,
                Type.Length.Furlong => Furlong,
                Type.Length.Mile => Mile,
                Type.Length.League => League,
                _ => 0
            };
        }
    }
}