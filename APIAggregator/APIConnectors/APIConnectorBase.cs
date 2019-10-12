using System;
using System.Collections.Generic;
using System.Text;

namespace APIAggregator.APIConnectors
{
    public abstract class APIConnectorBase : IAPIConnector
    {
        private static APIConnectorBase instance;

        protected internal readonly string _uriBase;
        protected internal string _accesKey;
        
        public readonly bool _needAuthorization;
        public Dictionary<string, string> Headers { get; private set; }

        public string UriQuery{ get; private set; }

        public APIConnectorBase(string uriBase)
        {
            _uriBase = uriBase;
            _needAuthorization = false;
            _accesKey = "";
        }

        public APIConnectorBase(string uriBase, string accesKey)
        {
            _uriBase = uriBase;
            _needAuthorization = true;
            _accesKey = accesKey;
        }

        public virtual string GetUriQuery()
        {
            return _uriBase;
        }

        public virtual string GetUriQuery(string toSearch)
        {
            return _uriBase;
        }

        public virtual string Deserialize(string jsonResult)
        {
            return jsonResult;
        }

        public virtual void Authorize()
        {

        }
    }
}
