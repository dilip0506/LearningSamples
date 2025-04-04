namespace HeadFirst.Factory.FactoryMethod
{
    internal abstract class AbstractPizza
    {
        public virtual void Prepare()
        {
            Console.WriteLine("Preparing Pizza");
        }

        public virtual void Baking()
        {
            Console.WriteLine("baking Pizza");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cut Pizza");
        }

        public virtual void Ship()
        {
            Console.WriteLine("Ship Pizza");
        }

    }
}
