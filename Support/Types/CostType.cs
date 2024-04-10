using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Types
{
    [JsonConverter(typeof(StringEnumConverter))]
    [Flags]
    public enum CostType
    {
        Points,
        Percentage,
        Multiplier
    }
}
