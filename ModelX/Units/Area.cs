using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelX.Units
{
    [JsonObject(MemberSerialization.OptIn)]
    public readonly struct Area
    {
        //Mertic
        [JsonProperty]
        public static readonly double SquareKilometer = 1e6d;
        [JsonProperty]
        public static readonly double SquareHectometer = 1e4d;
        [JsonProperty]
        public static readonly double SquareDecameter = 1e2d;
        [JsonProperty]
        public static readonly double SquareMeter = 1d;
        [JsonProperty]
        public static readonly double SquareDecimeter = 1e-2d;
        [JsonProperty]
        public static readonly double SquareCentimeter = 1e-4d;
        [JsonProperty]
        public static readonly double SquareMillimeter = 1e-6d;
        //Mertic Aliases
        [JsonProperty]
        public static readonly double Hectare = SquareHectometer;
        [JsonProperty]
        public static readonly double ha = Hectare;
        [JsonProperty]
        public static readonly double Are = SquareDecameter;
        [JsonProperty]
        public static readonly double a = Are;
        [JsonProperty]
        public static readonly double Centiare = SquareMeter;
        [JsonProperty]
        public static readonly double ca = Centiare;
        //Imperial
        [JsonProperty]
        public static readonly double Perch = 30.25 * Math.Pow(Length.Yard, 2);
        [JsonProperty]
        public static readonly double Rood = 40 * Perch;
        [JsonProperty]
        public static readonly double Acre = 4 * Rood;
        [JsonProperty]
        public static readonly double SquareMile = 640 * Acre;

    }
}
