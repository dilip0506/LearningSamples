using WebBlog.Composite.Composition;
using WebBlog.Composite.PrintHook;

namespace WebBlog.Composite
{
    public static class TestRunner
    {
        public static void Run()
        {
            var allMenu = new MenuComposite(new SampleMessage1());
            allMenu.Add(new MenuItem(new SampleMessage2()));
            var item = new MenuComposite(new SampleMessage3());
            item.Add(new MenuItem(new SampleMessage1()));
            allMenu.Add(item);
            allMenu.Operation();
        }
    }
}
