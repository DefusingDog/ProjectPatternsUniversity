using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactorySample.Cars
{
    public class DeutschTouareg : Car
    {
        public DeutschTouareg()
        {
            Name = "Touareg";
            Body = "Big Crossover";
            Engine = "Disel";
        }
    }
}
