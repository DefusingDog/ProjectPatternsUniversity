using System;
using DecoratorSample.Beverage;
using DecoratorSample.Decorator;

namespace DecoratorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            BeverageBase espresso = new Espresso();
            BeverageBase blackTea = new BlackTea();
            BeverageBase greenTea = new GreenTea();

            PrintBeverage(espresso);
            PrintBeverage(blackTea);
            PrintBeverage(greenTea);

            Console.WriteLine("-----------");

            Console.ReadLine();

            BeverageBase Pilk = new Milkers(new Espresso());
            PrintBeverage(Pilk);

            Console.WriteLine("-----------");

            Console.ReadLine();
            BeverageBase PilkSugar = new Sugar(Pilk);
            PrintBeverage(PilkSugar);

            Console.WriteLine("-----------");

            Console.ReadLine();
        }


        static void PrintBeverage(BeverageBase beverage)
        {
            Console.WriteLine("Beverage: {0}; Price: {1}",
                beverage.GetDescription(), beverage.GetCost());
        }
    }
}
