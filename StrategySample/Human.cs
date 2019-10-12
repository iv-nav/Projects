using System;
using System.Collections.Generic;
using System.Text;

namespace StrategySample 
{
    public class Human : AnimalBase
    {
        public Human() : base("Human")
        {
            walkingBehavior = new TwoLegsWalk();
            swimmingBehavior = new SimpleSwim();
        }

        public override void Say()
        {
            Console.WriteLine("Hi, how it's going?");
        }
    }
}
