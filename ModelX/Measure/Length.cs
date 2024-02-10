using Newtonsoft.Json;

namespace ModelX.Measure
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Length : IMeasure
    {
        public Length() { }

        public Length(double value, Enum unit)
        {
            Meter = value / Result(unit);
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

        public double Result<T>(T unit) where T : Enum
        {
            return unit switch
            {
                Unit.Length.KiloMeter   => KiloMeter,
                Unit.Length.HectoMeter  => HectoMeter,
                Unit.Length.DecaMeter   => DecaMeter,
                Unit.Length.Meter       => Meter,
                Unit.Length.DeciMeter   => DeciMeter,
                Unit.Length.CentiMeter  => CentiMeter,
                Unit.Length.MilliMeter  => MilliMeter,
                Unit.Length.Foot        => Foot,
                Unit.Length.Inch        => Inch,
                Unit.Length.Hand        => Hand,
                Unit.Length.Yard        => Yard,
                Unit.Length.Chain       => Chain,
                Unit.Length.Furlong     => Furlong,
                Unit.Length.Mile        => Mile,
                Unit.Length.League      => League,
                _ => throw new NotSupportedException()
            };
        }
    }
}