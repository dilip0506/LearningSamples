using System;
using DataStuctures;

namespace ChapterTwo
{
    class DoubleLinkedListTest
    {
        public static void Run()
        {
            DoubleLinkedList dll = new DoubleLinkedList();
            dll.AddEnd(1);
            dll.AddEnd(2);
            dll.AddEnd(3);
            dll.AddEnd(4);
            dll.Print();
            Console.WriteLine();
            dll.PrintReverse();
            Console.WriteLine();

            DoubleLinkedList dll2 = new DoubleLinkedList();
            dll2.AddEnd(5);
            dll2.AddEnd(6);
            dll2.AddEnd(7);
            dll2.AddEnd(8);
            dll2.Print();
            Console.WriteLine();
            dll2.PrintReverse();
            Console.Read();
        }
    }
}
