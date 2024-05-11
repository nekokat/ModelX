using Types;
using System.Collections.Generic;
using Characteristics;
using System.IO;
using Newtonsoft.Json;

namespace Tests
{
    public class BasicLiftTest
    {
        /*protected Setting setting = 
            Setting.Load("/run/media/neko/files/ModelX/Tests/bin/Debug/net8.0/Setting.json");
        */
        [SetUp]
        public void Setup()
        {
            BasicLift.Generate();
        }

        Basic Value { get; set; }

        [Test]
        public void BasicLiftGenerateTest()
        {
            Assert.That(Global.Setting.BasicLift.Path, Does.Exist);
        }
    }
}