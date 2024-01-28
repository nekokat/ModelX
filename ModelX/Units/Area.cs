using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelX.Units
{
    [JsonObject(MemberSerialization.OptIn)]
    class Area : IUnit
    {
        public Area(){}

        public Area(double value, Enum type)
        {
            Scale = type switch
            {
                Type.Area.SquareKilometer => SquareKilometer,
                Type.Area.SquareHectometer => SquareHectometer,
                Type.Area.SquareDecameter => SquareDecameter,
                Type.Area.SquareMeter => SquareMeter,
                Type.Area.SquareDecimeter => SquareDecimeter,
                Type.Area.SquareCentimeter => SquareCentimeter,
                Type.Area.SquareMillimeter => SquareMillimeter,
                Type.Area.Perch => Perch,
                Type.Area.Rood => Rood,
                Type.Area.Acre => Acre,
                Type.Area.SquareMile => SquareMile,
                Type.Area.SquareYard => SquareYard,
                Type.Area.SquareFoot => SquareFoot,
                Type.Area.SquareInch => SquareInch,
                _ => 1
            };

            SquareMeter = value / Scale;
        }

        double Scale { get; set; }

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

        public double Result<T>(T type) where T : Enum
        {
            return type switch
            {
                Type.Area.SquareKilometer => SquareKilometer,
                Type.Area.SquareHectometer => SquareHectometer,
                Type.Area.SquareDecameter => SquareDecameter,
                Type.Area.SquareMeter => SquareMeter,
                Type.Area.SquareDecimeter => SquareDecimeter,
                Type.Area.SquareCentimeter => SquareCentimeter,
                Type.Area.SquareMillimeter => SquareMillimeter,
                Type.Area.Perch => Perch,
                Type.Area.Rood => Rood,
                Type.Area.Acre => Acre,
                Type.Area.SquareMile => SquareMile,
                Type.Area.SquareYard => SquareYard,
                Type.Area.SquareFoot => SquareFoot,
                Type.Area.SquareInch => SquareInch,
                _ => 0
            };
        }
    }
}