﻿using ModelX.Units.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelX
{
    public interface IUnit
    {
        public double Result();
        //TODO : delete
        double Result(Temperature inputUnit);
    }
}