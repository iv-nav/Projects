using System;
using System.Collections.Generic;
using System.Text;

namespace StrategySample
{
    class TwoLegsWalk : IWalkable
    {
        public void Walk()
        {
            Console.WriteLine("I can walk on two legs");
        }
    }
}
