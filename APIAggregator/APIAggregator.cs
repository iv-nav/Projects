using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using APIAggregator.APIConnectors;
using APIAggregator.Widgets;
using System.Threading.Tasks;
using System.ComponentModel;

namespace APIAggregator
{
    public delegate void CompleteRequestEventtHandler(object sender, CompleteRequestEventArgs e);

    public class APIAggregator
    {
        public Dictionary<string, IAPIConnector> connectorSet { get; set; }
        private ConnectorManager connectorManager;
        protected EventHandlerList handlerList = new EventHandlerList();

        public APIAggregator()
        {
            connectorSet = new Dictionary<string, IAPIConnector> { };
            connectorManager = new ConnectorManager();
        }

        public void RandomChuckNorrisJoke()
        {
            string result = "";
            string toSearch = "";

            IAPIConnector connector = connectorManager.ChuckNorrisJokesConnector;
            //await Task.Run(() => this.Request(connector, toSearch, out result));
            Request(connector, toSearch, out result);

            CompleteRequestEventtHandler handler = (CompleteRequestEventtHandler)handlerList["ChuckNorrisRandomJoke"];

            if (handler != null)
            {
                CompleteRequestEventArgs args = new CompleteRequestEventArgs();
                args.Text = result;
                handler.Invoke(this, args);
            }
         
        }

        private void Request(IAPIConnector connector, string toSearch, out string result)
        {

            string jsonValue = "";

            try
            {
                WebRequest request = WebRequest.Create(connector.GetUriQuery());

                foreach (var header in connector.Headers)
                    request.Headers[header.Key] = header.Value;

                HttpWebResponse responce = (HttpWebResponse)request.GetResponseAsync().Result;

                string json = new StreamReader(responce.GetResponseStream()).ReadToEnd();
                jsonValue = connector.Deserialize(json);

            }
            catch (Exception e)
            {
                jsonValue = string.Empty;
            }
            finally
            {
                result = jsonValue;
            }
        }

        public event CompleteRequestEventtHandler ChuckNorrisRandomJokeEvent
        {
            add
            {
                handlerList.AddHandler("ChuckNorrisRandomJoke", value);
            }
            remove
            {
                handlerList.RemoveHandler("ChuckNorrisRandomJoke", value);
            }
        }

        public event CompleteRequestEventtHandler BingEvent
        {
            add
            {
                handlerList.AddHandler("Bing", value);
            }
            remove
            {
                handlerList.RemoveHandler("Bing", value);
            }
        }

    }

    public class CompleteRequestEventArgs : EventArgs
    {
        public string Text { get; set; }
    }

}