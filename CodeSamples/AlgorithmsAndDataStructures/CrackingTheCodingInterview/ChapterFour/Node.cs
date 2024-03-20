namespace ChapterFour
{
    internal class Node<T>
    {
        internal readonly T? data;
        public Node(T? data)
        {
            this.data = data;
        }
        public Node<T>? left, right;
    }
}