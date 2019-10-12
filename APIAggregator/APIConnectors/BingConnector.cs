using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace APIAggregator.APIConnectors
{
    public class BingConnector : APIConnectorBase, IAPIConnector
    {
   
        public BingConnector() : base("https://api.cognitive.microsoft.com/bing/v7.0/news/search", "b09a95a0777742898e644a947c83e774")
        {
            this.Headers.Add("Ocp-Apim-Subscription-Key", this._accesKey);
        }

        public override string GetUriQuery(string toSearch)
        {
            return this._uriBase + "?q=" + Uri.EscapeDataString(toSearch);
        }

        public override string Deserialize(string jsonResult)
        {
            dynamic jsonObject = JsonConvert.DeserializeObject(jsonResult);

            return jsonObject["value"][0].name.ToString();
        }
    }
}
