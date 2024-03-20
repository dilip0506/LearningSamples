using WebBlog.Composite.PrintHook;

namespace WebBlog.Composite.Composition
{
    internal class MenuComposite :
        IComponent,
        IComposite
    {
        private readonly IPrintMessage _printMessage;

        private readonly List<IComponent>
            _components;

        public MenuComposite(
            IPrintMessage printMessage)
        {
            _components = new();
            _printMessage = printMessage;
        }

        public void Add(IComponent menuComponent)
            => _components.Add(menuComponent);
        public void Remove(IComponent menuComponent)
            => _components.Remove(menuComponent);

        public IComponent GetChild(int i)
            => _components[i];
        public void Operation()
        {
            _printMessage.Print();
            foreach (var component in _components)
            {
                component.Operation();
            }
        }
    }
}
