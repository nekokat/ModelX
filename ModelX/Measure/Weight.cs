using Newtonsoft.Json;

namespace ModelX.Measure
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Weight : IMeasure
    {
        public Weight() { }

        public Weight(double value, Enum unit)
        {
            Gramm = value / Result(unit);
        }

        //Metric
        [JsonProperty]
        public double Gigatonne => Gramm / 1e15d;
        [JsonProperty]
        public double Megatonne => Gramm / 1e12d;
        [JsonProperty]
        public double Tonne => Gramm / 1e6d;
        [JsonProperty]
        public double Kilogramm => Gramm / 1e3d;
        [JsonProperty]
        public double Gramm { get; set; } = 1d;
        [JsonProperty]
        public double Milligramm => Gramm / 1e-3d;
        [JsonProperty]
        public double Microgram => Gramm / 1e-6d;
        [JsonProperty]
        public double Nanogram => Gramm / 1e-12d;
        [JsonProperty]
        public double Picogram => Gramm / 1e-15d;
        //Imperial
        [JsonProperty]
        public double USton => Tonne / 0.907d;
        [JsonProperty]
        public double UKton => Tonne / 1.016d ;
        [JsonProperty]
        public double Pound => Gramm / 453.59d;
        [JsonProperty]
        public double Ounce => Gramm / 28.35d;

        public double Result<T>(T unit) where T : Enum
        {
            return unit switch
            {
                Unit.Weight.Gigatonne   => Gigatonne,
                Unit.Weight.Megatonne   => Megatonne,
                Unit.Weight.Tonne       => Tonne,
                Unit.Weight.Kilogramm   => Kilogramm,
                Unit.Weight.Gramm       => Gramm,
                Unit.Weight.Milligramm  => Milligramm,
                Unit.Weight.Microgram   => Microgram,
                Unit.Weight.Nanogram    => Nanogram,
                Unit.Weight.Picogram    => Picogram,
                //Imperial
                Unit.Weight.USton       => USton,
                Unit.Weight.UKton       => UKton,
                Unit.Weight.Pound       => Pound,
                Unit.Weight.Ounce       => Ounce,
                _ => throw new NotSupportedException()
            };
        }
    }
}
