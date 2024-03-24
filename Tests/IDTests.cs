using System;
using Converter;
using NUnit.Framework;
using ModelX.Workspace.Blank;

namespace Tests
{
    public class BlankTypeTest
    {
        [SetUp]
        public void Setup(){}

        [TestCase(BlankType.Clear,      "0cbc30dc-1479-59db-18da-4263fce93ad2")]
        [TestCase(BlankType.Person,     "cfd7be40-3d9b-b34b-a3d7-a7e3eb18c5eb")]
        [TestCase(BlankType.Weapon,     "6936c818-0292-a815-1863-8ad0e5421e4b")]
        [TestCase(BlankType.Skill,      "6f76bb88-c30c-7521-9ed2-eeb0bc06be5d")]
        [TestCase(BlankType.Spell,      "f0e48a96-7e3d-300c-fe4e-b26b83c855dd")]
        [TestCase(BlankType.Notes,      "51f8c6f4-0db0-1855-bf88-8815de279aba")]
        [TestCase(BlankType.Equipment,  "d5a2cd9c-1e0a-b7e1-3ee1-f048eb397aa8")]
        [TestCase(BlankType.Trait,      "0fea1891-d076-f2a8-1a42-591caeee043e")]
        public void GuidTest(BlankType type, string guid)
        {
            Assert.That(new ID(type).ToString(), Is.EqualTo(guid));
        }
    }
}