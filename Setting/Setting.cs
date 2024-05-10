﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Types;


namespace Settings
{
    [JsonObject(MemberSerialization.OptIn)]
    public record Setting
    {
        //TODO: Create reading from json
        [JsonProperty]
        public static BL BasicLift{ get; set; }

        [JsonProperty]
        public static Dictionary<BasicAttributesType, int> Basic { get; set; }

        [JsonProperty]
        public static Blank Blank { get; set; }

        public static void Load (string filename)
        {
            using (StreamReader r = new(filename))
            {
                string json = r.ReadToEnd();
                JsonConvert.DeserializeObject<Setting>(json);
            }
        }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public record BL
    {
        [JsonProperty]
        public string Generate;
        [JsonProperty]
        public List<double> Data; 
    }

    [JsonObject(MemberSerialization.OptIn)]
    public record Blank
    {
        [JsonProperty]
        public string TempPath;
    }
}
