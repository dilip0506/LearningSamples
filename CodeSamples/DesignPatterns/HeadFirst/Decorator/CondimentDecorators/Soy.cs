namespace HeadFirst.Decorator.CondimentDecorators
{
    class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override string Description => _beverage.Description + " Soy";

        public override double Cost()
        {
            return 0.67;
        }
    }
}
