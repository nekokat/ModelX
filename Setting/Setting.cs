using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;


namespace ModelX.Setting
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Settings
    {
        //TODO: Create reading from json
        [JsonProperty("BasicLift")]
        public static List<double> BasicLift => FromJson<List<double>>("Secondary.json");

        public static T? FromJson<T>(string filename)
        {
            T? result;
            using (StreamReader r = new(filename))
            {
                string json = r.ReadToEnd();
                result = JsonConvert.DeserializeObject<T?>(json);
            }
            return result;
        }
    }
}