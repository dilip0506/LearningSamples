namespace HeadFirst.Factory.SimpleFactory.Pizza
{
    internal class CheesePizza : AbstractPizza
    {

        public override void Prepare()
        {
            Console.WriteLine("Cheese Pizza Pizza");
        }

    }
}
