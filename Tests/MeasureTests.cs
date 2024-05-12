namespace Tests
{
    public class MeasureTest
    {
        [SetUp]
        public void Setup()
        {

        }
        protected static void Load
        {
            Value = Global.Setting.Measure.Temperature;
        }

        IMeasure Value {get; set; }

        [Test]
        public void MeasureTest()
        {
            Assert.That();
        }
    }
}