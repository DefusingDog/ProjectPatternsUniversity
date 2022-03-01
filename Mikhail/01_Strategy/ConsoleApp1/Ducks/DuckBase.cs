using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Ducks
{
    public abstract class  DuckBase
    {
        public void Quack()
        {
            Console.WriteLine("Quack! Quack!");
        }

        public void Swim()
        {
            Console.WriteLine("I'm swimming -_-_-");
        }

        public abstract void Display();
    }
}
