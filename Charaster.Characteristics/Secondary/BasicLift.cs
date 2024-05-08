using System.CodeDom.Compiler;
using ModelX.Setting;
using Newtonsoft.Json;
using Types;

namespace Characteristics
{
    [JsonObject(MemberSerialization.OptIn)]
    public class BasicLift
    {
        public static List<double> data = Settings.BasicLift;

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
                foreach(double bf in data)
                {
                    line = JsonConvert.SerializeObject(basicLift, Formatting.Indented);
                    //outputFile.WriteLine(basicLift.BasicValue.Point++);
                    outputFile.WriteLine(line);
                }
            }
        }

        [JsonProperty("BL")]
        public double Value => (data ?? [0])[BasicValue?.Point - 1 ?? 0];
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