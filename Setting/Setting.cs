using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;


namespace Settings
{
    [JsonObject(MemberSerialization.OptIn)]
    public sealed class Setting
    {
        //TODO: Create reading from json
        [JsonProperty("BasicLift")]
        public static List<double> BasicLift { get; set; }

        public static Setting Load (string filename)
        {
            Setting result;
            using (StreamReader r = new(filename))
            {
                string json = r.ReadToEnd();
                result = JsonConvert.DeserializeObject<Setting>(json);
            }
            return result;
        }
    }

}