namespace HeadFirst.Factory.AbstractFactory.Ingredient
{
    internal class TexasCheese : ICheese
    {
        public TexasCheese()
        {
            PrintName();
        }
        public void PrintName()
        {
            Console.WriteLine("Texas Chess");
        }
    }
}
