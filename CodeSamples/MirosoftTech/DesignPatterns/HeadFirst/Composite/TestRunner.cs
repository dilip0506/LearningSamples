using HeadFirst.Composite.Composition;

namespace HeadFirst.Composite
{
    public static class TestRunner
    {
        public static void Run()
        {
            var allMenu = new Menu("Narsimha");
            allMenu.Add(new MenuItem("Dilip"));
            allMenu.Add(new MenuItem("Dinesh"));
            var dinesh = new Menu("Dinesh");
            dinesh.Add(new MenuItem("Sarayu"));
            allMenu.Add(dinesh);
            allMenu.Print();
        }
    }
}
