using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactorySample.Cars
{
    public class RussianGolf : Car
    {
        public RussianGolf()
        {
            Name = "Golf";
            Body = "Hatchback";
            Engine = "Gasoline";
        }
    }
}
