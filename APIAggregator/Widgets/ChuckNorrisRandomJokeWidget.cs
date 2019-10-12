using System;
using System.Collections.Generic;
using System.Text;

namespace APIAggregator.Widgets
{
    class ChuckNorrisRandomJokeWidget : IWidget
    {
        public int ID { get; private set; }
        private string _text;
        public string Name { get; private set; }

        public ChuckNorrisRandomJokeWidget(int id)
        {
            ID = id;
            Name = "Chuck Norris random joke.";
        }

        public void Display()
        {
            Console.WriteLine(_text);
        }

        public void Update(object sender, CompleteRequestEventArgs e)
        {
                _text = e.Text;
                Display();              
        }

        public void Subscribe(APIAggregator aggregator)
        {
            aggregator.ChuckNorrisRandomJokeEvent += Update;
        }

        public void Unsubscribe(APIAggregator aggregator)
        {
            aggregator.ChuckNorrisRandomJokeEvent -= Update;
        }


    }
}
