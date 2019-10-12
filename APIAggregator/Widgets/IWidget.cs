using System;
using System.Collections.Generic;
using System.Text;

namespace APIAggregator.Widgets
{
    public interface IWidget
    {
        int ID { get; }
        string Name { get; }

        void Display();
        void Update(object sender, CompleteRequestEventArgs e);
        void Subscribe(APIAggregator aggregator);
        void Unsubscribe(APIAggregator aggregator);
    }
}
