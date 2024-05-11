using System;
using Newtonsoft.Json;
using Support;
using User;

namespace Workspace
{

    [JsonObject(MemberSerialization.OptIn)]
    public class Blank : IEquatable<Blank>, IBlank
    {

        public static Blank Load(string jsonPath)
        {
            using (StreamReader reader = new StreamReader(jsonPath))
            {
                string json = reader.ReadToEnd();
                Blank? files = JsonConvert.DeserializeObject<Blank>(json);
                return files ?? new Blank();
            }            
        }

        public Blank() :this(BlankType.Clear, new(0,0,1)) {}

        public Blank(BlankType type) : this(type, new(0,0,1)) {}

        public Blank(BlankType type, Support.Version version)
        {
            Type = type;
            Version = version;
            Id = new(type);
        }

        [JsonProperty]
        public BlankType Type { get; set; }

        public Support.Version Version { get; set; }

        public BlankID Id { get; set; }

        [JsonProperty(PropertyName = "Version")]
        public string VersionJson
        {
            get => Version.ToString();
            set => Version = Support.Version.Parse(value);
        }

        [JsonProperty(PropertyName = "Id")]
        public string IdJson
        {
            get => Id.ToString();
            set => Id = new BlankID(Type);
        }
/*
        [JsonProperty(PropertyName = "Type")]
        public string TypeJson => Type.ToString();
*/
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
        
        public bool Equals(Blank? other)
        {
            return Id.Equals(other?.Id) && Version.Equals(other?.Version) && Type.Equals(other?.Type);
        }
    }
}