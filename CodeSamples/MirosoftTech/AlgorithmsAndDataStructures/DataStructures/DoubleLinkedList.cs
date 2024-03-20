using System;

namespace DataStuctures
{
    public class First
    {
        public static DoubleNode first;
    }
   public class DoubleNode
    {
        DoubleNode PreviousNode;
        int data;
        DoubleNode NextNode;
        public DoubleNode(int v)
        {
            PreviousNode = null;
            data = v;
            NextNode = null;
        }

        public void AddToEnd(int v)
        {
            DoubleNode dn = this;
            if (dn.NextNode == null && dn.PreviousNode == null)
            {
                dn.NextNode = new DoubleNode(v)
                {
                    PreviousNode = First.first
                };

            }
            else
            {
                while (dn.NextNode != null)
                {
                    dn = dn.NextNode;
                }
                dn.NextNode = new DoubleNode(v);
                dn.NextNode.PreviousNode = dn.PreviousNode.NextNode;
            }

        }


        public void Print()
        {
            DoubleNode n = this;
            Console.Write(n.data);
            while (n.NextNode != null)
            {
                n = n.NextNode;
                Console.Write("-->{0}", n.data);
            }
        }

        public void PrintReverse()
        {
            DoubleNode n = this;

            while (n.NextNode != null)
            {
                n = n.NextNode;
            }
            while (n.PreviousNode != null)
            {
                Console.Write("-->{0}", n.data);
                n = n.PreviousNode;
            }
            Console.Write("-->{0}", n.data);
        }

    }
   public class DoubleLinkedList
    {
        public First f = new First();
        DoubleNode dn = null;
        public void AddEnd(int v)
        {
            if (dn == null)
            {
                dn = new DoubleNode(v);
                First.first = dn;
            }
            else
            {
                dn.AddToEnd(v);
            }
        }

        public void Print()
        {
            if (dn != null)
            {
                dn.Print();
            }
        }
        public void PrintReverse()
        {
            if (dn != null)
            {
                dn.PrintReverse();
            }
        }
    }
}
