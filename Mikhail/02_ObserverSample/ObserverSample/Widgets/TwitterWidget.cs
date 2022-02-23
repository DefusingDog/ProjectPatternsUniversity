using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObserverSample.News;

namespace ObserverSample.Widgets
{
    class TwitterWidget : IObserver
    {
        private string _twitter;
        public void Display()
        {
            Console.WriteLine("Twitter: {0}", _twitter);
        }

        public void Update(string twitter, string lenta, string tv)
        {
            _twitter = twitter;
            Display();
        }
    }
}
