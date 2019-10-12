using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ObserverSample
{
    class NewsAgregator
    {
        public const string accesKey = "b09a95a0777742898e644a947c83e774";
        public const string uribase = "https://api.cognitive.microsoft.com/bing/v7.0/news/search";

        public string Search(string toSearch)
        {
            SearchResult searchResult = this.BingNewsSearch(toSearch);
            dynamic jsonObject = JsonConvert.DeserializeObject(searchResult.jsonResult);

            return jsonObject["value"][0].name.ToString();

        }

        private SearchResult BingNewsSearch(string toSearch)
        {
            var uriQueri = uribase + "?q=" + Uri.EscapeDataString(toSearch);
            WebRequest request = WebRequest.Create(uriQueri);
            request.Headers["Ocp-Apim-Subscription-Key"] = accesKey;
            HttpWebResponse response = (HttpWebResponse)request.GetResponseAsync().Result;
            string json = new StreamReader(response.GetResponseStream()).ReadToEnd();

            // Create the result object for return
            var searchResult = new SearchResult()
            {
                jsonResult = json,
                relevantHeaders = new Dictionary<string, string>()
            };

            // Extract Bing HTTP headers
            foreach (string header in response.Headers)
            {
                if (header.StartsWith("BingAPIs-") || header.StartsWith("X-MSEdge-"))
                    searchResult.relevantHeaders[header] = response.Headers[header];
            }

            return searchResult;
        }
    }

    public struct SearchResult
    {
        public string jsonResult;   
        public Dictionary<string, string> relevantHeaders;
    }
}
