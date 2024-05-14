using System.Collections.Generic;

namespace Tests
{
    public class MeasureTest
    {
        [SetUp]
        public void Setup()
        {

        }
        public static void Load()
        {
            Value = Global.Setting.Measure.Temperature;
        }

        static Dictionary<UnitTemperature, decimal> Value {get; set; }

        [Test]
        public void MeasureLoadTest()
        {
            //Temperature temperatureCelsius = new Temperature(Value[UnitTemperature.Celsius], UnitTemperature.Celsius);
            //Temperature temperatureKelvin = new Temperature(Value[UnitTemperature.Kelvin], UnitTemperature.Kelvin);
            Assert.Pass();
        }
    }
}