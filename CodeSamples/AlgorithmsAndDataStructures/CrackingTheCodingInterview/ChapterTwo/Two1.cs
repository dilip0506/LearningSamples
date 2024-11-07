using DataStuctures;
using System.Collections;

namespace ChapterTwo
{
    public class LinkedList1 : LinkedList
    {
        public void DeleteDuplicate()
        {//two1
            Node n1 = head;
            while (n1 != null)
            {
                Node n2 = n1;//remove priviously seacrched elements from node n2
                while (n2.next != null)
                {
                    if (n2.next.data == n1.data)
                    {
                        n2.next = n2.next.next;
                    }
                    else
                    {
                        n2 = n2.next;
                    }
                }
                n1 = n1.next;
            }
        }

        //---------------------------------------------------------------------------------------------//
        public void DeleteDuplicateHash()
        {//two1
            ArrayList al = new ArrayList();
            Node n1 = null;
            Node n2 = head;
            while (n2 != null)
            {
                if (al.Contains(n2.data))
                {
                    n1.next = n2.next;//however after 5 line n2 is move to next ref tecnically this will be like n1.next = n2.next.next
                }
                else
                {
                    al.Add(n2.data);
                    n1 = n2;//make n1 to n2
                }
                n2 = n2.next;//after making n1 to n2, n2 is pointed to next ref
            }
        }
    }
}
