using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http;

namespace APIAggregator.APIConnectors
{
    class BhagavatGitaConnector : APIConnectorBase, IAPIConnector 
    {
        protected internal string _clientID;

        public BhagavatGitaConnector() : base("https://bhagavadgita.io")
        {
            this._accesKey = "wjVB5JTkAEIgJTF5vwlRZryWt14hXbaFuHEngsKyjtqY471BO9";
            this._clientID = "N25DJEGIB7GpFSjj28LZVRL2p7mt4mrsxqU6vOLR";
        }

        public override void Authorize()
        {
            //var mesage = new HttpRequestMessage(HttpMethod.Post, $"{this._uriBase}/auth/oauth/token");

            //mesage.Headers.Add("accept", "application/json");
            //mesage.Headers.Add("content-type", "application/x-www-form-urlencoded");

            //HttpWebResponse responce = (HttpWebResponse)request.GetResponseAsync().Result;

            //string json = new StreamReader(responce.GetResponseStream()).ReadToEnd();
            //jsonValue = connector.Deserialize(json);
        }




    }
}
