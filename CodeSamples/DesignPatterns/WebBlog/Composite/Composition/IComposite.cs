namespace WebBlog.Composite.Composition
{
    internal interface IComposite
    {
        void Add(IComponent menuComponent);
        IComponent GetChild(int i);
        void Remove(IComponent menuComponent);
    }
}