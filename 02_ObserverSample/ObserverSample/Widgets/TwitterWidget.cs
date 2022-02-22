using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObserverSample.News;

namespace ObserverSample.Widgets
{
    class TwitterWidget: IObserver
    {
        private string _tvvitter;
        public void Display()
        {
            Console.WriteLine("Best Sony Exclusive Game(TVVITTER): {0}", _tvvitter);
        }
        public void Update(string twitter, string lenta, string tv)
        {
            _tvvitter = twitter;
            Display();
        }
    }
}
