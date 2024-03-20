using DataStuctures;
using System;

namespace ChapterTwo
{
    class Two5
    {
        //Myway
        public static Node LinkedListSum(Node L1, Node L2)
        {
            Node n = new Node(0);
            Node address = n;
            Node n1 = L1;
            Node n2 = L2;
            int x = 0;
            while (n1 != null || n2 != null)
            {
                int i = (n1 != null) ? n1.data : 0;
                int j = (n2 != null) ? n2.data : 0;
                int s = i + j + x;
                x = s / 10;
                address.next = new Node(s % 10);
                address = address.next;
                if (n1 != null) n1 = n1.next;
                if (n2 != null) n2 = n2.next;
            }
            if (x > 0)
            {
                address.next = new Node(x);
            }
            return n.next;
        }


        public static void Run()
        {
            Node ll1 = new Node(7);
            ll1.AddToEnd(1);
            ll1.AddToEnd(6);
            Node ll2 = new Node(5);
            ll2.AddToEnd(9);
            ll2.AddToEnd(2);
            Node ll3 = LinkedListSum(ll1, ll2);
            ll3.Print();
            Console.Read();
        }
    }
}
