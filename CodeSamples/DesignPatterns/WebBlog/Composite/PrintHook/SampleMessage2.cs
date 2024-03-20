namespace WebBlog.Composite.PrintHook
{
    internal class SampleMessage2 : IPrintMessage
    {
        public void Print()
        {
            Console.WriteLine("SampleMessage2");
        }
    }
}
