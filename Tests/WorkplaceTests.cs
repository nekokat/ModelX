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
                TempPath = @"./Template";
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
                Assert.That(Blank.Load(@$"{TempPath}/{type.ToString()}.json"), Is.EqualTo(new Blank()));
            }
    }
}
