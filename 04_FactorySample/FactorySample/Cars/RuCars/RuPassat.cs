using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactorySample.Cars
{
    public class RuPassat : Car
    {
        public RuPassat()
        {
            Name = "Passat";
            Body = "Sedan";
            Engine = "Petrol";
        }
    }
}
