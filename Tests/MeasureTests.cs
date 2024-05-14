using System.Collections.Generic;

namespace Tests
{
    public class MeasureTest
    {
        [SetUp]
        public void Setup(){}

        [Test]
        public static void MeasureTemperatureTest()
        {
            Assert.That(Global.Setting.Measure?.Temperature, Is.Not.Null);
            Assert.That(Global.Setting.Measure.Temperature, Is.EqualTo(new Temperature(100)));
        }
    }
}