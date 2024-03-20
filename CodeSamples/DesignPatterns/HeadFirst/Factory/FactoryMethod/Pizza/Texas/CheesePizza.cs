namespace HeadFirst.Factory.FactoryMethod.Pizza.Texas
{
    internal class CheesePizza : AbstractPizza
    {
        public override void Cut()
        {
            Console.WriteLine("Cut in Taxes");
        }
    }
}
