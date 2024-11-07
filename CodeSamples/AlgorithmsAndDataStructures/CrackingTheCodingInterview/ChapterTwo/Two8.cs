using DataStuctures;

namespace ChapterTwo
{
    public class LinkedList8 : LinkedList
    {

        private void CreateCircularLinkedList()
        {
            var ll = new LinkedList7();
            var node = ll.GetLengthAndTail();
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
