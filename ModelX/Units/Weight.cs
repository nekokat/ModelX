using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelX.Units
{
    [JsonObject(MemberSerialization.OptIn)]
    class Weight :IUnit
    {
        public Weight() { }

        public Weight(double value, Enum type)
        {
            Scale = type switch
            {
                Type.Weight.Gigatonne   => Gigatonne,
                Type.Weight.Megatonne   => Megatonne,
                Type.Weight.Tonne       => Tonne,
                Type.Weight.Kilogramm   => Kilogramm,
                Type.Weight.Gramm       => Gramm,
                Type.Weight.Milligramm  => Milligramm,
                Type.Weight.Microgram   => Microgram,
                Type.Weight.Nanogram    => Nanogram,
                Type.Weight.Picogram    => Picogram,
                //Imperial
                Type.Weight.USton       => USton,
                Type.Weight.UKton       => UKton,
                Type.Weight.Pound       => Pound,
                Type.Weight.Ounce       => Ounce,
                _ => 0
            };

            Gramm = value / Scale;
        }

        double Scale { get; set; }

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

        public double Result<T>(T type) where T : Enum
        {
            return type switch
            {
                Type.Weight.Gigatonne   => Gigatonne,
                Type.Weight.Megatonne   => Megatonne,
                Type.Weight.Tonne       => Tonne,
                Type.Weight.Kilogramm   => Kilogramm,
                Type.Weight.Gramm       => Gramm,
                Type.Weight.Milligramm  => Milligramm,
                Type.Weight.Microgram   => Microgram,
                Type.Weight.Nanogram    => Nanogram,
                Type.Weight.Picogram    => Picogram,
                //Imperial
                Type.Weight.USton       => USton,
                Type.Weight.UKton       => UKton,
                Type.Weight.Pound       => Pound,
                Type.Weight.Ounce       => Ounce,
                _ => 0
            };
        }
    }
}
