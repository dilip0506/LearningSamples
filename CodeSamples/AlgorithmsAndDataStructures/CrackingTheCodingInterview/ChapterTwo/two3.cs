using DataStuctures;
using System;

namespace ChapterTwo
{
    partial class LinkedList
    {
        public Node MiddleNode()
        {
            Node n3 = head;
            int count = 0;
            if (n3 == null)
            {
                return null;
            }
            while (n3 != null)
            {
                count++;
                if (count == 2)
                {
                    return n3;
                }
                n3 = n3.next;
            }
            return null;
        }
    }
    class Two3
    {
        LinkedList ll = new LinkedList();
        public Two3()
        {
            ll.AddEnd(6);
            ll.AddEnd(3);
            ll.AddEnd(9);
            ll.AddEnd(4);
            ll.AddEnd(1);
            ll.AddEnd(5);
            ll.AddEnd(3);
        }
        public void DeleteMiddleNode()
        {
            Node n = ll.MiddleNode();
            if (n == null || n.next == null) { return; }
            n.data = n.next.data;
            n.next = n.next.next;
            ll.Print();
        }
        public static void Run()
        {
            Two3 t3 = new Two3();
            t3.DeleteMiddleNode();
            Console.Read();
        }
    }
}
