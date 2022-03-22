using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactorySample.Cars
{
    public class RussianTiguan : Car
    {
        public RussianTiguan()
        {
            Name = "Tiguan";
            Body = "Crossover";
            Engine = "Gasoline";
        }
    }
}
