using System;
using Characteristics;
using System.IO;
using Newtonsoft.Json;

namespace Tests
{
    public class EncumbranceTest
    {
        [SetUp]
        public void Setup()
        {
            Encumbrance = new(10);
        }

        protected Encumbrance Encumbrance { get; set; }

        [TestCase(EncumbranceType.None)]
        [TestCase(EncumbranceType.Light)]
        [TestCase(EncumbranceType.Medium)]
        [TestCase(EncumbranceType.Heavy)]
        [TestCase(EncumbranceType.ExtraHeavy)]
        public void GetTest(EncumbranceType type)
        {
            double actual = Encumbrance.GetByName(Enum.GetName(typeof(EncumbranceType), type));
            double expected = Encumbrance.GetByType(type);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}