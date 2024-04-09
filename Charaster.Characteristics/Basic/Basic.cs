using Types;

namespace Characteristics{

    public class Basic
    {
        public Basic(AttributeType attributeType)
        {
            Type = attributeType;
        }

        public AttributeType Type { get; set; }

        public int Cost { get; set; }
        
        public CostType CType{ get; set; }
    }
}
