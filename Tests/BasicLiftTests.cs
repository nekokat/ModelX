using Types;
using System.Collections.Generic;
using Characteristics;
using System.IO;
using Newtonsoft.Json;
using Settings;

namespace Tests
{
    public class BasicLiftTest
    {
        [SetUp]
        public void Setup()
        {
            BasicLift.Generate();
            //Setting.Load("./Setting.json");
            Setting.Load("/run/media/neko/files/ModelX/Tests/bin/Debug/net8.0/Setting.json");
        }

        Basic Value { get; set; }

        [Test]
        public void BasicLiftGenerateTest()
        {
            Assert.That(Setting.BasicLift.Generate, Does.Exist);
        }
    }
}