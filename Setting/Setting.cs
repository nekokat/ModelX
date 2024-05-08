using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;


namespace Settings
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Setting
    {
        //TODO: Create reading from json
        [JsonProperty("BasicLift")]
        public double[] BasicLift {get; set;}
    }
}