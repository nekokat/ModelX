using System;
using Newtonsoft.Json;
using Support;
using ModelX.User;

namespace ModelX.Workspace
{

    [JsonObject(MemberSerialization.OptIn)]
    public class Blank
    {
        public BlankType Type { get; set; } = BlankType.Clear;

        public Support.Version Version { get; set; } = new(0,0,1);

        public ID Id { get; set; } = new(BlankType.Clear);

        [JsonProperty(PropertyName = "Version")]
        public string VersionJson => Version.ToString();

        [JsonProperty(PropertyName = "Id")]
        public string IdJson => Id.ToString();

        [JsonProperty(PropertyName = "Type")]
        public string TypeJson => Type.ToString();

        /*
        [JsonProperty]
        public int? TotalPoints { get; set; }

        
        [JsonProperty]
        public List<PointsRecord>? points_record { get; set; }
        
        [JsonProperty]
        public Profile? profile { get; set; }
        
        [JsonProperty]
        public Settings? settings { get; set; }
        

        [JsonProperty]
        public List<Attribute>? Attributes { get; set; }

        
        [JsonProperty]
        public List<Trait>? traits { get; set; }
        

        [JsonProperty]
        public DateTime CreatedDate { get; set; }

        [JsonProperty]
        public DateTime ModifiedDate { get; set; }

        
        [JsonProperty]
        public Calc? calc { get; set; }
        */
    }
}