using System;

namespace ObserverSample
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsAgregator news = new NewsAgregator();
            Console.WriteLine(news.Search("Microsoft"));

            Console.ReadKey();
        }

    }
}
