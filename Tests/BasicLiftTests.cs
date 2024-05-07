using Types;
using System.Collections.Generic;
using Characteristics;
using System.IO;
using Newtonsoft.Json;

namespace Tests
{
    public class BasicLiftTest
    {
        [SetUp]
        public void Setup()
        {
            BasicLift.Generate();
        }

        Basic Value { get; set; }

        [Test]
        public void BasicLiftGenerateTest()
        {
            Assert.That("/home/neko/Документы/ModelX/Tests/bin/Debug/net8.0/BasicLift.json", Does.Exist);
        }
    }
}