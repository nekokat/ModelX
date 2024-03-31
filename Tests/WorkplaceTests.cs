using ModelX.Workspace;
using ModelX.Workspace.Create;
using System;
using System.IO;
using Support;
using Newtonsoft.Json;

namespace Tests
{
    public class CreateTests
    {
            [SetUp]
            public void Setup()
            {
                Create.GenerateEmptyJson();
            }

            [Test]
            public void CreateTest()
            {
                foreach (string filePath in Directory.GetFiles(@"./Template", "*.json"))
                {
                    Assert.That(filePath, Does.Exist);
                }
            }

            [Test]
            public void LoadTest()
            {
                Blank _blank;
                foreach (string filePath in Directory.GetFiles(@"./Template", "*.json"))
                {
                    _blank = Blank.Load(filePath);

                    Assert.That(_blank, Is.Not.Null);
                    
                    using (StreamWriter file = new("./LoadTest.log", true))
                    {
                        var json = JsonConvert.SerializeObject(_blank, Formatting.Indented);
                        file.Write(json + "\n");
                    }
                }
            }
    }
}
