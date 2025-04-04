﻿using HeadFirst.Factory.AbstractFactory.Pizza;

namespace HeadFirst.Factory.AbstractFactory
{
    internal abstract class AbstractPizzaStore
    {
        protected abstract AbstractPizza CreatePizza(PizzaTypes pizzaTypes);

        public void OrderPizza(PizzaTypes pizzaTypes)
        {
            var pizzaType = CreatePizza(pizzaTypes);
            pizzaType.Prepare();
            pizzaType.Baking();
            pizzaType.Cut();
            pizzaType.Ship();
        }
    }
}
