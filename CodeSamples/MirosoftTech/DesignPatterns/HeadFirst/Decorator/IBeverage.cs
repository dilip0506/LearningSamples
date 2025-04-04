namespace HeadFirst.Decorator
{
    //Can use this interface for type management not use because of text book example
    public interface IBeverage
    {
        public string Description { get; set; }
        public double Cost();
    }
}
