using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorSample.IngredientsDecorators
{
    class SalamiIngredient : IngredientBase
    {
        public SalamiIngredient(PizzaBase pizzaBase) : base(pizzaBase)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " +Salami";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 200;
        }
    }
}
