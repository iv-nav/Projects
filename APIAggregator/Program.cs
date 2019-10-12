using System;
using APIAggregator.Widgets;
using System.Collections.Generic;

namespace APIAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            APIAggregator aggregator = new APIAggregator();

            int widgetCounter = 0;

            //ChuckNorrisRandomJokeWidget
            Dictionary<int, IWidget> widgets = new Dictionary<int, IWidget>();
            ChuckNorrisRandomJokeWidget chuckNorrisRandomJokeWidget = new ChuckNorrisRandomJokeWidget(widgetCounter);
            chuckNorrisRandomJokeWidget.Subscribe(aggregator);
            widgets.Add(widgetCounter++, chuckNorrisRandomJokeWidget);

            foreach(var item in widgets)
                Console.WriteLine($"[{item.Key}] - {item.Value}");

            var userInput = Console.ReadKey();
            //int key = int.Parse(userInput.Key.ToString());

            if (userInput.KeyChar == '0')
            {
                aggregator.RandomChuckNorrisJoke();
                Console.WriteLine();
            }
            
            Console.ReadKey();

        }
    }
}
