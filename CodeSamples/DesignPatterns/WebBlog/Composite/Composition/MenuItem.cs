using WebBlog.Composite.PrintHook;

namespace WebBlog.Composite.Composition
{
    internal class MenuItem : IComponent
    {
        private readonly IPrintMessage _printMessage;

        public MenuItem(IPrintMessage printMessage)
        {
            _printMessage = printMessage;
        }

        public void Operation()
        {
            _printMessage.Print();
        }
    }
}
