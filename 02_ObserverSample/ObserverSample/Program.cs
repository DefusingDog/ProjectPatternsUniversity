using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObserverSample.News;
using ObserverSample.Widgets;

namespace ObserverSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var newsAggregator = new NewsAggregator();

            var tvvitterWidget = new TwitterWidget();
            var lentaWidget = new LentaWidget();
            var tvWidget = new TvWidget();

            newsAggregator.RegisterObserver(tvvitterWidget);
            newsAggregator.RegisterObserver(lentaWidget);
            newsAggregator.RegisterObserver(tvWidget);

            newsAggregator.NewNewsAvailable();

            Console.WriteLine();

            newsAggregator.NewNewsAvailable();

            Console.ReadLine();
        }
    }
}
