namespace HeadFirst.Decorator.Beverages
{
    class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf";
        }
        public override double Cost()
        {
            return 0.50;
        }
    }
}
