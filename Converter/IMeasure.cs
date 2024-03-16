using Converter.Measure.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public interface IMeasure
    {
        public decimal Result<T>(T unit) where T : Enum;
    }
}
