using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverSample.Widgets
{
    public interface INewsAgregator
    {
        void RegisterObserver(IObserver observer);
        void RemoveObject(IObserver observer);
        void NotifyObserver();
    }
}
