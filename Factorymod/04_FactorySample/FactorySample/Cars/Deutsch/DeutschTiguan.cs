using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactorySample.Cars
{
    public class DeutschTiguan : Car
    {
        public DeutschTiguan()
        {
            Name = "Tiguan";
            Body = "Crossover";
            Engine = "Disel";
        }
    }
}
