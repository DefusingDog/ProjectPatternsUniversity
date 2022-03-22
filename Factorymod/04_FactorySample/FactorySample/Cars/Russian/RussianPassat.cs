using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactorySample.Cars
{
    public class RussianPassat : Car
    {
        public RussianPassat()
        {
            Name = "Passat";
            Body = "Sedan";
            Engine = "Gasoline";
        }
    }
}
