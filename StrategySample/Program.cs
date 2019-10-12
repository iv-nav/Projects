using System;
using System.Collections.Generic;

namespace StrategySample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AnimalBase> animals = new List<AnimalBase>();

            animals.Add(new Cat());
            animals.Add(new Duck());
            animals.Add(new Human());
            animals.Add(new Fish());

            foreach (var animal in animals)
            {
                animal.Represent();
                animal.Walk();
                animal.Swim();
                animal.Fly();
                animal.Say();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
