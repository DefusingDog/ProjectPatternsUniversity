using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCommand.Command
{
    public class LightCommand : ICommand
    {
        private Light _light;

        public LightCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }

        public void Undo()
        {
            _light.TurnOff();
        }

        public override string ToString()
        {
            return "Включить свет";
        }
    }
}
