using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelX.Units
{
    [JsonObject(MemberSerialization.OptIn)]
    class Angle : IUnit
    {
        public Angle() { }
        public Angle(double value, Type.Angle type)
        {
            Scale = type switch
            {
                Type.Angle.Radian   => Radian,
                Type.Angle.Degree   => Degree,
                Type.Angle.Turn     => Turn,
                Type.Angle.Gradian  => Gradian,
                _ => 1
            };

            Degree = value / Scale;
        }

        double Scale { get; set; }

        [JsonProperty]
        public double Radian { get => this.Degree * Math.PI / 180d; }
        [JsonProperty]
        public double Degree { get; set; } = 1d;
        [JsonProperty]
        public double Turn { get => this.Degree / 360d; }
        [JsonProperty]
        public double Gradian { get => this.Degree * 400d / 360; }

        public double Result<T>(T type) where T : Enum
        {
            return type switch
            {
                Type.Angle.Radian   => Radian,
                Type.Angle.Degree   => Degree,
                Type.Angle.Turn     => Turn,
                Type.Angle.Gradian  => Gradian,
                _ => 0
            };
        }
    }
}
