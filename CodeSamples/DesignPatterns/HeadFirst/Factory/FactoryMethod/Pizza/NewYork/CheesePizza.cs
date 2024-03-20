namespace HeadFirst.Factory.FactoryMethod.Pizza.NewYork
{
    internal class CheesePizza : AbstractPizza
    {
        public override void Cut()
        {
            Console.WriteLine("Cut in NewYork");
        }
    }
}
