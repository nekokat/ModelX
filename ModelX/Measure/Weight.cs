using Newtonsoft.Json;
using System;

namespace ModelX.Measure
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Weight : IMeasure
    {
        public Weight() { }

        public Weight(decimal value, Enum unit)
        {
            Gramm = value / Result(unit);
        }

        //Metric
        [JsonProperty]
        public decimal Gigatonne => Gramm / 1e15m;
        [JsonProperty]
        public decimal Megatonne => Gramm / 1e12m;
        [JsonProperty]
        public decimal Tonne => Gramm / 1e6m;
        [JsonProperty]
        public decimal Kilogramm => Gramm / 1e3m;
        [JsonProperty]
        public decimal Gramm { get; set; } = 1m;
        [JsonProperty]
        public decimal Milligramm => Gramm / 1e-3m;
        [JsonProperty]
        public decimal Microgram => Gramm / 1e-6m;
        [JsonProperty]
        public decimal Nanogram => Gramm / 1e-12m;
        [JsonProperty]
        public decimal Picogram => Gramm / 1e-15m;
        //Imperial
        [JsonProperty]
        public decimal USton => Tonne / 0.907m;
        [JsonProperty]
        public decimal UKton => Tonne / 1.016m ;
        [JsonProperty]
        public decimal Pound => Gramm / 453.59m;
        [JsonProperty]
        public decimal Ounce => Gramm / 28.35m;

        public decimal Result<T>(T unit) where T : Enum
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
