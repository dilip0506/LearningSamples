namespace WebBlog.Delegate
{
    public class DelegateTacker : IDelegateTaker
    {
        public string PrintThis { get; init; } = String.Empty;

        void IDelegateTaker.PrintThis()
        {
            Console.WriteLine(PrintThis);
        }
    }
}
