namespace HeadFirst.Factory.AbstractFactory.Ingredient
{
    internal class NewYorkCheese : ICheese
    {
        public NewYorkCheese()
        {
            PrintName();
        }
        public void PrintName()
        {
            Console.WriteLine("NewYork Chess");
        }
    }
}
