using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactorySample.Cars
{
    public class RuGolf : Car
    {
        public RuGolf()
        {
            Name = "Golf";
            Body = "Hatchback";
            Engine = "Petrol";

        }
    }
}
