using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObserverSample.News;

namespace ObserverSample.Widgets
{
    class LentaWidget: IObserver
    {
        private string _lenta;
        public void Display()
        {
            Console.WriteLine("LeNtA: {0}", _lenta);
        }
        public void Update(string twitter, string lenta, string tv)
        {
            _lenta = lenta;
            Display();
        }
    }
}
