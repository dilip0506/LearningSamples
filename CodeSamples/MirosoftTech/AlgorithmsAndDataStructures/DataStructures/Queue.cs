using System;


namespace DataStuctures
{
    internal class QueueNode<T>
    {
        public T Data { get; }

        public QueueNode<T> Next { get; set; }

        public QueueNode(T data)
        {
            Data = data;
        }

    }

    internal class Queue<T>
    {
        private QueueNode<T> first;
        private QueueNode<T> last;
        public void Enqueue(T Data)
        {
            var q = new QueueNode<T>(Data);
            if (last.Next != null)
                last.Next = q;
            last = q;
            first ??= last;
        }

        public T Dequeue()
        {
            if (first == null)
                throw new NullReferenceException("Queue is Empty");
            var data = first.Data;
            first = first.Next;
            if (first == null)
                last = null;
            return data;
        }

        public T Peek()
        {
            if (first == null)
                throw new NullReferenceException("Queue is Empty");
            return first.Data;
        }

        public void Empty()
        {
            first = null;
        }
    }
}
