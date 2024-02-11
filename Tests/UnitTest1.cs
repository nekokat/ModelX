using ModelX.Measure.Unit;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using NUnit.Framework.Legacy;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {}


        [TestCase(90.0, Angle.Degree, Math.PI/2, Angle.Radian)]
        [TestCase(180.0, Angle.Degree, Math.PI, Angle.Radian)]
        [TestCase(360.0, Angle.Degree, 2 * Math.PI, Angle.Radian)]
        public void TestAngle(double x, Angle typex, double y, Angle typey)
        {
            ModelX.Measure.Angle expected = new(x, typex);
            ModelX.Measure.Angle actual = new(y, typey);
            ClassicAssert.AreEqual(expected.Result(typey), y);
            ClassicAssert.AreEqual(actual.Result(typex), x);
        }

        [TestCase(90.0, Area.Acre, 364217.08, Area.SquareMeter, 1e-2)]
        [TestCase(180.0, Area.SquareCentimeter, 27.9001d, Area.SquareInch, 1e-3)]
        [TestCase(360.0, Area.SquareYard, 0.000116218369836d, Area.SquareMile, 1e-2)]
        public void TestArea(double x, Area typex, double y, Area typey, double delta)
        {
            ModelX.Measure.Area expected = new(x, typex);
            ModelX.Measure.Area actual = new(y, typey);
            ClassicAssert.AreEqual(expected.Result(typey), y, delta);
            ClassicAssert.AreEqual(actual.Result(typex), x, delta);
        }

        [TestCase(90.0, Length.CentiMeter, 0.9, Length.Meter, 1e-2)]
        [TestCase(180.0, Length.KiloMeter, 111.846815, Length.Mile, 1e-6)]
        [TestCase(360.0, Length.Foot, 1097.28d, Length.DeciMeter, 1e-2)]
        public void TestLength(double x, Length typex, double y, Length typey, double delta)
        {
            ModelX.Measure.Length expected = new(x, typex);
            ModelX.Measure.Length actual = new(y, typey);
            ClassicAssert.AreEqual(expected.Result(typey), y, delta);
            ClassicAssert.AreEqual(actual.Result(typex), x, delta);
        }

        [TestCase(90.0, Temperature.Celsius, 194.0, Temperature.Fahrenheit, 1e-2)]
        [TestCase(180.0, Temperature.Kelvin, -30.7395, Temperature.Newton, 1e-4)]
        [TestCase(360.0, Temperature.Delisle, -112.0d, Temperature.Reaumur, 1e-2)]
        public void TestTemperature(double x, Temperature typex, double y, Temperature typey, double delta)
        {
            ModelX.Measure.Temperature expected = new(x, typex);
            ModelX.Measure.Temperature actual = new(y, typey);
            ClassicAssert.AreEqual(expected.Result(typey), y, delta);
            ClassicAssert.AreEqual(actual.Result(typex), x, delta);
        }

        [TestCase(90.0d, Time.Second, 1.5d, Time.Minute, 1e-2)]
        [TestCase(10080.0d, Time.Minute, 7.0d, Time.Day, 1e-6)]
        [TestCase(365.0d, Time.Day, 52.1429d, Time.Week, 1e-2)]
        public void TestTime(double x, Time typex, double y, Time typey, double delta)
        {
            ModelX.Measure.Time expected = new(x, typex);
            ModelX.Measure.Time actual = new(y, typey);
            ClassicAssert.AreEqual(expected.Result(typey), y, delta);
            ClassicAssert.AreEqual(actual.Result(typex), x, delta);
        }

        [TestCase(90.0d, Volume.Litre, 5492.137d, Volume.CubicInch, 1e-3)]
        [TestCase(10080.0d, Volume.BarrelOil, 423360.0d, Volume.USGallon, 0.1d)]
        [TestCase(365.0d, Volume.CubicMetre, 771382.39d, Volume.USPint, 1e-2)]
        public void TestVolume(double x, Volume typex, double y, Volume typey, double delta)
        {
            ModelX.Measure.Volume expected = new(x, typex);
            ModelX.Measure.Volume actual = new(y, typey);
            ClassicAssert.AreEqual(expected.Result(typey), y, delta);
            ClassicAssert.AreEqual(actual.Result(typex), x, delta);
        }

        [TestCase(90.0d, Weight.Tonne, 90000.0d, Weight.Kilogramm, 1e-2)]
        [TestCase(10080.0d, Weight.Ounce, 285768.0d, Weight.Gramm, 1e-2)]
        [TestCase(365.0d, Weight.USton, 325.8415d, Weight.UKton, 1e-4)]
        public void TestWeight(double x, Weight typex, double y, Weight typey, double delta)
        {
            ModelX.Measure.Weight expected = new(x, typex);
            ModelX.Measure.Weight actual = new(y, typey);
            ClassicAssert.AreEqual(expected.Result(typey), y, delta);
            ClassicAssert.AreEqual(actual.Result(typex), x, delta);
        }
    }
}