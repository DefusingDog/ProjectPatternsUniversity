using SampleCommand.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            var remote = new RemoteControl();
            remote.SetCommandForButton(1, new MusicCommand(new Music()));
            remote.SetCommandForButton(2, new LightCommand(new Light()));


            string InputNum;
            do
            {
                Console.WriteLine("Выберите какую-нибудь комманду: ");
                Console.WriteLine(remote);
                Console.WriteLine("Ваше действие: ");
                var input = Console.ReadLine();

                int buttonId;
                int.TryParse(input, out buttonId);

                remote.PushButton(buttonId);

                Console.WriteLine("Продолжить y/n");
                InputNum = Console.ReadLine();
            } while (InputNum == "y");
        }
    }
}
