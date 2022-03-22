using System;
using FactorySample.Facilities;
using FactorySample.Factory;


namespace FactorySample
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleFactory sampleF = new SampleFactory();
            RuFacility facility = new RuFacility();

            facility.GetCar("Golf");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
