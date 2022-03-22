using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactorySample.Cars
{
    public class RuTouareg : Car
    {
        public RuTouareg()
        {
            Name = "Touareg";
            Body = "Big Crossover";
            Engine = "Petrol";
        }
    }
}
