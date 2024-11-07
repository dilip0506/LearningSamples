using DataStuctures;

namespace ChapterTwo
{
    partial class LinkedList4 : LinkedList
    {
        //my way
        public void Partition(int k)
        {
            int count = 0;
            Node np = head;
            while (np != null)
            {
                if (np.data < k)
                {
                    count++;
                }
                np = np.next;
            }
            Node np1 = head;
            for (int i = 0; i < count; i++)
            {
                np1 = np1.next;
            }

            Node np2 = head;
            int count1 = 0;
            while (count1 < count)
            {
                if ((np2.data >= k))
                {
                    while (np1 != null)
                    {
                        if (np1.data < k)
                        {
                            break;
                        }
                        np1 = np1.next;
                    }
                    int temp = np2.data;
                    np2.data = np1.data;
                    np1.data = temp;
                }
                np2 = np2.next;
                count1++;
            }
        }
        //Book Way1 keeps the order stable(orginal order)
        public void Partition1(int k)
        {
            Node n = head;
            Node BeforeStart = null;
            Node BeforeEnd = null;
            Node AfterStart = null;
            Node AfterEnd = null;
            while (n != null)
            {
                Node next = n.next;
                n.next = null;
                if (n.data < k)
                {
                    if (BeforeStart == null)
                    {
                        BeforeStart = n;
                        BeforeEnd = BeforeStart;
                    }
                    else
                    {
                        BeforeEnd.next = n;
                        BeforeEnd = n;
                    }
                }
                else
                {
                    if (AfterStart == null)
                    {
                        AfterStart = n;
                        AfterEnd = AfterStart;
                    }
                    else
                    {
                        AfterEnd.next = n;
                        AfterEnd = n;
                    }
                }
                n = next;
            }
            if (BeforeStart == null)
            {
                AfterStart.Print();
            }
            else
            {
                BeforeEnd.next = AfterStart;
                BeforeStart.Print();
            }
        }
        //Book way 2
        public void Partition2(int k)
        {
            Node n = head;
            Node start = n;
            Node end = n;
            while (n != null)
            {
                Node next = n.next;
                if (n.data < k)
                {
                    n.next = start;
                    start = n;
                }
                else
                {
                    end.next = n;
                    end = n;
                }
                n = next;
            }
            end.next = null;
            start.Print();
        }
    }
}
