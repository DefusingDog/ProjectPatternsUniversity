using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FactorySample.Cars;

namespace FactorySample.Facilities
{
    class RuFacility : VolkswagenFacility
    {
        public override Car CarCreator(string type)
        {
            Car car = new Car();


            if (type == "Golf")
            {
                car = new RuGolf();
            }
            else if (type == "Passat")
            {
                car = new RuPassat();
            }
            else if (type == "Touareg")
            {
                car = new RuTouareg();
            }
            else if (type == "Tiguan")
            {
                car = new RuTiguan();
            }
            return car;

        }
    }
}
