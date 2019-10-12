using System;
using System.Collections.Generic;
using System.Text;
using APIAggregator.APIConnectors;

namespace APIAggregator
{
    public class ConnectorManager
    {
        private BingConnector _bingConnector;
        private ChuckNorrisJokesConnector _chuckNorrisJokesConnector;

        public  BingConnector BingConnector
        {
            get
            {
                  if (_bingConnector == null)
                    _bingConnector = new BingConnector();

                return _bingConnector;
            }
        }

        public  ChuckNorrisJokesConnector ChuckNorrisJokesConnector
        {
            get
            {
                if (_chuckNorrisJokesConnector == null)
                    _chuckNorrisJokesConnector = new ChuckNorrisJokesConnector();

                return _chuckNorrisJokesConnector;
            }
        }
    }
}
