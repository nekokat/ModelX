using System;
using Measure;
using Unit = Measure.Unit;

namespace Tests
{
    public class ConverterTests : BaseConverterTest
    {
        [SetUp]
        public void Setup(){}

        [TestCase(90.0, Unit.Angle.Degree, Math.PI/2, Unit.Angle.Radian, 0.00001)]
        [TestCase(180.0, Unit.Angle.Degree, Math.PI, Unit.Angle.Radian, 0.00001)]
        [TestCase(360.0, Unit.Angle.Degree, 2 * Math.PI, Unit.Angle.Radian, 0.00001)]
        public void TestAngle(decimal x, Unit.Angle typex, decimal y, Unit.Angle typey, decimal delta)
        {
            Test<Measure.Angle>(x, typex, y, typey, delta);
        }

        [TestCase(90.0, Unit.Area.Acre, 364217.08, Unit.Area.SquareMeter, 1e-2)]
        [TestCase(180.0, Unit.Area.SquareCentimeter, 27.9001, Unit.Area.SquareInch, 1e-1)]
        [TestCase(360.0, Unit.Area.SquareYard, 0.000116218369836, Unit.Area.SquareMile, 1e-2)]
        public void TestArea(decimal x, Unit.Area typex, decimal y, Unit.Area typey, decimal delta)
        {
            Test<Measure.Area>(x, typex, y, typey, delta);
        }

        [TestCase(90.0, Unit.Length.CentiMeter, 0.9, Unit.Length.Meter, 1e-2)]
        [TestCase(180.0, Unit.Length.KiloMeter, 111.846815, Unit.Length.Mile, 1e-6)]
        [TestCase(360.0, Unit.Length.Foot, 1097.28, Unit.Length.DeciMeter, 1e-2)]
        public void TestLength(decimal x, Unit.Length typex, decimal y, Unit.Length typey, decimal delta)
        {
            Test<Measure.Length>(x, typex, y, typey, delta);
        }

        [TestCase(90.0, Unit.Temperature.Celsius, 194.0, Unit.Temperature.Fahrenheit, 1e-2)]
        [TestCase(180.0, Unit.Temperature.Kelvin, -30.7395, Unit.Temperature.Newton, 1e-4)]
        [TestCase(360.0, Unit.Temperature.Delisle, -112.0d, Unit.Temperature.Reaumur, 1e-5)]
        public void TestTemperature(decimal x, Unit.Temperature typex, decimal y, Unit.Temperature typey, decimal delta)
        {
            Test<Measure.Temperature>(x, typex, y, typey, delta);
        }

        [TestCase(90.0, Unit.Time.Second, 1.5d, Unit.Time.Minute, 1e-2)]
        [TestCase(10080.0, Unit.Time.Minute, 7.0, Unit.Time.Day, 1e-6)]
        [TestCase(365.0, Unit.Time.Day, 52.1429, Unit.Time.Week, 1e-2)]
        public void TestTime(decimal x, Unit.Time typex, decimal y, Unit.Time typey, decimal delta)
        {
            Test<Measure.Time>(x, typex, y, typey, delta);
        }

        [TestCase(90.0, Unit.Volume.Litre, 5492.137, Unit.Volume.CubicInch, 0.01)]
        [TestCase(10080.0, Unit.Volume.BarrelOil, 423360.0, Unit.Volume.USGallon, 0.01)]
        [TestCase(365.0, Unit.Volume.CubicMetre, 771382.39, Unit.Volume.USPint, 0.01)]
        public void TestVolume(decimal x, Unit.Volume typex, decimal y, Unit.Volume typey, decimal delta)
        {
            Test<Measure.Volume>(x, typex, y, typey, delta);
        }

        [TestCase(90.0, Unit.Weight.Tonne, 90000.0, Unit.Weight.Kilogramm, 1e-2)]
        [TestCase(10080.0, Unit.Weight.Ounce, 285768.0, Unit.Weight.Gramm, 1e-2)]
        [TestCase(365.0, Unit.Weight.USton, 325.8415, Unit.Weight.UKton, 1e-4)]
        public void TestWeight(decimal x, Unit.Weight typex, decimal y, Unit.Weight typey, decimal delta)
        {
            Test<Measure.Weight>(x, typex, y, typey, delta);
        }
    }
}