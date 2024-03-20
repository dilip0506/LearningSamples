namespace WebBlog.Composite.PrintHook
{
    internal class SampleMessage1 : IPrintMessage
    {
        public void Print()
        {
            Console.WriteLine("SampleMessage1");
        }
    }
}
