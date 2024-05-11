using Types;
using System.Collections.Generic;
using Characteristics;
using System.IO;
using Newtonsoft.Json;

namespace Tests
{
    public class CostTest
    {        
        [SetUp]
        public void Setup()
        {
            PointsAttributeList = new(){    
                {BasicAttributesType.Dexterity,20},
                {BasicAttributesType.Health, 10},
                {BasicAttributesType.Intelligence, 20},
                {BasicAttributesType.Strength, 10}
            };
        }

        protected Dictionary<BasicAttributesType, int> PointsAttributeList;

        [Test]
        public void PointsAttributeFromJson()
        {
            Assert.That(PointsAttributeList, Is.EqualTo(Global.Setting.Basic));            
        }
    }
}
