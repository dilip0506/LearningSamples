namespace ChapterTwo
{
    internal partial class LinkedList
    {

        private void CreateCircularLinkedList()
        {
            var node = this.GetLengthAndTail();
            node.Tail.next = this.head;
        }
        public bool IsCircular()
        {
            CreateCircularLinkedList();
            Node Node = this.head;
            Node Runner = this.head; ;
            while (Node != null && Runner.next != null)
            {
                Node = Node.next;
                Runner = Runner.next.next;
                if (Node == Runner)
                {
                    break;
                }
            }

            if (Node == null && Node.next == null)
            {
                return false;
            }

            Node = this.head;
            if (Node != Runner)
            {
                Node = Node.next;
                Runner = Runner.next;
                if (Node == Runner)
                {
                    return true;
                }
            }

            return false;

        }
    }
}
