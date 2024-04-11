using System.Diagnostics;
using Types;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Characteristics{

    public class Basic
    {
        public Basic(BasicAttributesType attributeType)
        {
            Type = attributeType;
        }

        public static Dictionary<BasicAttributesType, int> Load(string filename)
        {
            Dictionary<BasicAttributesType, int>? dictionary;
            using (StreamReader r = new StreamReader(filename))
            {
                string json = r.ReadToEnd();
                dictionary = JsonConvert.DeserializeObject<Dictionary<BasicAttributesType, int>>(json);                
            }
            return dictionary ?? new();
        }

        public BasicAttributesType Type { get; set; }

        public int Cost {
            get {
                return CType switch
                {
                    CostType.Points => CostSetPoints(Type),
                    CostType.Percentage => CostSetPercentage(Type),
                    CostType.Multiplier => CostSetMultiplier(Type),
                    _ => throw new Exception()
                };
            }
        }

        private int CostSetMultiplier(BasicAttributesType type)
        {
            throw new NotImplementedException();
        }

        private int CostSetPercentage(BasicAttributesType type)
        {
            throw new NotImplementedException();
        }

        private int CostSetPoints(BasicAttributesType type)
        {
            /*
            return type switch
            {
                BasicAttributesType.Dexterity => 20,
                BasicAttributesType.Health => 10,
                BasicAttributesType.Intelligence => 20,
                BasicAttributesType.Strength => 10,
                _ => throw new Exception()
            };
            */
            Load("basic.json").TryGetValue(type, out int value);
            return value;
        }
        
        public CostType CType{ get; set; }
    }
}
