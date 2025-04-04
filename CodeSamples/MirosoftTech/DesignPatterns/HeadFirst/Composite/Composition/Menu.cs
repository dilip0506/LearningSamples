namespace HeadFirst.Composite.Composition
{
    internal class Menu :
        MenuComponent
    {
        private readonly List<MenuComponent>
            _menuComponents;
        private readonly string _name;

        public Menu(string name)
        {
            _name = name;
            _menuComponents = new();
        }

        public override void Add(MenuComponent menuComponent)
            => _menuComponents.Add(menuComponent);
        public override void Remove(MenuComponent menuComponent)
            => _menuComponents.Remove(menuComponent);

        public override MenuComponent GetChild(int i)
            => _menuComponents[i];
        public override string GetName()
           => _name;
        public override void Print()
        {
            Console.WriteLine(_name);
            foreach (var menu in _menuComponents)
            {
                menu.Print();
            }
        }
    }
}
