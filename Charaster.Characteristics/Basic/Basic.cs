using System.Diagnostics;
using Types;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Characteristics{

    public class Basic
    {
        public Basic(AttributeType attributeType)
        {
            Type = attributeType;
        }

        public AttributeType Type { get; set; }

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

        private int CostSetMultiplier(AttributeType type)
        {
            throw new NotImplementedException();
        }

        private int CostSetPercentage(AttributeType type)
        {
            throw new NotImplementedException();
        }

        private int CostSetPoints(AttributeType type)
        {
            /*
            return type switch
            {
                AttributeType.Dexterity => 20,
                AttributeType.Health => 10,
                AttributeType.Intelligence => 20,
                AttributeType.Strength => 10,
                _ => throw new Exception()
            };
            */

            Dictionary<AttributeType, int>? dictionary;
            using (StreamReader r = new StreamReader("file.json"))
            {
                string json = r.ReadToEnd();
                dictionary = JsonConvert.DeserializeObject<Dictionary<AttributeType, int>>(json);
                
            }
            return dictionary?[type] ?? 0;
        }
        
        public CostType CType{ get; set; }
    }
}
