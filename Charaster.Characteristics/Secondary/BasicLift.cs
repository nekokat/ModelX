using System.CodeDom.Compiler;

namespace Characteristics
{
    public class BasicLift
    {
        private readonly double[] data = [0.2, 0.8, 1.8, 3.2, 5, 7.2, 9.8, 13, 16, 20, 24, 29, 34, 39, 45, 51, 58, 65, 72, 80];

        public BasicLift( Basic strength)
        {
            Strength = strength;
        }

        public double BasicValue => data[Strength?.Point - 1 ?? 0];
        public Basic? Strength { get; set; }

        public double None => (int)Encumbrance.None * BasicValue;
        public double Light => (int)Encumbrance.Light * BasicValue;
        public double Medium => (int)Encumbrance.Medium * BasicValue;
        public double Heavy => (int)Encumbrance.Heavy * BasicValue;
        public double ExtraHeavy => (int)Encumbrance.ExtraHeavy * BasicValue;
    }

}