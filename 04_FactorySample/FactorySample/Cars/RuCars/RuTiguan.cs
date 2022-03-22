using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactorySample.Cars
{
    public class RuTiguan : Car
    {
        public RuTiguan()
        {
            Name = "Tiguan";
            Body = "Crossover";
            Engine = "Petrol";
        }
    }
}
