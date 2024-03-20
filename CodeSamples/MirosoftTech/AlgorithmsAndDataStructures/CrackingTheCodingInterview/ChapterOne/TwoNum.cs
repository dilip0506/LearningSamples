namespace ChapterOne
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) => val = x;
    }

    public class TwoNum
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode h = new ListNode(0);
            ListNode a = l1, b = l2, c = h;
            int carry = 0;
            while (a != null || b != null)
            {
                int i = (a != null) ? a.val : 0;
                int j = (b != null) ? b.val : 0;
                int sum = carry + i + j;
                carry = sum / 10;
                c.next = new ListNode(sum % 10);
                c = c.next;
                if (a != null) { a = a.next; }
                if (b != null) { b = b.next; }
            }
            if (carry > 0)
            {
                c.next = new ListNode(carry);
            }
            return h.next;
        }
    }
    class TwoNumTest
    {
        static void Run()
        {
            ListNode n1 = new ListNode(1);
            n1.next = new ListNode(8);
            n1.next.next = new ListNode(3);
            ListNode n2 = new ListNode(0);
            n2.next = new ListNode(5);
            n2.next.next = new ListNode(4);
            TwoNum TN = new TwoNum();
            ListNode n3 = TN.AddTwoNumbers(n1, n2);
            int i = n3.val;
            int j = n3.next.val;
            int k = n3.next.next.val;
            Console.Write("{2}{1}{0}", i, j, k);
            Console.Read();
        }
    }
}
