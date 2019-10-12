using System;
using System.Collections.Generic;
using System.Text;

namespace StrategySample
{
    class SimpleSwim : ISwimming
    {
        public void Swim()
        {
            Console.WriteLine("I can swim");
        }
    }
}
