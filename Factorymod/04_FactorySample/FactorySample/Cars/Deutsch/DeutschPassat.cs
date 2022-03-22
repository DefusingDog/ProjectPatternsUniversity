using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactorySample.Cars
{
    public class DeutschPassat : Car
    {
        public DeutschPassat()
        {
            Name = "Passat";
            Body = "Sedan";
            Engine = "Disel";
        }
    }
}
