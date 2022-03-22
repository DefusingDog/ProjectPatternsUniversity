using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactorySample.Cars
{
    public class DeutschGolf : Car
    {
        public DeutschGolf()
        {
            Name = "Golf";
            Body = "Hatchback";
            Engine = "Disel";
        }
    }
}
