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

        static Temperature Value {get; set; }

        [Test]
        public void MeasureLoadTest()
        {
            Temperature temperature = new Temperature(Value.Celsius, UnitTemperature.Celsius))
            Assert.That(Value, Is.EqualTo(temperature);
        }
    }
}