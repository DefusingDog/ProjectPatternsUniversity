using ConsoleApp1.Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DuckBase> ducks = new List<DuckBase>();
            ducks.Add(new ExoticDuck());
            ducks.Add(new SimpleDuck());
            
            foreach(var duck in ducks)
            {
                duck.Display();
                duck.Swim();
                duck.Quack();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
