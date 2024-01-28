using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelX.Units.Type
{
    public enum Area
    {
        SquareKilometer,
        SquareHectometer,
        SquareDecameter,
        SquareMeter,
        SquareDecimeter,
        SquareCentimeter,
        SquareMillimeter,
        //Imperial    
        Perch,
        Rood,
        Acre,
        SquareMile,
        //Mertic Aliases    
        Hectare = SquareHectometer,    
        ha = SquareHectometer,
        Are = SquareDecameter,    
        a = SquareDecameter,    
        Centiare = SquareMeter,    
        ca = SquareMeter
    }
}
