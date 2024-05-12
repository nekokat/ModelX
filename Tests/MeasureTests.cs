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
            Value = Global.Setting.Measure;
        }

        static Settings.Measure Value {get; set; }

        [Test]
        public void MeasureLoadTest()
        {
            Temperature temperature = new Temperature(Value.Temperature.Celsius, UnitTemperature.Celsius);
            Assert.That(Value.Temperature, Is.EqualTo(temperature));
        }
    }
}