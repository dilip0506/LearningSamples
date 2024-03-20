using DataStuctures;
using System;

namespace ChapterTwo
{
    public partial class LinkedList
    {

        private class TailAndSize
        {
            public int Size { get; set; }
            public Node Tail { get; set; }
        }

        private TailAndSize GetLengthAndTail()
        {
            int count = 0;
            Node n = head;
            while (n.next != null)
            {
                count++;
                n = n.next;
            }
            return new TailAndSize { Size = count, Tail = n };
        }

        private Node GetKthNode(int size, Node linkedList)
        {
            var node = linkedList;
            while (size > 0)
            {
                size--;
                node = node.next;
            }
            return node;
        }

        public Node FindIntersection(LinkedList linkedList)
        {
            linkedList.head.next.next = this.head.next;
            var firstLinkedList = this.GetLengthAndTail();
            var secondLinkedList = linkedList.GetLengthAndTail();
            var longer = (firstLinkedList.Size > secondLinkedList.Size) ? this.head : linkedList.head;
            var shorter = (firstLinkedList.Size > secondLinkedList.Size) ? linkedList.head : this.head;

            if (firstLinkedList.Tail != secondLinkedList.Tail)
            {
                return null;
            }

            longer = GetKthNode(Math.Abs(firstLinkedList.Size - secondLinkedList.Size), longer);

            while (shorter != longer)
            {
                shorter = shorter.next;
                longer = longer.next;
            }
            return shorter;
        }

    }
}
