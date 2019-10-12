using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorSample.IngredientsDecorators
{
    public abstract class IngredientBase : PizzaBase
    {
        private PizzaBase _pizzaBase;

        public IngredientBase(PizzaBase pizzaBase)
        {
            _pizzaBase = pizzaBase;    
        }

        public override string GetDescription()
        {
            return _pizzaBase.GetDescription();
        }

        public override double GetPrice()
        {
            return _pizzaBase.GetPrice();
        }

    }
}
