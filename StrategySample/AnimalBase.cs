using System;
using System.Collections.Generic;
using System.Text;

namespace StrategySample
{
    public abstract class AnimalBase
    {
        readonly string _name;
        public IWalkable walkingBehavior;
        public ISwimming swimmingBehavior;
        public IFlyable flyingBehavior;

        public AnimalBase(string name)
        {
            _name = name;
            walkingBehavior = new NoWalk();
            swimmingBehavior = new NoSwim();
            flyingBehavior = new NoFly();
        }

        public void Represent()
        {
            Console.WriteLine($"Hi, I`m {_name}");
        }

        public virtual void Say()
        {
            Console.WriteLine("...");
        }

        public void Walk()
        {
            walkingBehavior.Walk();
        }

        public void Swim()
        {
            swimmingBehavior.Swim();
        }

        public void Fly()
        {
            flyingBehavior.Fly();
        }

    }
}
