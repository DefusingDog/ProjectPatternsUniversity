using FactorySample.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactorySample.Factory
{
    class SampleFactory
    {
        public Car GetCar(string type)
        {
            /* Car car = new Car();
             if (type == "Golf")
             {
                 car = new Golf();
             }
             else if (type == "Passat")
             {
                 car = new Passat();
             }
             else if (type == "Tiguan")
             {
                 car = new Tiguan();
             }
             else if (type == "Touareg")
             {
                 car = new Touareg();
             }

             return car; */
            return null;
        }
    }
}
