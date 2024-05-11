using System;
using Measure;

namespace Tests
{
    public class ConverterTests : BaseConverterTest
    {
        [SetUp]
        public void Setup(){}

        [TestCase(90.0, UnitAngle.Degree, Math.PI/2, UnitAngle.Radian, 0.00001)]
        [TestCase(180.0, UnitAngle.Degree, Math.PI, UnitAngle.Radian, 0.00001)]
        [TestCase(360.0, UnitAngle.Degree, 2 * Math.PI, UnitAngle.Radian, 0.00001)]
        public void TestAngle(decimal x, UnitAngle typex, decimal y, UnitAngle typey, decimal delta)
        {
            Test<Measure.Angle>(x, typex, y, typey, delta);
        }

        [TestCase(90.0, UnitArea.Acre, 364217.08, UnitArea.SquareMeter, 1e-2)]
        [TestCase(180.0, UnitArea.SquareCentimeter, 27.9001, UnitArea.SquareInch, 1e-1)]
        [TestCase(360.0, UnitArea.SquareYard, 0.000116218369836, UnitArea.SquareMile, 1e-2)]
        public void TestArea(decimal x, UnitArea typex, decimal y, UnitArea typey, decimal delta)
        {
            Test<Measure.Area>(x, typex, y, typey, delta);
        }

        [TestCase(90.0, UnitLength.CentiMeter, 0.9, UnitLength.Meter, 1e-2)]
        [TestCase(180.0, UnitLength.KiloMeter, 111.846815, UnitLength.Mile, 1e-6)]
        [TestCase(360.0, UnitLength.Foot, 1097.28, UnitLength.DeciMeter, 1e-2)]
        public void TestLength(decimal x, UnitLength typex, decimal y, UnitLength typey, decimal delta)
        {
            Test<Measure.Length>(x, typex, y, typey, delta);
        }

        [TestCase(90.0, UnitTemperature.Celsius, 194.0, UnitTemperature.Fahrenheit, 1e-2)]
        [TestCase(180.0, UnitTemperature.Kelvin, -30.7395, UnitTemperature.Newton, 1e-4)]
        [TestCase(360.0, UnitTemperature.Delisle, -112.0d, UnitTemperature.Reaumur, 1e-5)]
        public void TestTemperature(decimal x, UnitTemperature typex, decimal y, UnitTemperature typey, decimal delta)
        {
            Test<Measure.Temperature>(x, typex, y, typey, delta);
        }

        [TestCase(90.0, UnitTime.Second, 1.5d, UnitTime.Minute, 1e-2)]
        [TestCase(10080.0, UnitTime.Minute, 7.0, UnitTime.Day, 1e-6)]
        [TestCase(365.0, UnitTime.Day, 52.1429, UnitTime.Week, 1e-2)]
        public void TestTime(decimal x, UnitTime typex, decimal y, UnitTime typey, decimal delta)
        {
            Test<Measure.Time>(x, typex, y, typey, delta);
        }

        [TestCase(90.0, UnitVolume.Litre, 5492.137, UnitVolume.CubicInch, 0.01)]
        [TestCase(10080.0, UnitVolume.BarrelOil, 423360.0, UnitVolume.USGallon, 0.01)]
        [TestCase(365.0, UnitVolume.CubicMetre, 771382.39, UnitVolume.USPint, 0.01)]
        public void TestVolume(decimal x, UnitVolume typex, decimal y, UnitVolume typey, decimal delta)
        {
            Test<Measure.Volume>(x, typex, y, typey, delta);
        }

        [TestCase(90.0, UnitWeight.Tonne, 90000.0, UnitWeight.Kilogramm, 1e-2)]
        [TestCase(10080.0, UnitWeight.Ounce, 285768.0, UnitWeight.Gramm, 1e-2)]
        [TestCase(365.0, UnitWeight.USton, 325.8415, UnitWeight.UKton, 1e-4)]
        public void TestWeight(decimal x, UnitWeight typex, decimal y, UnitWeight typey, decimal delta)
        {
            Test<Measure.Weight>(x, typex, y, typey, delta);
        }
    }
}