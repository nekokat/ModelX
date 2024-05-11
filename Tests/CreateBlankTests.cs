using ModelX;
using ModelX.Workspace;
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
                
                TempPath = Global.Setting.Blank.TempPath;
                Create.GenerateEmptyJson();
            }

            string TempPath { get; set; }

            [Test]
            public void CreateTest()
            {
                foreach (string filePath in Directory.GetFiles(TempPath, "*.json"))
                {
                    Assert.That(filePath, Does.Exist);
                }
            }

            [TestCase(BlankType.Clear)]
            [TestCase(BlankType.Person)]
            [TestCase(BlankType.Weapon)]
            [TestCase(BlankType.Skill)]
            [TestCase(BlankType.Spell)]
            [TestCase(BlankType.Notes)]
            [TestCase(BlankType.Equipment)]
            [TestCase(BlankType.Trait)]
            public void LoadTest(BlankType type)
            {
                string testFile = @$"{TempPath}/{type.ToString()}.json";
                ModelX.Workspace.Blank testBlank = new (type);

                Assert.That(ModelX.Workspace.Blank.Load(testFile),Is.EqualTo(testBlank));
            }
    }
}
