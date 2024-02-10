using ModelX.Measure.Unit;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {}

        Tolerance _tolerance = Tolerance.Default;
        NUnitEqualityComparer _comparer = new();

        [TestCase(90.0, Math.PI/2)]
        [TestCase(180.0, Math.PI)]
        [TestCase(360.0, 2*Math.PI)]
        public void TestAngleDegreeRadian(double x, double y)
        {
            ModelX.Measure.Angle expected = new(x, Angle.Degree);
            ModelX.Measure.Angle actual = new(y, Angle.Radian);
            _comparer.AreEqual(expected, actual, ref _tolerance);
        }

        [TestCase(90.0, Area.Acre, 364217.08, Area.SquareMeter)]
        [TestCase(180.0, Area.SquareCentimeter, 27.900056, Area.SquareInch)]
        [TestCase(360.0, Area.SquareYard, 0.00011621901, Area.SquareMile)]
        public void TestArea(double x, ModelX.Measure.Unit.Area typex, double y, ModelX.Measure.Unit.Area typey)
        {
            ModelX.Measure.Area expected = new(x, typex);
            ModelX.Measure.Area actual = new(y, typey);
            _comparer.AreEqual(expected, actual, ref _tolerance);
        }
    }
}