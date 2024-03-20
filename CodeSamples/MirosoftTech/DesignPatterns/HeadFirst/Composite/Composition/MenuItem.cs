namespace HeadFirst.Composite.Composition
{
    internal class MenuItem : MenuComponent
    {
        private readonly string _name;
        public MenuItem(string name)
        {
            _name = name;
        }
        public override string GetName()
          => _name;
        public override void Print()
        {
            Console.WriteLine(_name);
        }
    }
}
