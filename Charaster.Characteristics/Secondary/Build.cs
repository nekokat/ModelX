using Converter.Measure.Unit;
using Converter;

namespace Characteristics
{
    public class Build
    {

    }
    
    public abstract class Range
    {
        public Type TMeasure { get; set; }
        public Enum RangeUnit { get; set; }

        public double Min { get; set; }
        public double Max { get; set; }

        override public string ToString()
        {
            return $"{Min} - {Max}";
        }
    }

    interface IRange
    {
        //public Type TMeasure { get; set; }
        public Enum RangeUnit { get; set; }
    }

    public class HeightRange : Range, IRange
    {
        public HeightRange()
        {            
            RangeUnit = Length.Foot;
        }
    }

    public class Skinny : Range, IRange
    {
        public Skinny()
        {
            RangeUnit = Weight.Pound;
        }
    }


    public class Average : Range, IRange
    {
        public Average()
        {         
            RangeUnit = Weight.Pound;
        }
    }
    public class Overweight : Range, IRange
    {
        public Overweight()
        {        
            RangeUnit = Weight.Pound;
        }
    }

    public class Fat : Range, IRange
    {
        public Fat()
        {
            RangeUnit = Weight.Pound;
        }
    }

    public class VeryFat : Range, IRange
    {
        public VeryFat()
        {      
            RangeUnit = Weight.Pound;
        }
    }
}