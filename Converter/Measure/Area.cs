using Newtonsoft.Json;
using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace Converter.Measure
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Area : IMeasure
    {
        public Area(){}

        public Area(decimal value, Enum unit)
        {
            SquareMeter = value / Result(unit);
        }

        //Mertic
        [JsonProperty]
        public decimal SquareKilometer { get => SquareMeter / 1e6m; }
        [JsonProperty]
        public decimal SquareHectometer { get => SquareMeter / 1e4m; }
        [JsonProperty]
        public decimal SquareDecameter { get => SquareMeter / 1e2m; }
        [JsonProperty]
        public decimal SquareMeter { get; set; } = 1m;
        [JsonProperty]
        public decimal SquareDecimeter { get => SquareMeter / 1e-2m; }
        [JsonProperty]
        public decimal SquareCentimeter { get => SquareMeter / 1e-4m; }
        [JsonProperty]
        public decimal SquareMillimeter { get => SquareMeter / 1e-6m; }
        //Imperial
        [JsonProperty]
        public decimal Perch { get => SquareYard / 30.25m; }
        [JsonProperty]
        public decimal Rood { get => Perch / 40m; }
        [JsonProperty]
        public decimal Acre { get => Rood / 4m; }
        [JsonProperty]
        public decimal SquareMile { get => Acre / 640m; }
        [JsonProperty]
        public decimal SquareYard { get => SquareFoot / 9m; }
        [JsonProperty]
        public decimal SquareFoot { get => SquareMeter / 0.3048m / 0.3048m; }

        [JsonProperty]
        public decimal SquareInch { get => 144 * SquareFoot; }

        /*
        public new bool Equals(object? x, object? y)
        {            
            return x is Area && y is Area && ((Area)x).SquareMeter.Equals(((Area)y).SquareMeter);
        }

        public int GetHashCode(object obj)
        {
            throw new NotImplementedException();
        }
        */

        public decimal Result<T>(T unit) where T : Enum
        {
            return unit switch
            {
                Unit.Area.SquareKilometer   => SquareKilometer,
                Unit.Area.SquareHectometer  => SquareHectometer,
                Unit.Area.SquareDecameter   => SquareDecameter,
                Unit.Area.SquareMeter       => SquareMeter,
                Unit.Area.SquareDecimeter   => SquareDecimeter,
                Unit.Area.SquareCentimeter  => SquareCentimeter,
                Unit.Area.SquareMillimeter  => SquareMillimeter,
                Unit.Area.Perch             => Perch,
                Unit.Area.Rood              => Rood,
                Unit.Area.Acre              => Acre,
                Unit.Area.SquareMile        => SquareMile,
                Unit.Area.SquareYard        => SquareYard,
                Unit.Area.SquareFoot        => SquareFoot,
                Unit.Area.SquareInch        => SquareInch,
                _ => throw new NotSupportedException()
            };
        }
    }
}