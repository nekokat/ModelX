using Types;
using System.Collections.Generic;
using Characteristics;
using System.IO;
using Newtonsoft.Json;
using Settings;

namespace Tests
{
    public class CostTest
    {
        [SetUp]
        public void Setup()
        {
            Setting.Load("/run/media/neko/files/ModelX/Tests/bin/Debug/net8.0/Setting.json");

            PointsAttributeList = new(){    
                {BasicAttributesType.Dexterity,20},
                {BasicAttributesType.Health, 10},
                {BasicAttributesType.Intelligence, 20},
                {BasicAttributesType.Strength, 10}
            };
        }

        Dictionary<BasicAttributesType, int> PointsAttributeList;

        [Test]
        public void PointsAttributeFromJson()
        {
            Assert.That(PointsAttributeList, Is.EqualTo(Setting.Basic));            
        }
    }
}
