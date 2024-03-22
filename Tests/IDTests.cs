using System;
using Converter;
using NUnit.Framework;
using ModelX.Workspace;

namespace ID.Tests
{
    public class BlankTypeTest
    {
        [SetUp]
        public void Setup(){}

        [TestCase(BlankType.Clear, "Angle.Degree")]
        [TestCase(BlankType.Person, "Angle.Degree")]
        [TestCase(BlankType.Weapon, "Angle.Degree")]
        [TestCase(BlankType.Skill, "Angle.Degree")]
        public void GuidTest(BlankType type, string guid)
        {
            Assert.That(type.ToString(), Is.EqualTo(guid))
        }
    }
}