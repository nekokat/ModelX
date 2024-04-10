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
                {AttributeType.Dexterity,20},
                {AttributeType.Health, 10},
                {AttributeType.Intelligence, 20},
                {AttributeType.Strength, 10}
            };
            
            TextWriter writer = null;

            try
            {
                writer = new StreamWriter("./BasicTest.json");
                var json = JsonConvert.SerializeObject(PointsAttributeList, Formatting.Indented);
                writer.Write(json);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        Dictionary<AttributeType, int> PointsAttributeList;

        [Test]
        public void PointsAttributeFromJson()
        {
            var dict = Basic.Load("./BasicTest.json");
            Assert.That(PointsAttributeList, Is.EqualTo(dict));
            
        }
    }
}
