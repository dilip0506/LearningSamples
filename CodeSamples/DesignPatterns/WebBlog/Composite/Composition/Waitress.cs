namespace WebBlog.Composite.Composition
{
    internal class Waitress
    {
        private readonly IComponent _menuComponent;

        public Waitress(IComponent menuComponent)
        {
            _menuComponent = menuComponent;
        }

        public void PrintMenu()
        {
            _menuComponent.Operation();
        }
    }
}
