using System;

namespace ProblemSet
{
    internal class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class AddTwoNumbers
    {
        public static ListNode Solution(ListNode l1, ListNode l2)
        {
            var node = new ListNode();
            var head = node;
            int onesPlace = 0;
            while (l1 != null || l2 != null)
            {
                int firstValue = l1 != null ? l1.val : 0;
                int secondValue = l2 != null ? l2.val : 0;
                int sumTwoDigits = firstValue + secondValue + onesPlace;
                int tenthsPlace = sumTwoDigits % 10;
                node.next = new ListNode(tenthsPlace);
                node = node.next ?? new ListNode(0);
                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
                onesPlace = sumTwoDigits / 10;
            }
            if (onesPlace > 0)
                node.next = new ListNode(onesPlace);
            return head.next;
        }

        private static ListNode ToLinkedList(int[] nums)
        {
            ListNode node = new ListNode();
            ListNode head = node;
            foreach (int num in nums)
            {
                node.next = new ListNode(num);
                node = node.next;
            }
            return head;
        }

        public static void Run()
        {
            var first = ToLinkedList(new int[] { 5 });
            var second = ToLinkedList(new int[] { 3 });
            var result = Solution(first.next, second.next);
            while (result != null)
            {
                Console.WriteLine(result.val);
                result = result.next;
            }
        }
    }
}
