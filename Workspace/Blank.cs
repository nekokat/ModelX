using System;
using Newtonsoft.Json;
using Support;

namespace ModelX.Workspace.Blank
{

    [JsonObject(MemberSerialization.OptIn)]
    public class Blank
    {
        [JsonProperty]
        public BlankType? Type { get; set; }

        [JsonProperty]
        public int? Version { get; set; }

        [JsonProperty]
        public string? Id { get; set; }

        [JsonProperty]
        public int? TotalPoints { get; set; }

        /*
        [JsonProperty]
        public List<PointsRecord>? points_record { get; set; }

        [JsonProperty]
        public Profile? profile { get; set; }

        [JsonProperty]
        public Settings? settings { get; set; }
        */

        [JsonProperty]
        public List<Attribute>? Attributes { get; set; }

        /*
        [JsonProperty]
        public List<Trait>? traits { get; set; }
        */

        [JsonProperty]
        public DateTime CreatedDate { get; set; }

        [JsonProperty]
        public DateTime ModifiedDate { get; set; }

        /*
        [JsonProperty]
        public Calc? calc { get; set; }
        */
    }
}