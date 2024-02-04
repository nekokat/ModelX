using ModelX.Measure.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelX
{
    public interface IMeasure
    {
        public double Result<T>(T type) where T : Enum;
    }
}
