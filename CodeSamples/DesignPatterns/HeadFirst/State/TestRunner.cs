namespace HeadFirst.State
{
    public class TestRunner
    {
        public static void Run()
        {
            GumballMachine gumball = new(2);
            gumball.InsertQuater();
            gumball.Trunk();
            gumball.InsertQuater();
            gumball.Trunk();
            gumball.InsertQuater();
            gumball.Trunk();
            gumball.Refill(2);
            gumball.InsertQuater();
            gumball.Trunk();
            gumball.InsertQuater();
            gumball.Trunk();
            gumball.InsertQuater();
            gumball.Trunk();
        }
    }
}
