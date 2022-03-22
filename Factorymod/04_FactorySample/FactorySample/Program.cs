using System;
using FactorySample.Facilities;
using FactorySample.Factory;

namespace FactorySample
{
    class Program
    {
        static void Main(string[] args)
        {
            RussianFacilities ruFactory = new RussianFacilities();
            DeutschFacilities deFactory = new DeutschFacilities();
            
            ruFactory.GetCar("Golf");
            Console.WriteLine();
            deFactory.GetCar("Golf");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
