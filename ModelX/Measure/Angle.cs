using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace ModelX.Measure
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Angle : IMeasure
    {
        public Angle() { }

        public Angle(double value, Enum unit)
        {
            Degree = value / Result(unit);
        }

        [JsonProperty]
        public double Radian { get => this.Degree * Math.PI / 180d; }
        [JsonProperty]
        public double Degree { get; set; } = 1d;
        [JsonProperty]
        public double Turn { get => this.Degree / 360d; }
        [JsonProperty]
        public double Gradian { get => this.Degree * 400d / 360; }

        public new bool Equals(object x, object y)
        {
            return x is Angle && y is Angle && ((Angle)x).Degree.Equals(((Angle)y).Degree);
        }

        public double Result<T>(T unit) where T : Enum
        {
            return unit switch
            {
                Unit.Angle.Radian   => Radian,
                Unit.Angle.Degree   => Degree,
                Unit.Angle.Turn     => Turn,
                Unit.Angle.Gradian  => Gradian,
                _ => throw new NotSupportedException()
            };
        }
    }
}
