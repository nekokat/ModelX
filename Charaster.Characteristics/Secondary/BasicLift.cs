using System.CodeDom.Compiler;
using ModelX.Setting;
using Newtonsoft.Json;

namespace Characteristics
{
    [JsonObject(MemberSerialization.OptIn)]
    public class BasicLift
    {
        public static double[]? data = Settings.BasicLift;

        public BasicLift( Basic basic)
        {
            BasicValue = basic;
        }

        public void Generate()
        {
            int strength = 1;
            string line;
            using (StreamWriter outputFile = new StreamWriter("WriteLines.txt"))
            {
                foreach(double bf in data)
                {
                    line = JsonConvert.SerializeObject(this, Formatting.Indented);
                    outputFile.WriteLine(strength++);
                    outputFile.WriteLine(line);
                }
            }
        }

        [JsonProperty("BL")]
        public double Value => (data ?? [0])[BasicValue?.Point - 1 ?? 0];
        public Basic? BasicValue { get; set; }
        
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