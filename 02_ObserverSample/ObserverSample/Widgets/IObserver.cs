using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverSample.Widgets
{
    public interface IObserver
    {       
        void Display();
        void Update(string twitter, string lenta, string tv);
        
    }
}
