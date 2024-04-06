using System;
using ModelX.Workspace;
using Support;

namespace Tests
{
    public class ContainerIDTest
    {
        [SetUp]
        public void Setup(){}

        [TestCase(BlankType.Clear,"")]
        [TestCase(BlankType.Person,"")]
        [TestCase(BlankType.Weapon,"")]
        [TestCase(BlankType.Skill,"")]
        [TestCase(BlankType.Spell,"")]
        [TestCase(BlankType.Notes,"")]
        [TestCase(BlankType.Equipment,"")]
        [TestCase(BlankType.Trait,"")]
        public void IDTest(BlankType type, string id)
        {
            string _name = Enum.GetName(typeof(BlankType), type) ?? string.Empty;
            Assert.That(new ContainerID(_name).ToString(), Is.EqualTo(id));
        }
    }
}
