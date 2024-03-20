namespace HeadFirst.Decorator.Beverages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark Roast";
        }
        public override double Cost()
        {
            return 0.99;
        }
    }
}
