using System;
using Converter.Measure.Unit;

namespace Converter.Tests
{
    public class Tests : BaseTest
    {
        [SetUp]
        public void Setup(){}


        [TestCase(90.0, Angle.Degree, Math.PI/2, Angle.Radian, 0.00001)]
        [TestCase(180.0, Angle.Degree, Math.PI, Angle.Radian, 0.00001)]
        [TestCase(360.0, Angle.Degree, 2 * Math.PI, Angle.Radian, 0.00001)]
        public void TestAngle(decimal x, Angle typex, decimal y, Angle typey, decimal delta)
        {
            Test<Converter.Measure.Angle>(x, typex, y, typey, delta);
        }

        [TestCase(90.0, Area.Acre, 364217.08, Area.SquareMeter, 1e-2)]
        [TestCase(180.0, Area.SquareCentimeter, 27.9001, Area.SquareInch, 1e-1)]
        [TestCase(360.0, Area.SquareYard, 0.000116218369836, Area.SquareMile, 1e-2)]
        public void TestArea(decimal x, Area typex, decimal y, Area typey, decimal delta)
        {
            Test<Converter.Measure.Area>(x, typex, y, typey, delta);
        }

        [TestCase(90.0, Length.CentiMeter, 0.9, Length.Meter, 1e-2)]
        [TestCase(180.0, Length.KiloMeter, 111.846815, Length.Mile, 1e-6)]
        [TestCase(360.0, Length.Foot, 1097.28, Length.DeciMeter, 1e-2)]
        public void TestLength(decimal x, Length typex, decimal y, Length typey, decimal delta)
        {
            Test<Converter.Measure.Length>(x, typex, y, typey, delta);
        }

        [TestCase(90.0, Temperature.Celsius, 194.0, Temperature.Fahrenheit, 1e-2)]
        [TestCase(180.0, Temperature.Kelvin, -30.7395, Temperature.Newton, 1e-4)]
        [TestCase(360.0, Temperature.Delisle, -112.0d, Temperature.Reaumur, 1e-5)]
        public void TestTemperature(decimal x, Temperature typex, decimal y, Temperature typey, decimal delta)
        {
            Test<Converter.Measure.Temperature>(x, typex, y, typey, delta);
        }

        [TestCase(90.0, Time.Second, 1.5d, Time.Minute, 1e-2)]
        [TestCase(10080.0, Time.Minute, 7.0, Time.Day, 1e-6)]
        [TestCase(365.0, Time.Day, 52.1429, Time.Week, 1e-2)]
        public void TestTime(decimal x, Time typex, decimal y, Time typey, decimal delta)
        {
            Test<Converter.Measure.Time>(x, typex, y, typey, delta);
        }

        [TestCase(90.0, Volume.Litre, 5492.137, Volume.CubicInch, 0.01)]
        [TestCase(10080.0, Volume.BarrelOil, 423360.0, Volume.USGallon, 0.01)]
        [TestCase(365.0, Volume.CubicMetre, 771382.39, Volume.USPint, 0.01)]
        public void TestVolume(decimal x, Volume typex, decimal y, Volume typey, decimal delta)
        {
            Test<Converter.Measure.Volume>(x, typex, y, typey, delta);
        }

        [TestCase(90.0, Weight.Tonne, 90000.0, Weight.Kilogramm, 1e-2)]
        [TestCase(10080.0, Weight.Ounce, 285768.0, Weight.Gramm, 1e-2)]
        [TestCase(365.0, Weight.USton, 325.8415, Weight.UKton, 1e-4)]
        public void TestWeight(decimal x, Weight typex, decimal y, Weight typey, decimal delta)
        {
            Test<Converter.Measure.Weight>(x, typex, y, typey, delta);
        }
    }
}