using Newtonsoft.Json;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace ModelX.Measure
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Area : IMeasure
    {
        public Area(){}

        public Area(double value, Enum unit)
        {
            SquareMeter = value / Result(unit);
        }

        //Mertic
        [JsonProperty]
        public double SquareKilometer { get => SquareMeter / 1e6d; }
        [JsonProperty]
        public double SquareHectometer { get => SquareMeter / 1e4d; }
        [JsonProperty]
        public double SquareDecameter { get => SquareMeter / 1e2d; }
        [JsonProperty]
        public double SquareMeter { get; set; } = 1d;
        [JsonProperty]
        public double SquareDecimeter { get => SquareMeter / 1e-2d; }
        [JsonProperty]
        public double SquareCentimeter { get => SquareMeter / 1e-4d; }
        [JsonProperty]
        public double SquareMillimeter { get => SquareMeter / 1e-6d; }
        //Imperial
        [JsonProperty]
        public double Perch { get => SquareYard / 30.25; }
        [JsonProperty]
        public double Rood { get => Perch / 40; }
        [JsonProperty]
        public double Acre { get => Rood / 4; }
        [JsonProperty]
        public double SquareMile { get => Acre / 640; }
        [JsonProperty]
        public double SquareYard { get => SquareFoot / 9; }
        [JsonProperty]
        public double SquareFoot { get => SquareMeter / Math.Pow(0.3048d, 2); }

        [JsonProperty]
        public double SquareInch { get => 144 * SquareFoot; }

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

        public double Result<T>(T unit) where T : Enum
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