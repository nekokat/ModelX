using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelX.Units.Type
{
    public enum Weight
    {
        //Metric
        gigatonne,
        megatonne,
        tonne,
        kilogramm,
        gramm,
        milligramm,
        microgram,
        nanogram,
        picogram,
        gt = gigatonne,
        mt = megatonne,
        kg = kilogramm,
        g = gramm,
        mg = milligramm,
        um = microgram,
        ng = nanogram,
        pg = picogram,
        //Imperial
        USton,
        UKton,
        pound,
        ounce,
        lb = pound,
        oz = ounce
    }
}
