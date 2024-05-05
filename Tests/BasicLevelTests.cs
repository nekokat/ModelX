using Types;
using System.Collections.Generic;
using Characteristics;
using System.IO;
using Newtonsoft.Json;

namespace Tests
{
    public class BasicLevelTest
    {
        [SetUp]
        public void Setup()
        {
            BasicValue = new Basic(BasicAttributesType.Strength);
        }

        Basic BasicValue { get; set; }

        string Filepath { get; set; }

        [TestCase(0, BasicLevel.Crippling)]
        [TestCase(5, BasicLevel.Crippling)]
        [TestCase(6, BasicLevel.Crippling)]
        [TestCase(7, BasicLevel.Poor)]
        [TestCase(8, BasicLevel.BelowAverage)]
        [TestCase(9, BasicLevel.BelowAverage)]
        [TestCase(10, BasicLevel.Average)]
        [TestCase(11, BasicLevel.AboveAverage)]
        [TestCase(12, BasicLevel.AboveAverage)]
        [TestCase(13, BasicLevel.Exceptional)]
        [TestCase(14, BasicLevel.Exceptional)]
        [TestCase(15, BasicLevel.Amazing)]
        [TestCase(20, BasicLevel.Amazing)]
        [TestCase(50, BasicLevel.Amazing)]
        public void BasicValueTest(int points, BasicLevel level)
        {
            BasicValue.Point = points;
            Assert.That(BasicValue.Level, Is.EqualTo(level));
        }
    }
}
