using System;

namespace DataStuctures
{
    public class Index
    {
        //to save counter value from call stack for problem Two2
        public int vlaue;
    }
    public class Node
    {
        public Node next;
        public int data;
        public Node(int i)
        {
            data = i;
            next = null;
        }

        public void AddToEnd(int i)
        {
            Node n = this;
            while (n.next != null)
            {
                n = n.next;
            }
            n.next = new Node(i);
        }
        public int KthtoLastRecursive(Index idx, Node next, int k)//two2
        {
            if (next == null)
            {
                return 0;
            }
            int index = KthtoLastRecursive(idx, next.next, k);
            idx.vlaue++;// we have many other ways to return multiple values this is one way explore c# has out parameter(incomplete solution)
            if (index == k)
            {
                Console.WriteLine(next.data);
            }
            return index;
        }

        public void Print()
        {
            Node n = this;
            Console.Write(n.data);
            while (n.next != null)
            {
                n = n.next;
                Console.Write("-->{0}", n.data);
            }
        }
    }
    //create new wrapper class for node to manage the head and other issues (because some operation may point to old ref these will keep the head updated)
    public class LinkedList
    {
        protected internal Node head;
        public LinkedList()
        {
            head = null;
        }

        private int _length;
        public int Length
        {
            get
            {
                Node n = head;
                while (n.next != null)
                {
                    n = n.next;
                    _length++;
                }
                return _length + 1;
            }
        }

        public void AddEnd(int i)
        {
            if (head == null)
            {
                head = new Node(i);
            }
            else
            {
                head.AddToEnd(i);
            }
        }

        public void AddBeginning(int j)
        {
            if (head == null)
            {
                head = new Node(j);
            }
            else
            {
                Node temp = new Node(j)
                {
                    next = head
                };
                head = temp;
            }
        }

        public void Delete(int k)
        {
            Node n = head;
            if (n.data == k)
            {
                head = n.next;
            }
            while (n.next != null)
            {
                if (n.next.data == k)
                {
                    n.next = n.next.next;
                    return;
                }
                n = n.next;
            }
        }

        public void KthtoLastRecrsive(int k)
        { //two2 solution 1
            Index idx = new Index();
            head.KthtoLastRecursive(idx, head, k);
        }

        public void LthtoLastIterative(int k)
        {
            Node n1 = head;
            Node n2 = head;

            for (int i = 0; i < k; i++)
            {
                if (n1 == null) return;
                n1 = n1.next;
            }
            while (n1 != null)
            {
                n1 = n1.next;
                n2 = n2.next;
            }
            Console.WriteLine(n2.data);
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
