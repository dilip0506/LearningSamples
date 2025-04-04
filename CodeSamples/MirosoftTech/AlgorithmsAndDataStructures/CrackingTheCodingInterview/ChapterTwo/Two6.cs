using DataStuctures;

namespace ChapterTwo
{
    public class LinkedList6 : LinkedList
    {
        public void Reverse()
        {
            Node prev = null;
            Node curr = head;
            while (curr != null)
            {
                Node next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            head = prev;
        }

        public LinkedList Copy()
        {
            LinkedList copy = new LinkedList();
            Node first = head;
            while (head.next != null)
            {
                copy.AddEnd(head.data);
                head = head.next;
            }
            head = first;
            return copy;
        }
    }
}
