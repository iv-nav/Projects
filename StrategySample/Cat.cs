using System;
using System.Collections.Generic;
using System.Text;

namespace StrategySample
{
    class Cat : AnimalBase
    {
        public Cat() : base("Cat")
        {
            walkingBehavior = new SimpleWalk();
        }

        public override void Say()
        {
            Console.WriteLine("Meow");
        }
    }
}
