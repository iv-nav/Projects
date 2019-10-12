using System;
using System.Collections.Generic;
using System.Text;

namespace StrategySample
{
    class SimpleWalk : IWalkable
    {
        public void Walk()
        {
            Console.WriteLine("I can walk");
        }
    }
}
