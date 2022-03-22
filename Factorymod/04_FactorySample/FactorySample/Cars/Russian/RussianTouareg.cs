using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactorySample.Cars
{
    public class RussianTouareg : Car
    {
        public RussianTouareg()
        {
            Name = "Touareg";
            Body = "Big Crossover";
            Engine = "Gasoline";
        }
    }
}
