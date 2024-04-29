using System;

namespace DataStuctures
{
    public class NodeRecursive
    {
        public int data;
        public NodeRecursive next;

        public NodeRecursive(int i)
        {
            data = i;
            next = null;
        }
        public void AddToEnd(int i)
        {
            if (next == null)
            {
                next = new NodeRecursive(i);
            }
            else
            {
                next.AddToEnd(i);
            }
        }

        //public void AddToBegining(int i)
        //{
        //    Node temp = new Node(i);
        //    temp.next = next;
        //    next = temp;
        //}
        public void Print()
        {
            Console.Write("{0}->", data);
            if (next != null)
            {
                next.Print();
            }
        }
    }

    public class LinkedListRecursive
    {
        public NodeRecursive head;
        public LinkedListRecursive()
        {
            head = null;
        }

        public void AddToEnd(int i)
        {
            if (head == null)
            {
                head = new NodeRecursive(i);
            }
            else
            {
                head.AddToEnd(i);
            }
        }
        public void AddToBegining(int i)
        {
            if (head == null)
            {
                head = new NodeRecursive(i);
            }
            else
            {
                NodeRecursive temp = new NodeRecursive(i);
                temp.next = head;
                head = temp;
            }
        }
        public void Print()
        {
            if (head != null)
            {
                head.Print();
            }
        }

    }
}
