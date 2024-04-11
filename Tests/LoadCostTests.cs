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
            
            Filepath = "./BasicTest.json";

            using (StreamWriter writejson = new (Filepath))
            {
                var json = JsonConvert.SerializeObject(PointsAttributeList, Formatting.Indented);
                writejson.WriteLine(json);
            }
        }

        Dictionary<BasicAttributesType, int> PointsAttributeList;

        string Filepath { get; set; }

        [Test]
        public void PointsAttributeFromJson()
        {
            var dict = Basic.Load(Filepath);
            Assert.That(PointsAttributeList, Is.EqualTo(dict));            
        }
    }
}
