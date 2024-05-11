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
        }
        
        public static void Generate()
        {
            string line = string.Empty;
            using (StreamWriter outputFile = new StreamWriter(Global.Setting.BasicLift.Generate))
            {
                Dictionary<int, BasicLift> outputData = new(){};
                int strength = 1;   

                foreach (double item in Global.Setting.BasicLift.Data)
                {
                    Basic strengthValue = new Basic(BasicAttributesType.Strength, strength);
                    BasicLift basicLift = new BasicLift(strengthValue);
                    outputData.Add(strength++, basicLift);
                }

                line = JsonConvert.SerializeObject(outputData, Formatting.Indented);
                outputFile.WriteLine(line);
            }
        }

        [JsonProperty("BasicLift")]
        public double Value {
            get => Global.Setting.BasicLift.Data[Basic.Point-1];
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