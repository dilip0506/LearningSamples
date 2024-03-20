namespace HeadFirst.Decorator.CondimentDecorators
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description => _beverage.Description + " Mocha";

        public override double Cost()
        {
            return _beverage.Cost() + 0.15;
        }
    }
}
