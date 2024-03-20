using DataStuctures;
using System;

namespace ChapterTwo
{
    static class LinkedListTest
    {
        static void Run()
        {
            LinkedList ll = new LinkedList();
            LinkedList ll2 = new LinkedList();
            ll.AddEnd(1);
            ll.AddEnd(2);
            ll.AddEnd(3);
            ll.AddEnd(4);
            ll.AddEnd(5);
            ll.AddEnd(6);
            ll.AddEnd(7);
            ll2.AddEnd(8);
            ll2.AddEnd(9);
            //var t = ll.FindIntersection(ll2);           
            //ll2 = ll.Copy();
            //ll.Reverse();
            //ll.Delete(4);
            //ll.DeleteDuplicateHash();
            // Console.WriteLine(ll.Lenght);
            // ll.KthtoLastRecrsive(2);
            // ll.LthtoLastIterative(2);
            //foreach (int i in alll) {
            //    Console.WriteLine(i);
            //}
            //ll.Partition2(5);
            //ll.Print();
            //Console.WriteLine(ll.IsCircular());
            Console.Read();
        }
    }
}
