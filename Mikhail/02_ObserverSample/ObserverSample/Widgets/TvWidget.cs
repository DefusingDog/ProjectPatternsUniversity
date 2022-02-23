using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObserverSample.News;

namespace ObserverSample.Widgets
{
    class TvWidget : IObserver
    {
        private string _tv;
        public void Display()
        {
            Console.WriteLine("TV: {0}", _tv);
        }

        public void Update(string twitter, string lenta, string tv)
        {
            _tv = tv;
            Display();
        }
    }
}
