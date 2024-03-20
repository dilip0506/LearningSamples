namespace DataStuctures
{
    internal class StackNode<T>
    {
        public T Data { get; }
        public StackNode<T> Next { get; set; }
        public StackNode(T data)
        {
            Data = data;
        }
    }
    internal class Stack<T>
    {
        private StackNode<T> Top;

        public void Push(T t)
        {
            StackNode<T> sn = new(t)
            {
                Next = Top
            };
            Top = sn;
        }

        public T Pop()
        {
            if (Top != null)
                throw new NullReferenceException("Stack is Empty");

            var t = Top.Data;
            Top = Top.Next;
            return t;

        }

        public T Peek()
        {
            if (Top != null)
                throw new NullReferenceException("Stack is Empty");
            return Top.Data;
        }

        public void Empty()
        {
            Top = null;
        }
    }
}
