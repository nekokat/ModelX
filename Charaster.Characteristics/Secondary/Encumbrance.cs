using Newtonsoft.Json;

namespace Characteristics{
    public enum EncumbranceType
    {
        None = 1,
        Light = 2,
        Medium = 3,
        Heavy = 6 ,
        ExtraHeavy = 10
    }
    
    [JsonObject(MemberSerialization.OptIn)]
    public class Encumbrance
    {
        public Encumbrance(double value)
        {
            Value = value;
        }

        protected double Value { get; private set;}

        [JsonProperty]
        public double None => Value * (int)EncumbranceType.None;
        [JsonProperty]
        public double Light => Value * (int)EncumbranceType.Light;
        [JsonProperty]
        public double Medium => Value * (int)EncumbranceType.Medium;
        [JsonProperty]
        public double Heavy => Value * (int)EncumbranceType.Heavy;
        [JsonProperty]
        public double ExtraHeavy => Value * (int)EncumbranceType.ExtraHeavy;

        public double GetByType(EncumbranceType type)
        {
            return type switch
            {
                EncumbranceType.None => None,
                EncumbranceType.Light => Light,
                EncumbranceType.Medium => Medium,
                EncumbranceType.Heavy => Heavy,
                EncumbranceType.ExtraHeavy => ExtraHeavy,
                _ => throw new ArgumentNullException()
            };
        }

        public double GetByName(string typeName) => (int)Enum.Parse(typeof(EncumbranceType), typeName) * Value;
    }
}