using System;
using System.Collections.Generic;
using System.Text;

namespace StrategySample
{
    class Fish : AnimalBase
    {
        public Fish() : base("Fish")
        {
            swimmingBehavior = new SimpleSwim();
        }
    }
}
