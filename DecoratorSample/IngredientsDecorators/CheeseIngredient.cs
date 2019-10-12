using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorSample.IngredientsDecorators
{
    public class CheeseIngredient : IngredientBase
    {
        public CheeseIngredient(PizzaBase pizzaBase) : base(pizzaBase)
        {
        }

        public override string GetDescription() 
        {
            return base.GetDescription() + " +Cheese";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 100;
        }
    }
}
