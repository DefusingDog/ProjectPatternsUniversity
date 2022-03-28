using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCommand
{
    public enum State
    {
        On,
        Off
    }

    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Свет включена");
            State = State.On;
        }

        public void TurnOff()
        {
            Console.WriteLine("Свет выключена");
            State = State.Off;
        }

        public State State
        {
            get; set;
        }
    }
}
