using System.CodeDom.Compiler;
using ModelX.Setting;
using Newtonsoft.Json;

namespace Characteristics
{
    public class BasicLift
    {
        public static double[]? data = Settings.BasicLift;

        public BasicLift( Basic basic)
        {
            BasicValue = basic;
        }

        public double Value => data[BasicValue?.Point - 1 ?? 0];
        public Basic? BasicValue { get; set; }

        public double None => (int)Encumbrance.None * Value;
        public double Light => (int)Encumbrance.Light * Value;
        public double Medium => (int)Encumbrance.Medium * Value;
        public double Heavy => (int)Encumbrance.Heavy * Value;
        public double ExtraHeavy => (int)Encumbrance.ExtraHeavy * Value;
    }

}