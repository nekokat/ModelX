using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;


namespace Measure;

[JsonObject(MemberSerialization.OptIn)]
public class Angle : IMeasure
{
    public Angle() { }

    public Angle(decimal value, Enum unit)
    {
        Degree = value / Result(unit);
    }

    [JsonProperty]
    public decimal Radian { get => this.Degree * (decimal)Math.PI / 180m; }
    [JsonProperty]
    public decimal Degree { get; set; } = 1m;
    [JsonProperty]
    public decimal Turn { get => this.Degree / 360m; }
    [JsonProperty]
    public decimal Gradian { get => this.Degree * 400m / 360m; }

    /*
    public new bool Equals(object x, object y)
    {
        return x is Angle && y is Angle && ((Angle)x).Degree.Equals(((Angle)y).Degree);
    }
    */

    public decimal Result<T>(T unit) where T : Enum
    {
        return unit switch
        {
            UnitAngle.Radian   => Radian,
            UnitAngle.Degree   => Degree,
            UnitAngle.Turn     => Turn,
            UnitAngle.Gradian  => Gradian,
            _ => throw new NotSupportedException()
        };
    }
}
