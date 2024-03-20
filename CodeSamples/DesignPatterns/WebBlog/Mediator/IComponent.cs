namespace WebBlog.Mediator
{
    internal interface IComponent
    {
        void SetState(object state);
    }
    class Mediator
    {
        internal IComponent Component1 { get; set; }
        internal IComponent Component2 { get; set; }

        internal void ChangeState(object state)
        {
            this.Component1.SetState(state);
            this.Component2.SetState(state);
        }
    }
}
