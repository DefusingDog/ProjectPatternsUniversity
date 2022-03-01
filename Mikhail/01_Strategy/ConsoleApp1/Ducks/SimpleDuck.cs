using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Ducks
{
    class SimpleDuck : DuckBase
    {
        public override void Display()
        {
            Console.WriteLine("Hi! I'm simple duck.");
        }
    }
}
