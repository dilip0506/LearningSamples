namespace WebBlog.ChainOfResponsibilities.Handler
{
    internal class NullValueHandler : BaseHandler<IWalker>
    {
        public override IHandler<IWalker>? Handle(IWalker employee)
        {
            if (employee.Name != null)
            {
                return base.Handle(employee);
            }
            employee.Name = "is Null";
            Console.WriteLine(employee.Name);
            return base.Handle(employee);
        }
    }
}
