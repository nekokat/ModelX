using System;

namespace Tests;

public class VersionTests
{
    [SetUp]
        public void Setup(){}

        [TestCase("0.0.0",  "0.0.1")]
        [TestCase("0.0.1",  "0.0.1")]
        [TestCase("1.20.3.", "1.20.3")]
        [TestCase("1.20.3d", "1.20.3")]
        public void ParseTest(string version, string actual)
        {
            Assert.That(Support.Version.Parse(version).ToString(), Is.EqualTo(actual));
        }
        
        [TestCase(1, 20, 3, "1.20.3")]
        [TestCase(0, 2, 3, "0.2.3")]
        [TestCase(9, 0, 0, "9.0.0")]
        public void ConstructorTest(int current, int revision, int age, string actual)
        {
            Assert.That(new Version(current, revision, age).ToString(), Is.EqualTo(actual));
        }
}