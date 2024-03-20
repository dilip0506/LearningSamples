using HeadFirst.Factory.AbstractFactory.Ingredient;

namespace HeadFirst.Factory.AbstractFactory.IngredientFactory
{
    interface IPizzaIngredientFactory
    {
        public IDough CreateDough();

        public ICalm CreateCalm();

        public ICheese CreateCheese();
    }
}
