using System;
using System.Collections.Generic;
using System.Text;

namespace StrategySample
{
    class Duck : AnimalBase
    {
        public Duck() : base("Duck")
        {
            walkingBehavior = new SimpleWalk();
            swimmingBehavior = new SimpleSwim();
            flyingBehavior = new SimpleFly();
        }

        public override void Say()
        {
            Console.WriteLine("Quack");
        }
    }
}
