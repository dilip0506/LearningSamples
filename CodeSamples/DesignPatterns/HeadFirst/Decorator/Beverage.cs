namespace HeadFirst.Decorator
{
    /*
     we can also use an Interface instead of abstact class, as per book example an abstract class is already created
     an interface is already create this class condimentDecorator to hal
     */
    public abstract class Beverage
    {
        public virtual string Description { get; set; }
        public abstract double Cost();
    }
}
