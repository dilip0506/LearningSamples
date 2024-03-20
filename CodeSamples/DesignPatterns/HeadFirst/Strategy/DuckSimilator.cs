namespace HeadFirst.Strategy
{
    public static class DuckSimilator
    {
        public static void Run()
        {
            var naughtDuck = new NaughtyDuck();
            naughtDuck.PrintName();
            naughtDuck.PerformFly();
            naughtDuck.PerformQuack();

            var rubberDuck = new RubberDuck();
            rubberDuck.PrintName();
            rubberDuck.PerformFly();
            rubberDuck.PerformQuack();
        }
    }
}
