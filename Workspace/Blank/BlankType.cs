using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Workspace
{    
    [JsonConverter(typeof(StringEnumConverter))]
    [Flags]
    public enum BlankType
    {
        Clear,
        Person,
        Weapon,
        Skill,
        Spell,
        Notes,
        Equipment,
        Trait,
        Modifier,
        SkillBonus,
        Technique
    }
}