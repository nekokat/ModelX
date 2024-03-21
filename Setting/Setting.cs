using Newtonsoft.Json;

namespace ModelX.Setting
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Settings
    {
        /*
        [JsonProperty("page")]
        public Page Page { get; set; }
        */

        [JsonProperty("block_layout")]
        public List<string>? BlockLayout { get; set; }

        /*
        [JsonProperty("attributes")]
        public List<Attribute> Attributes { get; set; }
        */

        /*
        [JsonProperty("body_type")]
        public BodyType BodyType { get; set; }
        */

        [JsonProperty("damage_progression")]
        public string? DamageProgression { get; set; }

        [JsonProperty("default_length_units")]
        public string? DefaultLengthUnits { get; set; }

        [JsonProperty("default_weight_units")]
        public string? DefaultWeightUnits { get; set; }

        [JsonProperty("user_description_display")]
        public string? UserDescriptionDisplay { get; set; }

        [JsonProperty("modifiers_display")]
        public string? ModifiersDisplay { get; set; }

        [JsonProperty("notes_display")]
        public string? NotesDisplay { get; set; }

        [JsonProperty("skill_level_adj_display")]
        public string? SkillLevelAdjDisplay { get; set; }

        [JsonProperty("show_spell_adj")]
        public bool? ShowSpellAdj { get; set; }

        [JsonProperty("exclude_unspent_points_from_total")]
        public bool? ExcludeUnspentPointsFromTotal { get; set; }
    }
}