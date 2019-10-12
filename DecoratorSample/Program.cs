using System;
using DecoratorSample.IngredientsDecorators;

namespace DecoratorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaBase peperoni = new SalamiIngredient(new CheeseIngredient(new Pizza()));

            Console.WriteLine(peperoni.GetDescription() + " Price: " + peperoni.GetPrice());
            Console.ReadKey();
        }
    }
}
