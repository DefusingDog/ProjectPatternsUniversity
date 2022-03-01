using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObserverSample.Widgets;

namespace ObserverSample.News
{
    public class NewsAggregator : ISubject
    {
        //private static TwitterWidget _twitterWidget;
        //private static LentaWidget _lentaWidget;
        //private static TvWidget _tvWidget;
        private static Random _random;
        private List<IObserver> _observers;

        public NewsAggregator()
        {
            //_twitterWidget = new TwitterWidget();
            //_lentaWidget = new LentaWidget();
            //_tvWidget = new TvWidget();
            _random = new Random();

            _observers = new List<IObserver>();
        }

        public string GetTwitterNews()
        {
            var news = new List<string>
                           {
                               "Новость из Twitter номер 1",
                               "Новость из Twitter номер 2",
                               "Новость из Twitter номер 3"
                           };

            return news[_random.Next(3)];
        }

        public string GetLentaNews()
        {
            var news = new List<string>
                           {
                               "Новость из Lenta номер 1",
                               "Новость из Lenta номер 2",
                               "Новость из Lenta номер 3"
                           };

            return news[_random.Next(3)];
        }

        public string GetTvNews()
        {
            var news = new List<string>
                           {
                               "Новость из TV номер 1",
                               "Новость из TV номер 2",
                               "Новость из TV номер 3"
                           };

            return news[_random.Next(3)];
        }

        public void NewNewsAvailable()
        {
            NotifyObserver();
            //string twitter = GetTwitterNews();
            //string lenta = GetLentaNews();
            //string tv = GetTvNews();

            //_twitterWidget.Update(twitter, lenta, tv);
            //_lentaWidget.Update(twitter, lenta, tv);
            //_tvWidget.Update(twitter, lenta, tv);
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObserver()
        {
            string twitter = GetTwitterNews();
            string lenta = GetLentaNews();
            string tv = GetTvNews();

            //_twitterWidget.Update(twitter, lenta, tv);
            //_lentaWidget.Update(twitter, lenta, tv);
            //_tvWidget.Update(twitter, lenta, tv);

            foreach(var observer in _observers)
            {
                observer.Update(twitter, lenta, tv);
            }
        }
    }
}
