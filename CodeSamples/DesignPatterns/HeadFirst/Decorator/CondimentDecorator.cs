namespace HeadFirst.Decorator
{
    /*
     This should implement Interface IBeverage instead of abstact class, as per book example I extended Beverage
     an interface is already create this class should implement it to handle types
     */
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage _beverage;
        public override abstract string Description { get; }
    }
}
