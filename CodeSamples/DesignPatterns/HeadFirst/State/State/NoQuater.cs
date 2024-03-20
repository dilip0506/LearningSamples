namespace HeadFirst.State.State
{
    internal class NoQuater : IState
    {
        private readonly GumballMachine _gumballMachine;

        public NoQuater(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispence()
        {
            Console.WriteLine("You nedd to pay first");
        }

        public void EjectQuater()
        {
            Console.WriteLine("You haven't inserted a quater");
        }

        public void InsertQuater()
        {
            Console.WriteLine("You inserted a quater");
            _gumballMachine.SetState(_gumballMachine.HasQuater);
        }

        public void Refill()
        {
            Console.WriteLine("Is not empty");
        }

        public void TrunkCrank()
        {
            Console.WriteLine("You turned but there is no quater");
        }
    }
}
