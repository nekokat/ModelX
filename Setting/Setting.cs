using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Types;


namespace Settings
{
    [JsonObject(MemberSerialization.OptIn)]
    public sealed class Setting
    {
        //TODO: Create reading from json
        [JsonProperty("BasicLift")]
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
}