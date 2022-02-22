using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObserverSample.Widgets;

namespace ObserverSample.News
{
    public class NewsAggregator:INewsAgregator
    {
        private List<IObserver> _observers;

        private static Random _random;

        public NewsAggregator()
        {
            _random = new Random();

            _observers = new List<IObserver>();

        }

        public string GetTwitterNews()
        {
            var news = new List<string>
                           {
                               "Horizon: Forbidden West 10/10",
                               "Microsoft купили Google",
                               "BLM"
                           };

            return news[_random.Next(3)];
        }

        public string GetLentaNews()
        {
            var news = new List<string>
                           {
                               "Коля Шашлов поступил в магистратуру ИБ",
                               "Панорама закрылась",
                               "Чтобы перестать тосковать - достаточно всего лишь . . ."
                           };

            return news[_random.Next(3)];
        }

        public string GetTvNews()
        {
            var news = new List<string>
                           {
                               "Русских пытаются убить!",
                               "Путин приготовил ответную пилюлю Западу",
                               "Малышева уехала в Крым"
                           };

            return news[_random.Next(3)];
        }

        public void NewNewsAvailable()
        {
            string twitter = GetTwitterNews();
            string lenta = GetLentaNews();
            string tv = GetTvNews();

            NotifyObserver();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObject(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObserver()
        {
            string twitter = GetTwitterNews();
            string lenta = GetLentaNews();
            string tv = GetTvNews();

            foreach( IObserver observer in _observers)
                observer.Update(twitter, lenta, tv);            
        }
    }
}
