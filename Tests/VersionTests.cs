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
        
}