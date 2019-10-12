using System;
using System.Collections.Generic;
using System.Text;

namespace StrategySample
{
    class SimpleFly : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I can fly");
        }
    }
}
