using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace APIAggregator.APIConnectors 
{
    public class ChuckNorrisJokesConnector : APIConnectorBase, IAPIConnector
    {
        public ChuckNorrisJokesConnector() : base("http://api.icndb.com/jokes/random")
        {

        }

        public override string Deserialize(string jsonResult)
        {
            dynamic jsonObject = JsonConvert.DeserializeObject(jsonResult);

            return jsonObject["value"]["joke"].ToString();
        }

    }
}
