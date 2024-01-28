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
        public Weight()
        {
            
        }

        public Weight(double value, Enum type)
        {
            
        }

        //Metric
        [JsonProperty]
        public static readonly double gigatonne = 1e15d;
        [JsonProperty]
        public static readonly double megatonne = 1e12d;
        [JsonProperty]
        public static readonly double tonne = 1e6d;
        [JsonProperty]
        public static readonly double kilogramm = 1e3d;
        [JsonProperty]
        public static readonly double gramm = 1d;
        [JsonProperty]
        public static readonly double milligramm = 1e-3d;
        [JsonProperty]
        public static readonly double microgram = 1e-6d;
        [JsonProperty]
        public static readonly double nanogram = 1e-12d;
        [JsonProperty]
        public static readonly double picogram = 1e-15d;
        //Imperial
        [JsonProperty]
        public static readonly double USton = 0.907d * tonne;
        [JsonProperty]
        public static readonly double UKton = 1.016d * tonne;
        [JsonProperty]
        public static readonly double pound = 453.59d;
        [JsonProperty]
        public static readonly double ounce = 28.35d;

        public double Result<T>(T type) where T : Enum
        {
            throw new NotImplementedException();
        }
    }
}
