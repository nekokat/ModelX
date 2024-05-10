using System.CodeDom.Compiler;
using Settings;
using Newtonsoft.Json;
using Types;

namespace Characteristics
{
    [JsonObject(MemberSerialization.OptIn)]
    public class BasicLift
    {

        public BasicLift( Basic basic)
        {
            Basic = basic;
            Setting.Load("/run/media/neko/files/ModelX/Tests/bin/Debug/net8.0/Setting.json");
        }
        
        public static void Generate()
        {
            string line = string.Empty;
            Setting.Load("/run/media/neko/files/ModelX/Tests/bin/Debug/net8.0/Setting.json");
            
            using (StreamWriter outputFile = new StreamWriter(Setting.BasicLift.Generate))
            {
                Basic strength = new Basic(BasicAttributesType.Strength, 1);
                BasicLift basicLift = new BasicLift(strength);
                Dictionary<string, BasicLift> outputData = new(){};
                

                foreach(double basicLiftValue in Setting.BasicLift.Data)
                {
                    outputData.Add($"{basicLift.Basic.Point++}", basicLift);
                }

                line = JsonConvert.SerializeObject(outputData, Formatting.Indented);
                outputFile.WriteLine(line);
            }
        }

        [JsonProperty("BasicLift")]
        public double Value {
            get => Setting.BasicLift.Data[Basic.Point];
            set => Value = value;
        }

        public Basic Basic { get; set; }
        
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