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

            TestFilename = "./BasicTest.json";

            try
            {
                writer = new StreamWriter(TestFilename);
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

        string TestFilename {get;set;}

        [Test]
        public void PointsAttributeFromJson()
        {
            var dict = Basic.Load(TestFilename);
            Assert.That(PointsAttributeList, Is.EqualTo(dict));
            
        }
    }
}
