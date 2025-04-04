namespace HeadFirst.Composite.Composition
{
    internal abstract class MenuComponent
    {

        public virtual void Add(MenuComponent menuComponent)
            => throw new NotImplementedException();

        public virtual void Remove(MenuComponent menuComponent)
           => throw new NotImplementedException();

        public virtual MenuComponent GetChild(int i)
            => throw new NotImplementedException();

        public virtual string GetName()
            => throw new NotImplementedException();

        public virtual void Print()
            => throw new NotImplementedException();
    }
}
