using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Types
{
    [JsonConverter(typeof(StringEnumConverter))]
    [Flags]
    public enum BasicAttributesType
    {
        Strength,
        Dexterity,
        Intelligence,
        Health
 
    }
    
    [JsonConverter(typeof(StringEnumConverter))]
    [Flags]
    public enum SecondaryCharacteristicsType
    {
        Damage,
        BasicLift,
        HitPoints,
        Will, 
        Perception,
        FatiguePoints,
        BasicSpeed,
        BasicMove
    }
}