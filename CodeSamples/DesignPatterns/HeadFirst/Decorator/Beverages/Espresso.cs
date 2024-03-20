using System;

namespace HeadFirst.Decorator.Beverages
{
    class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Expresso";
        }
        public override double Cost()
        {
            throw new NotImplementedException();
        }
    }
}
