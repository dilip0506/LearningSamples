namespace HeadFirst.Decorator.CondimentDecorators
{
    class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override string Description => " Milk";

        public override double Cost()
        {
            return _beverage.Cost() * 0.44;
        }
    }
}
