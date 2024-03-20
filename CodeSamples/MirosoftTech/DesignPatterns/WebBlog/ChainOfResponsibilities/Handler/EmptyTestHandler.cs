namespace WebBlog.ChainOfResponsibilities.Handler
{
    internal class EmptyTestHandler : BaseHandler<IWalker>
    {
        public override IHandler<IWalker>? Handle(IWalker employee)
        {
            if (employee.Name != "")
            {
                return base.Handle(employee);
            }
            employee.Name = "Is not Provides";
            Console.WriteLine(employee.Name);
            return base.Handle(employee);
        }
    }
}
