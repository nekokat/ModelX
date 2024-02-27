using System;
using ModelX.Measure.Unit;

namespace Tests
{
    public class Tests : BaseTest
    {
        [SetUp]
        public void Setup(){}


        [TestCase(90.0, Angle.Degree, Math.PI/2, Angle.Radian, 0d)]
        [TestCase(180.0, Angle.Degree, Math.PI, Angle.Radian, 0d)]
        [TestCase(360.0, Angle.Degree, 2 * Math.PI, Angle.Radian, 0d)]
        public void TestAngle(double x, Angle typex, double y, Angle typey, double delta)
        {
            Test<ModelX.Measure.Angle>(x, typex, y, typey, delta);
        }

        [TestCase(90.0, Area.Acre, 364217.08, Area.SquareMeter, 1e-2)]
        [TestCase(180.0, Area.SquareCentimeter, 27.9001d, Area.SquareInch, 1e-1)]
        [TestCase(360.0, Area.SquareYard, 0.000116218369836d, Area.SquareMile, 1e-2)]
        public void TestArea(double x, Area typex, double y, Area typey, double delta)
        {
            Test<ModelX.Measure.Area>(x, typex, y, typey, delta);
        }

        [TestCase(90.0, Length.CentiMeter, 0.9, Length.Meter, 1e-2)]
        [TestCase(180.0, Length.KiloMeter, 111.846815, Length.Mile, 1e-6)]
        [TestCase(360.0, Length.Foot, 1097.28d, Length.DeciMeter, 1e-2)]
        public void TestLength(double x, Length typex, double y, Length typey, double delta)
        {
            Test<ModelX.Measure.Length>(x, typex, y, typey, delta);
        }

        [TestCase(90.0, Temperature.Celsius, 194.0, Temperature.Fahrenheit, 1e-2)]
        [TestCase(180.0, Temperature.Kelvin, -30.7395, Temperature.Newton, 1e-4)]
        [TestCase(360.0, Temperature.Delisle, -112.0d, Temperature.Reaumur, 1e-2)]
        public void TestTemperature(double x, Temperature typex, double y, Temperature typey, double delta)
        {
            Test<ModelX.Measure.Temperature>(x, typex, y, typey, delta);
        }

        [TestCase(90.0d, Time.Second, 1.5d, Time.Minute, 1e-2)]
        [TestCase(10080.0d, Time.Minute, 7.0d, Time.Day, 1e-6)]
        [TestCase(365.0d, Time.Day, 52.1429d, Time.Week, 1e-2)]
        public void TestTime(double x, Time typex, double y, Time typey, double delta)
        {
            Test<ModelX.Measure.Time>(x, typex, y, typey, delta);
        }

        [TestCase(90.0d, Volume.Litre, 5492.137d, Volume.CubicInch, 0.01d)]
        [TestCase(10080.0d, Volume.BarrelOil, 423360.0d, Volume.USGallon, 0.01d)]
        [TestCase(365.0d, Volume.CubicMetre, 771382.39d, Volume.USPint, 0.01d)]
        public void TestVolume(double x, Volume typex, double y, Volume typey, double delta)
        {
            Test<ModelX.Measure.Volume>(x, typex, y, typey, delta);
        }

        [TestCase(90.0d, Weight.Tonne, 90000.0d, Weight.Kilogramm, 1e-2)]
        [TestCase(10080.0d, Weight.Ounce, 285768.0d, Weight.Gramm, 1e-2)]
        [TestCase(365.0d, Weight.USton, 325.8415d, Weight.UKton, 1e-4)]
        public void TestWeight(double x, Weight typex, double y, Weight typey, double delta)
        {
            Test<ModelX.Measure.Weight>(x, typex, y, typey, delta);
        }
    }
}