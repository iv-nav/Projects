using System;
using System.Collections.Generic;
using System.Text;

namespace APIAggregator.APIConnectors
{
    public interface IAPIConnector
    {
        Dictionary<string, string> Headers { get; }

        string GetUriQuery();
        string Deserialize(string jsonResult);
        void Authorize();
    }
}
