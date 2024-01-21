using Newtonsoft.Json;
using System;
using ModelX.Units;

namespace ModelX
{

    [JsonObject(MemberSerialization.OptIn)]
    public readonly struct Length
    {
        //Metric
        [JsonProperty]
		public static readonly double KiloMeter = 1000d;
        [JsonProperty]
		public static readonly double HectoMeter = 100d;
        [JsonProperty]
		public static readonly double DecaMeter = 10d;
        [JsonProperty]
		public static readonly double Meter = 1d;
        [JsonProperty]
		public static readonly double DeciMeter = 1e-1d;
        [JsonProperty]
		public static readonly double CentiMeter = 1e-2d;
        [JsonProperty]
		public static readonly double MilliMeter = 1e-3d;
        [JsonProperty]
		public static readonly double Km = KiloMeter;
        [JsonProperty]
		public static readonly double Hm = HectoMeter;
        [JsonProperty]
		public static readonly double Dam = DecaMeter;
        [JsonProperty]
		public static readonly double M = Meter;
        [JsonProperty]
		public static readonly double Dm = DeciMeter;
        [JsonProperty]
		public static readonly double Cm = CentiMeter;
        [JsonProperty]
		public static readonly double Mm = MilliMeter;
        //Imperial
        [JsonProperty]
		public static readonly double Foot = 0.3048d;
        [JsonProperty]
		public static readonly double Inch = Foot / 12;
        [JsonProperty]
		public static readonly double Hand = Foot / 3;
        [JsonProperty]
		public static readonly double Yard = 3 * Foot;
        [JsonProperty]
		public static readonly double Chain = 66 * Foot;
        [JsonProperty]
		public static readonly double Furlong = 220 * Yard;
        [JsonProperty]
		public static readonly double Mile = 1760 * Yard;
        [JsonProperty]
		public static readonly double League = 3 * Mile;
        [JsonProperty]
		public static readonly double ft = Foot;
    }

    [JsonObject(MemberSerialization.OptIn)]
    public readonly struct Weight
    {
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
        [JsonProperty]
		public static readonly double gt = gigatonne;
        [JsonProperty]
		public static readonly double mt = megatonne;
        [JsonProperty]
		public static readonly double kg = kilogramm;
        [JsonProperty]
		public static readonly double g = gramm;
        [JsonProperty]
		public static readonly double mg = milligramm;
        [JsonProperty]
		public static readonly double um = microgram;
        [JsonProperty]
		public static readonly double ng = nanogram;
        [JsonProperty]
		public static readonly double pg = picogram;
        //Imperial
        [JsonProperty]
		public static readonly double USton = 0.907d * tonne;
        [JsonProperty]
		public static readonly double UKton = 1.016d * tonne;
        [JsonProperty]
		public static readonly double pound = 453.59d;
        [JsonProperty]
		public static readonly double ounce = 28.35d;
        [JsonProperty]
		public static readonly double lb = pound;
        [JsonProperty]
		public static readonly double oz = ounce;
    }
       
    [JsonObject(MemberSerialization.OptIn)]
    public readonly struct Time
    {
        [JsonProperty]
		public static readonly double Millisecond = 1e-3d;
        [JsonProperty]
		public static readonly double Second = 1d;
        [JsonProperty]
		public static readonly double Minute = 60d;
        [JsonProperty]
		public static readonly double Kilosecond = 1e3d;
        [JsonProperty]
		public static readonly double Hour = 60d * Minute;
        [JsonProperty]
		public static readonly double Day = 24d * Hour;
        [JsonProperty]
		public static readonly double Week = 7d * Day;
        [JsonProperty]
		public static readonly double Megasecond = 1e6d;
    }

    [JsonObject(MemberSerialization.OptIn)]
    public readonly struct Volume
    {
        //Metric
        [JsonProperty]
		public static readonly double Litre = 0.001d;
        [JsonProperty]
		public static readonly double CubicDecimetre = Litre;
        [JsonProperty]
		public static readonly double CubicMetre = 1d;
        [JsonProperty]
		public static readonly double CubicCentimetre = 1e-6d;
        //Imperial
        [JsonProperty]
		public static readonly double CubicInch = Math.Pow(Length.Inch, 3);
        [JsonProperty]
		public static readonly double Barrel = 9.702d * CubicInch;
        [JsonProperty]
		public static readonly double USGallon = 231 * CubicInch;
        [JsonProperty]
		public static readonly double USPint = USGallon / 8;
        [JsonProperty]
		public static readonly double USFluidOunce = USGallon / 128;
        [JsonProperty]
		public static readonly double CubicFoot = Math.Pow(Length.Foot, 3);
    }

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

    class Converter
    {

        public Converter(double value, IUnit unit, double inputUnit, double outUnit)

        {
            Value = value;
            Unit = unit;
            Input = inputUnit;
            Output = outUnit;
        }

        public Converter(double value, Units.Type.Temperature inputUnit, Units.Type.Temperature outUnit)
        {
            Value = value;
            Unit = new Units.Temperature(Value, inputUnit);
            Input = Unit.Result(inputUnit);
            Output = Unit.Result(outUnit);
        }

        public double Value { get; set; }
        public IUnit Unit{ get; set; }
        public double Input { get; set; }
        public double Output { get; set; }

        public double Result()
        {
            if(Unit is Temperature)
                return Output;
            return Value * Input / Output;
        }

        public void SerializeUnit()
        {
            List<System.Type> types = new(){typeof(Volume), typeof(Area), typeof(Time), typeof(Weight), typeof(Length), typeof(Units.Temperature)};
            TextWriter? writer = null;
            try
            {
                writer = new StreamWriter("Converter.json", true);
                foreach (var d in types)
                {
                    var data = Activator.CreateInstance(d);
                    var json = JsonConvert.SerializeObject(data, Formatting.Indented);
                    writer.Write(json+"\n");
                }
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
    }
}