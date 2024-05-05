using System.CodeDom.Compiler;

namespace Characteristics
{
    public class BasicLift
    {
        private readonly double[] data = [0.2, 0.8, 1.8, 3.2, 5, 7.2, 9.8, 13, 16, 20, 24, 29, 34, 39, 45, 51, 58, 65, 72, 80];

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