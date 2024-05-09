using System.CodeDom.Compiler;
using Settings;
using Newtonsoft.Json;
using Types;

namespace Characteristics
{
    [JsonObject(MemberSerialization.OptIn)]
    public class BasicLift
    {   
        public static Setting localSetting = Setting.Load("/home/neko/Документы/ModelX/Tests/bin/Debug/net8.0/Secondary.json");
        public static List<double> basicLiftData = Setting.BasicLift;

        public BasicLift( Basic basic)
        {
            BasicValue = basic;
        }

        public static void Generate()
        {
            string line;
            using (StreamWriter outputFile = new StreamWriter("/home/neko/Документы/ModelX/Tests/bin/Debug/net8.0/BasicLift.json", true))
            {
                Basic strength = new Basic(BasicAttributesType.Strength);
                BasicLift basicLift = new BasicLift(strength);
                basicLift.BasicValue.Point = 1;
                foreach(double bf in basicLiftData)
                {
                    line = JsonConvert.SerializeObject(basicLift, Formatting.Indented);
                    basicLift.BasicValue.Point++;
                    outputFile.WriteLine(line);
                }
            }
        }

        [JsonProperty("BL")]
        public double Value => basicLiftData[BasicValue.Point - 1];
        public Basic BasicValue { get; set; }
        
        [JsonProperty]
        public double None => (int)Encumbrance.None * Value;
        [JsonProperty]
        public double Light => (int)Encumbrance.Light * Value;
        [JsonProperty]
        public double Medium => (int)Encumbrance.Medium * Value;
        [JsonProperty]
        public double Heavy => (int)Encumbrance.Heavy * Value;
        [JsonProperty]
        public double ExtraHeavy => (int)Encumbrance.ExtraHeavy * Value;
    }

}