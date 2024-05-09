﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;


namespace Settings
{
    [JsonObject(MemberSerialization.OptIn)]
    public sealed class Setting
    {
        //TODO: Create reading from json
        [JsonProperty("BasicLift")]
        public static BL BasicLift{ get; set; }
        [JsonProperty]
        public static Dictionary<string, int> Basic { get; set; }
        [JsonProperty]
        public static Dictionary<string, string> Blank { get; set; }

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
}