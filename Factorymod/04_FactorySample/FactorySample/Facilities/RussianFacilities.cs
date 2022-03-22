using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FactorySample.Cars;

namespace FactorySample.Facilities
{
    class RussianFacilities : VolkswagenFacility
    {
        public override Car CreateCar(string type)
        {
            Car car = new Car();
            if (type == "Golf")
            {
                car = new RussianGolf();
            }
            else if (type == "Passat")
            {
                car = new RussianPassat();
            }
            else if (type == "Tiguan")
            {
                car = new RussianTiguan();
            }
            else if (type == "Touareg")
            {
                car = new RussianTouareg();
            }

            return car;

        }
    }
}
