namespace HeadFirst.Composite.Composition
{
    internal class Waitress
    {
        private readonly MenuComponent _menuComponent;

        public Waitress(MenuComponent menuComponent)
        {
            _menuComponent = menuComponent;
        }

        public void PrintMenu()
        {
            _menuComponent.Print();
        }
    }
}
