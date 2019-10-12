using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorSample
{
    class Pizza : PizzaBase
    {
        public override string GetDescription()
        {
            return "Pizza base";
        }

        public override double GetPrice()
        {
            return 50;
        }
    }
}
