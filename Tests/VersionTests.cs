using System;

namespace Tests
{

    public class VersionTests
    {
        [SetUp]
            public void Setup(){}

            [TestCase("0.0.0",  "0.0.0")]
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
            public void ConstructorIntTest(int current, int revision, int age, string actual)
            {
                Assert.That(new Support.Version(current, revision, age).ToString(), Is.EqualTo(actual));
            }

            [TestCase("01", "00", "3", "1.0.3")]
            [TestCase("5", "14", "8", "5.14.8")]
            [TestCase("9", "0", "6", "9.0.6")]
            public void ConstructorStringTest(string current, string revision, string age, string actual)
            {
                Assert.That(new Support.Version(current, revision, age).ToString(), Is.EqualTo(actual));
            }
    }
}