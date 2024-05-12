using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Types;
using Measure;
using Measure.Unit;


namespace Settings
{    

    public static class Global
    {
        public static Setting Setting => Setting.Load("./Setting.json");
    }

    [JsonObject(MemberSerialization.OptIn)]
    public record Setting
    {
        //TODO: Create reading from json
        [JsonProperty]
        public BL BasicLift{ get; set; }

        [JsonProperty]
        public Dictionary<BasicAttributesType, int> Basic { get; set; }

        [JsonProperty]
        public Blank Blank { get; set; }

        public Measure Measure { get; set; }

        public static Setting Load (string filename)
        {
            Setting setting;
            using (StreamReader r = new(filename))
            {
                string json = r.ReadToEnd();
                setting = JsonConvert.DeserializeObject<Setting>(json);
            }
            return setting;
        }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public record BL
    {
        [JsonProperty]
        public string Path;
        [JsonProperty]
        public double[] Data; 
    }

    [JsonObject(MemberSerialization.OptIn)]
    public record Blank
    {
        [JsonProperty]
        public string TemplatePath;
    }
    
    [JsonObject(MemberSerialization.OptIn)]
    public record Measure
    {
        [JsonProperty]
        public Temperature Temperature;
    }
}
